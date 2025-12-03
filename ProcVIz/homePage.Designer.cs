namespace ProcVIz
{
    partial class homePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFcfs = new ProcViz.RoundedButton();
            btnRr = new ProcViz.RoundedButton();
            btnPnp = new ProcViz.RoundedButton();
            btnSfj = new ProcViz.RoundedButton();
            SuspendLayout();
            // 
            // btnFcfs
            // 
            btnFcfs.BackColor = Color.FromArgb(136, 111, 104);
            btnFcfs.BorderColor = Color.FromArgb(136, 111, 104);
            btnFcfs.BorderRadius = 25;
            btnFcfs.BorderSize = 1.5F;
            btnFcfs.Cursor = Cursors.Hand;
            btnFcfs.FlatAppearance.BorderSize = 0;
            btnFcfs.FlatStyle = FlatStyle.Flat;
            btnFcfs.Font = new Font("Segoe UI Historic", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFcfs.ForeColor = Color.White;
            btnFcfs.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnFcfs.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnFcfs.Location = new Point(785, 157);
            btnFcfs.Name = "btnFcfs";
            btnFcfs.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnFcfs.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnFcfs.Size = new Size(159, 49);
            btnFcfs.TabIndex = 1;
            btnFcfs.Text = "FCFS";
            btnFcfs.UseVisualStyleBackColor = false;
            btnFcfs.Click += btnFcfs_Click;
            // 
            // btnRr
            // 
            btnRr.BackColor = Color.FromArgb(136, 111, 104);
            btnRr.BorderColor = Color.FromArgb(136, 111, 104);
            btnRr.BorderRadius = 25;
            btnRr.BorderSize = 1.5F;
            btnRr.Cursor = Cursors.Hand;
            btnRr.FlatAppearance.BorderSize = 0;
            btnRr.FlatStyle = FlatStyle.Flat;
            btnRr.Font = new Font("Segoe UI Historic", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRr.ForeColor = Color.White;
            btnRr.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnRr.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnRr.Location = new Point(785, 400);
            btnRr.Name = "btnRr";
            btnRr.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnRr.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnRr.Size = new Size(159, 49);
            btnRr.TabIndex = 2;
            btnRr.Text = "Round Robin";
            btnRr.UseVisualStyleBackColor = false;
            btnRr.Click += btnRr_Click;
            // 
            // btnPnp
            // 
            btnPnp.BackColor = Color.FromArgb(136, 111, 104);
            btnPnp.BorderColor = Color.FromArgb(136, 111, 104);
            btnPnp.BorderRadius = 25;
            btnPnp.BorderSize = 1.5F;
            btnPnp.Cursor = Cursors.Hand;
            btnPnp.FlatAppearance.BorderSize = 0;
            btnPnp.FlatStyle = FlatStyle.Flat;
            btnPnp.Font = new Font("Segoe UI Historic", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPnp.ForeColor = Color.White;
            btnPnp.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnPnp.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnPnp.Location = new Point(785, 319);
            btnPnp.Name = "btnPnp";
            btnPnp.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnPnp.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnPnp.Size = new Size(159, 49);
            btnPnp.TabIndex = 3;
            btnPnp.Text = "PNP";
            btnPnp.UseVisualStyleBackColor = false;
            btnPnp.Click += btnPnp_Click;
            // 
            // btnSfj
            // 
            btnSfj.BackColor = Color.FromArgb(136, 111, 104);
            btnSfj.BorderColor = Color.FromArgb(136, 111, 104);
            btnSfj.BorderRadius = 25;
            btnSfj.BorderSize = 1.5F;
            btnSfj.Cursor = Cursors.Hand;
            btnSfj.FlatAppearance.BorderSize = 0;
            btnSfj.FlatStyle = FlatStyle.Flat;
            btnSfj.Font = new Font("Segoe UI Historic", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSfj.ForeColor = Color.White;
            btnSfj.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnSfj.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnSfj.Location = new Point(785, 238);
            btnSfj.Name = "btnSfj";
            btnSfj.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnSfj.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnSfj.Size = new Size(159, 49);
            btnSfj.TabIndex = 4;
            btnSfj.Text = "SJF";
            btnSfj.UseVisualStyleBackColor = false;
            btnSfj.Click += btnSfj_Click;
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.procviz3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(990, 570);
            Controls.Add(btnSfj);
            Controls.Add(btnPnp);
            Controls.Add(btnRr);
            Controls.Add(btnFcfs);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "homePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProcViz.RoundedButton btnFcfs;
        private ProcViz.RoundedButton btnRr;
        private ProcViz.RoundedButton btnPnp;
        private ProcViz.RoundedButton btnSfj;
    }
}
