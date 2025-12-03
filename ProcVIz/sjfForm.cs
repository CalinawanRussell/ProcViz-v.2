using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProcVIz
{
    public partial class sjfForm : BaseSchedulerForm
    {
        private readonly List<GanttBlock> ganttData = new List<GanttBlock>();

        public class GanttBlock
        {
            public string ProcessID { get; set; }
            public int Start { get; set; }
            public int End { get; set; }
        }

        public class SjfProcess
        {
            public DataGridViewRow Row { get; set; }
            public string PID { get; set; }
            public int AT { get; set; }
            public int BT { get; set; }
            public int CT { get; set; }
        }

        public sjfForm()
        {
            InitializeComponent();
            HookDeleteButton(btnDelete, dgvProcessSjf, pnlGanttSjf);
            HookClearAllButton(btnClear, dgvProcessSjf, pnlGanttSjf);
            pnlGanttSjf.Paint += pnlGanttSjf_Paint;
        }

        protected override void RemoveFromGantt(string processName)
        {
            ganttData.RemoveAll(g => g.ProcessID == processName);
        }

        protected override void ClearGanttData()
        {
            ganttData.Clear();
        }

        private void pnlGanttSjf_Paint(object sender, PaintEventArgs e)
        {
            if (ganttData.Count == 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int totalTime = ganttData[ganttData.Count - 1].End;
            float scale = (float)pnlGanttSjf.Width / totalTime;

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
                    g.FillRectangle(Brushes.LightGreen, rect);
                    g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);

                    g.DrawString(block.ProcessID, font, Brushes.Black, rect, sf);
                    g.DrawString(block.Start.ToString(), font, Brushes.Black, rect.X, rect.Bottom + 5);
                    g.DrawString(block.End.ToString(), font, Brushes.Black, rect.Right - 15, rect.Bottom + 5);
                }
            }
        }

        private void btnStartSjf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProSjf.Text) ||
                string.IsNullOrWhiteSpace(txtAtSjf.Text) ||
                string.IsNullOrWhiteSpace(txtBtSjf.Text))
            {
                MessageBox.Show("Please enter Process ID, Arrival Time, and Burst Time.");
                return;
            }

            if (!int.TryParse(txtAtSjf.Text, out int arrival) ||
                !int.TryParse(txtBtSjf.Text, out int burst) ||
                arrival < 0 || burst <= 0)
            {
                MessageBox.Show("Arrival must be ≥ 0 and Burst must be > 0.");
                return;
            }

            dgvProcessSjf.Rows.Add(txtProSjf.Text, arrival, burst, "", "", "");

            txtProSjf.Clear();
            txtAtSjf.Clear();
            txtBtSjf.Clear();

            var processes = dgvProcessSjf.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => new SjfProcess
                {
                    Row = r,
                    PID = Convert.ToString(r.Cells["ProcessID"].Value),
                    AT = Convert.ToInt32(r.Cells["Arrival"].Value),
                    BT = Convert.ToInt32(r.Cells["Burst"].Value),
                    CT = 0
                })
                .ToList();

            ganttData.Clear();
            int currentTime = processes.Min(p => p.AT);
            int completed = 0;
            string lastPID = null;

            while (completed < processes.Count)
            {
                var available = processes
                    .Where(p => p.CT == 0 && p.AT <= currentTime)
                    .OrderBy(p => p.BT)
                    .ThenBy(p => p.AT)
                    .ToList();

                if (available.Count == 0)
                {
                    currentTime++;
                    lastPID = null;
                    continue;
                }

                var proc = available.First();

                int start = currentTime;
                int ct = currentTime + proc.BT;
                int tat = ct - proc.AT;
                int wt = tat - proc.BT;

                proc.CT = ct;
                proc.Row.Cells["Completion"].Value = ct;
                proc.Row.Cells["Turnaround"].Value = tat;
                proc.Row.Cells["Waiting"].Value = wt;

                ganttData.Add(new GanttBlock { ProcessID = proc.PID, Start = start, End = ct });

                currentTime = ct;
                completed++;
            }

            pnlGanttSjf.Invalidate();
        }
        private void btnCompareSjf_Click_1(object sender, EventArgs e)
        {
            var processes = dgvProcessSjf.Rows
              .Cast<DataGridViewRow>()
              .Where(r => !r.IsNewRow)
              .Select(r => new ProcessModel
              {
                  PID = Convert.ToString(r.Cells["ProcessID"].Value),
                  AT = Convert.ToInt32(r.Cells["Arrival"].Value),
                  BT = Convert.ToInt32(r.Cells["Burst"].Value)
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