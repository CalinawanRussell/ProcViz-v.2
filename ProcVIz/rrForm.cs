using ProcVIz;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProcVIz
{
    public partial class rrForm : BaseSchedulerForm
    {
        private readonly List<GanttBlock> ganttData = new List<GanttBlock>();

        public class GanttBlock
        {
            public string ProcessID { get; set; }
            public int Start { get; set; }
            public int End { get; set; }
        }

        public class RrProcess
        {
            public DataGridViewRow Row { get; set; }
            public string PID { get; set; }
            public int AT { get; set; }
            public int BT { get; set; }
            public int Remaining { get; set; }
            public int CT { get; set; }
        }

        public rrForm()
        {
            InitializeComponent();
            HookDeleteButton(btnDelete, dgvProcessRr, pnlGanttRr);
            HookClearAllButton(btnClear, dgvProcessRr, pnlGanttRr);
            pnlGanttRr.Paint += pnlGanttRr_Paint;
        }

        protected override void RemoveFromGantt(string processName)
        {
            ganttData.RemoveAll(g => g.ProcessID == processName);
        }

        protected override void ClearGanttData()
        {
            ganttData.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProRr.Text) ||
                string.IsNullOrWhiteSpace(txtAtRr.Text) ||
                string.IsNullOrWhiteSpace(txtBtRr.Text) ||
                string.IsNullOrWhiteSpace(txtQtRr.Text))
            {
                MessageBox.Show("Please enter Process ID, Arrival Time, Burst Time, and Quantum.");
                return;
            }

            if (!int.TryParse(txtAtRr.Text, out int arrival) ||
                !int.TryParse(txtBtRr.Text, out int burst) ||
                !int.TryParse(txtQtRr.Text, out int quantum) ||
                arrival < 0 || burst <= 0 || quantum <= 0)
            {
                MessageBox.Show("Arrival ≥ 0, Burst > 0, Quantum > 0.");
                return;
            }

            dgvProcessRr.Rows.Add(txtProRr.Text, arrival, burst, "", "", "");

            txtProRr.Clear();
            txtAtRr.Clear();
            txtBtRr.Clear();
            txtQtRr.Clear();

            var processes = dgvProcessRr.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => new RrProcess
                {
                    Row = r,
                    PID = Convert.ToString(r.Cells["ProcessID"].Value),
                    AT = Convert.ToInt32(r.Cells["Arrival"].Value),
                    BT = Convert.ToInt32(r.Cells["Burst"].Value),
                    Remaining = Convert.ToInt32(r.Cells["Burst"].Value),
                    CT = 0
                })
                .OrderBy(p => p.AT)
                .ToList();

            ganttData.Clear();
            int currentTime = processes.Min(p => p.AT);
            int completed = 0;
            Queue<RrProcess> readyQueue = new Queue<RrProcess>();
            HashSet<RrProcess> enqueued = new HashSet<RrProcess>();

            while (completed < processes.Count)
            {
                foreach (var p in processes.Where(p => p.AT <= currentTime && p.Remaining > 0 && !enqueued.Contains(p)))
                {
                    readyQueue.Enqueue(p);
                    enqueued.Add(p);
                }

                if (readyQueue.Count == 0)
                {
                    currentTime++;
                    continue;
                }

                var proc = readyQueue.Dequeue();
                int slice = Math.Min(proc.Remaining, quantum);

                ganttData.Add(new GanttBlock
                {
                    ProcessID = proc.PID,
                    Start = currentTime,
                    End = currentTime + slice
                });

                proc.Remaining -= slice;
                currentTime += slice;

                foreach (var p in processes.Where(p => p.AT <= currentTime && p.Remaining > 0 && !enqueued.Contains(p)))
                {
                    readyQueue.Enqueue(p);
                    enqueued.Add(p);
                }

                if (proc.Remaining > 0)
                {
                    readyQueue.Enqueue(proc);
                }
                else
                {
                    proc.CT = currentTime;
                    completed++;

                    int tat = proc.CT - proc.AT;
                    int wt = tat - proc.BT;

                    proc.Row.Cells["Completion"].Value = proc.CT;
                    proc.Row.Cells["Turnaround"].Value = tat;
                    proc.Row.Cells["Waiting"].Value = wt;
                }
            }

            pnlGanttRr.Invalidate();
        }

        private void pnlGanttRr_Paint(object sender, PaintEventArgs e)
        {
            if (ganttData.Count == 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int totalTime = ganttData[ganttData.Count - 1].End;
            float scale = (float)pnlGanttRr.Width / Math.Max(1, totalTime);

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
                    RectangleF rect = new RectangleF(x, 20, Math.Max(1f, w), 40);

                    g.FillRectangle(Brushes.LightBlue, rect);
                    g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);

                    g.DrawString(block.ProcessID, font, Brushes.Black, rect, sf);
                    g.DrawString(block.Start.ToString(), font, Brushes.Black, rect.X, rect.Bottom + 5);
                    g.DrawString(block.End.ToString(), font, Brushes.Black, rect.Right - 15, rect.Bottom + 5);
                }
            }
        }
        private void btnCompareRr_Click(object sender, EventArgs e)
        {
            var processes = dgvProcessRr.Rows
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

            int quantum = 2;
            if (int.TryParse(txtQtRr.Text, out int q) && q > 0)
                quantum = q;

            CompareForm compare = new CompareForm(processes, quantum);
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