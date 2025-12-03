using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProcVIz
{
    public partial class CompareForm : Form
    {
        private readonly List<ProcessModel> _processes;
        private readonly int _quantum;

        public CompareForm(List<ProcessModel> processes, int quantum = 2)
        {
            InitializeComponent();
            _processes = processes;
            _quantum = quantum;

            SetupGrid();       // define columns programmatically
            LoadComparison();  // fill with results
        }

        private void SetupGrid()
        {
            dgvCompare.Columns.Clear();
            dgvCompare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompare.AllowUserToAddRows = false;
            dgvCompare.ReadOnly = true;

            dgvCompare.Columns.Add("Algorithm", "Algorithm");
            dgvCompare.Columns.Add("AvgWT", "Average Waiting Time");
            dgvCompare.Columns.Add("AvgTAT", "Average Turnaround Time");
            dgvCompare.Columns.Add("Throughput", "Throughput");
        }

        private void LoadComparison()
        {
            var fcfs = SchedulerAlgorithms.RunFCFS(_processes);
            var sjf = SchedulerAlgorithms.RunSJF(_processes);
            var pnp = SchedulerAlgorithms.RunPNP(_processes);
            var rr = SchedulerAlgorithms.RunRR(_processes, _quantum);

            dgvCompare.Rows.Clear();
            dgvCompare.Rows.Add("FCFS", fcfs.AvgWaiting.ToString("F2"), fcfs.AvgTurnaround.ToString("F2"), fcfs.Throughput.ToString("F3"));
            dgvCompare.Rows.Add("SJF", sjf.AvgWaiting.ToString("F2"), sjf.AvgTurnaround.ToString("F2"), sjf.Throughput.ToString("F3"));
            dgvCompare.Rows.Add("Preemptive Priority", pnp.AvgWaiting.ToString("F2"), pnp.AvgTurnaround.ToString("F2"), pnp.Throughput.ToString("F3"));
            dgvCompare.Rows.Add("Round Robin", rr.AvgWaiting.ToString("F2"), rr.AvgTurnaround.ToString("F2"), rr.Throughput.ToString("F3"));
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {

        }

        private void CompareForm_Load_1(object sender, EventArgs e)
        {

        }

        private void picboxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage homeForm = new homePage();
            homeForm.Show();
        }
    }
}