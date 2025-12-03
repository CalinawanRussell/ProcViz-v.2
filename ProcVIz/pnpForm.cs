using ProcVIz;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProcVIz
{
    public partial class pnpForm : BaseSchedulerForm
    {
        private readonly List<GanttBlock> ganttData = new List<GanttBlock>();

        public class GanttBlock
        {
            public string ProcessID { get; set; }
            public int Start { get; set; }
            public int End { get; set; }
        }
        public class PnpProcess
        {
            public DataGridViewRow Row { get; set; }
            public string PID { get; set; }
            public int AT { get; set; }
            public int BT { get; set; }
            public int Remaining { get; set; }
            public int CT { get; set; }
            public int Priority { get; set; }
        }

        public pnpForm()
        {
            InitializeComponent();
            HookDeleteButton(btnDelete, dgvProcessPnp, pnlGanttPnp);
            HookClearAllButton(btnClear, dgvProcessPnp, pnlGanttPnp);
            pnlGanttPnp.Paint += pnlGanttPnp_Paint;
        }

        protected override void RemoveFromGantt(string processName)
        {
            ganttData.RemoveAll(g => g.ProcessID == processName);
        }

        protected override void ClearGanttData()
        {
            ganttData.Clear();
        }
        private void pnlGanttPnp_Paint(object sender, PaintEventArgs e)
        {
            if (ganttData.Count == 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int totalTime = ganttData[ganttData.Count - 1].End;
            float scale = (float)pnlGanttPnp.Width / totalTime;

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
                    g.FillRectangle(Brushes.LightCoral, rect);
                    g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);

                    g.DrawString(block.ProcessID, font, Brushes.Black, rect, sf);
                    g.DrawString(block.Start.ToString(), font, Brushes.Black, rect.X, rect.Bottom + 5);
                    g.DrawString(block.End.ToString(), font, Brushes.Black, rect.Right - 15, rect.Bottom + 5);
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProPnp.Text) ||
                string.IsNullOrWhiteSpace(txtAtPnp.Text) ||
                string.IsNullOrWhiteSpace(txtBtPnp.Text))
            {
                MessageBox.Show("Please enter Process ID, Arrival Time, and Burst Time.");
                return;
            }

            if (!int.TryParse(txtAtPnp.Text, out int arrival) ||
                !int.TryParse(txtBtPnp.Text, out int burst) ||
                arrival < 0 || burst <= 0)
            {
                MessageBox.Show("Arrival must be ≥ 0 and Burst must be > 0.");
                return;
            }

            dgvProcessPnp.Rows.Add(txtProPnp.Text, arrival, burst, "", "", "");

            txtProPnp.Clear();
            txtAtPnp.Clear();
            txtBtPnp.Clear();

            var processes = dgvProcessPnp.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => new PnpProcess
                {
                    Row = r,
                    PID = Convert.ToString(r.Cells["ProcessID"].Value),
                    AT = Convert.ToInt32(r.Cells["Arrival"].Value),
                    BT = Convert.ToInt32(r.Cells["Burst"].Value),
                    Remaining = Convert.ToInt32(r.Cells["Burst"].Value),
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
                    .Where(p => p.Remaining > 0 && p.AT <= currentTime)
                    .OrderBy(p => p.Remaining)
                    .ThenBy(p => p.AT)
                    .ThenBy(p => p.PID)
                    .ToList();

                if (available.Count == 0)
                {
                    currentTime++;
                    lastPID = null;
                    continue;
                }

                var proc = available.First();

                if (lastPID != proc.PID)
                {
                    ganttData.Add(new GanttBlock { ProcessID = proc.PID, Start = currentTime, End = currentTime + 1 });
                }
                else
                {
                    ganttData[ganttData.Count - 1].End++;
                }

                proc.Remaining--;
                currentTime++;
                lastPID = proc.PID;

                if (proc.Remaining == 0)
                {
                    proc.CT = currentTime;
                    int tat = proc.CT - proc.AT;
                    int wt = tat - proc.BT;

                    proc.Row.Cells["Completion"].Value = proc.CT;
                    proc.Row.Cells["Turnaround"].Value = tat;
                    proc.Row.Cells["Waiting"].Value = wt;

                    completed++;
                }
            }

            pnlGanttPnp.Invalidate();
        }
        private void btnComparePnp_Click_1(object sender, EventArgs e)
        {
            var processes = dgvProcessPnp.Rows
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