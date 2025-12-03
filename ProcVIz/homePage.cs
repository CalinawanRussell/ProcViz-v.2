namespace ProcVIz
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void btnFcfs_Click(object sender, EventArgs e)
        {
            this.Hide();
            fcfsForm fcfs = new fcfsForm();
            fcfs.Show();
        }

        private void btnSfj_Click(object sender, EventArgs e)
        {
            this.Hide();
            sjfForm sjf = new sjfForm();
            sjf.Show();
        }

        private void btnPnp_Click(object sender, EventArgs e)
        {
            this.Hide();
            pnpForm pnp = new pnpForm();
            pnp.Show();
        }

        private void btnRr_Click(object sender, EventArgs e)
        {
            this.Hide();
            rrForm rr = new rrForm();
            rr.Show();
        }
    }
}