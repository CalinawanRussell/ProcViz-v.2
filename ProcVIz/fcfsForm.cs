using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProcVIz
{
    public partial class fcfsForm : BaseSchedulerForm
    {
        private readonly List<GanttBlock> ganttData = new List<GanttBlock>();

        public class GanttBlock
        {
            public string ProcessID { get; set; }
            public int Start { get; set; }
            public int End { get; set; }
        }

        public fcfsForm()
        {
            InitializeComponent();
            HookDeleteButton(btnDelete, dgvProcess, pnlGantt);
            HookClearAllButton(btnClear, dgvProcess, pnlGantt);
        }

        protected override void RemoveFromGantt(string processName)
        {
            ganttData.RemoveAll(g => g.ProcessID == processName);
        }

        protected override void ClearGanttData()
        {
            ganttData.Clear();
        }

        private void btnStartFcfs_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProFcfs.Text) ||
                string.IsNullOrWhiteSpace(txtAtFcfs.Text) ||
                string.IsNullOrWhiteSpace(txtBtFcfs.Text))
            {
                MessageBox.Show("Please enter Process ID, Arrival Time, and Burst Time.");
                return;
            }

            if (!int.TryParse(txtAtFcfs.Text, out int arrival) ||
                !int.TryParse(txtBtFcfs.Text, out int burst))
            {
                MessageBox.Show("Arrival Time and Burst Time must be numbers.");
                return;
            }

            dgvProcess.Rows.Add(txtProFcfs.Text, arrival, burst, "", "", "");

            txtProFcfs.Clear();
            txtAtFcfs.Clear();
            txtBtFcfs.Clear();

            ganttData.Clear();
            int currentTime = 0;

            var rows = dgvProcess.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .OrderBy(r => Convert.ToInt32(r.Cells["Arrival"].Value))
                .ToList();

            foreach (var row in rows)
            {
                int at = Convert.ToInt32(row.Cells["Arrival"].Value);
                int bt = Convert.ToInt32(row.Cells["Burst"].Value);
                string pid = row.Cells["Process"].Value.ToString();

                if (currentTime < at)
                    currentTime = at;

                int start = currentTime;
                int ct = currentTime + bt;
                int tat = ct - at;
                int wt = tat - bt;

                row.Cells["Completion"].Value = ct;
                row.Cells["Turnaround"].Value = tat;
                row.Cells["Waiting"].Value = wt;

                ganttData.Add(new GanttBlock { ProcessID = pid, Start = start, End = ct });

                currentTime = ct;
            }

            pnlGantt.Invalidate();
        }
        private void pnlGantt_Paint(object sender, PaintEventArgs e)
        {
            if (ganttData.Count == 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int totalTime = ganttData[ganttData.Count - 1].End;
            float scale = (float)pnlGantt.Width / totalTime;

            using (Font font = new Font("Arial", 9))
            using (Pen pen = new Pen(Color.Black, 1))
            using (StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                foreach (var block in ganttData)
                {
                    float x = block.Start * scale;
                    float w = (block.End - block.Start) * scale;

                    RectangleF rect = new RectangleF(x, 20, w, 40);
                    g.FillRectangle(Brushes.LightBlue, rect);
                    g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);

                    g.DrawString(block.ProcessID, font, Brushes.Black, rect, sf);
                    g.DrawString(block.Start.ToString(), font, Brushes.Black, rect.X, rect.Bottom + 5);
                    g.DrawString(block.End.ToString(), font, Brushes.Black, rect.Right - 15, rect.Bottom + 5);
                }
            }
        }
        private void btnCompare_Click_1(object sender, EventArgs e)
        {
            var processes = dgvProcess.Rows
               .Cast<DataGridViewRow>()
               .Where(r => !r.IsNewRow)
               .Select(r => new ProcessModel
               {
                   PID = Convert.ToString(r.Cells["Process"].Value),
                   AT = Convert.ToInt32(r.Cells["Arrival"].Value),
                   BT = Convert.ToInt32(r.Cells["Burst"].Value),
               })
               .ToList();

            if (processes.Count == 0)
            {
                MessageBox.Show("Please add at least one process before comparing.",
                                "No Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            CompareForm compare = new CompareForm(processes);
            compare.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homeForm = new homePage();
            homeForm.Show();
        }
    }
}