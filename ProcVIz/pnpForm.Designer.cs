namespace ProcVIz
{
    partial class pnpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProcessPnp = new DataGridView();
            ProcessID = new DataGridViewTextBoxColumn();
            Arrival = new DataGridViewTextBoxColumn();
            Burst = new DataGridViewTextBoxColumn();
            Completion = new DataGridViewTextBoxColumn();
            Turnaround = new DataGridViewTextBoxColumn();
            Waiting = new DataGridViewTextBoxColumn();
            pnlGanttPnp = new Panel();
            lblProPnp = new Label();
            lblBtPnp = new Label();
            lblAtPnp = new Label();
            txtProPnp = new TextBox();
            txtAtPnp = new TextBox();
            txtBtPnp = new TextBox();
            btnRun = new ProcViz.RoundedButton();
            btnDelete = new ProcViz.RoundedButton();
            btnClear = new ProcViz.RoundedButton();
            btnComparePnp = new ProcViz.RoundedButton();
            btnBack = new ProcViz.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dgvProcessPnp).BeginInit();
            SuspendLayout();
            // 
            // dgvProcessPnp
            // 
            dgvProcessPnp.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProcessPnp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcessPnp.Columns.AddRange(new DataGridViewColumn[] { ProcessID, Arrival, Burst, Completion, Turnaround, Waiting });
            dgvProcessPnp.Location = new Point(310, 18);
            dgvProcessPnp.Margin = new Padding(3, 2, 3, 2);
            dgvProcessPnp.Name = "dgvProcessPnp";
            dgvProcessPnp.RowHeadersWidth = 49;
            dgvProcessPnp.Size = new Size(531, 186);
            dgvProcessPnp.TabIndex = 2;
            // 
            // ProcessID
            // 
            ProcessID.HeaderText = "Process ID";
            ProcessID.MinimumWidth = 6;
            ProcessID.Name = "ProcessID";
            ProcessID.Width = 90;
            // 
            // Arrival
            // 
            Arrival.HeaderText = "Arrival Time";
            Arrival.MinimumWidth = 6;
            Arrival.Name = "Arrival";
            Arrival.Width = 93;
            // 
            // Burst
            // 
            Burst.HeaderText = "Burst Time";
            Burst.MinimumWidth = 6;
            Burst.Name = "Burst";
            Burst.Width = 93;
            // 
            // Completion
            // 
            Completion.HeaderText = "Completion Time";
            Completion.MinimumWidth = 6;
            Completion.Name = "Completion";
            Completion.Width = 93;
            // 
            // Turnaround
            // 
            Turnaround.HeaderText = "Turnaround Time";
            Turnaround.MinimumWidth = 6;
            Turnaround.Name = "Turnaround";
            Turnaround.Width = 93;
            // 
            // Waiting
            // 
            Waiting.HeaderText = "Waiting Time";
            Waiting.MinimumWidth = 6;
            Waiting.Name = "Waiting";
            Waiting.Width = 93;
            // 
            // pnlGanttPnp
            // 
            pnlGanttPnp.BackColor = SystemColors.ButtonHighlight;
            pnlGanttPnp.Location = new Point(310, 217);
            pnlGanttPnp.Margin = new Padding(3, 2, 3, 2);
            pnlGanttPnp.Name = "pnlGanttPnp";
            pnlGanttPnp.Size = new Size(531, 122);
            pnlGanttPnp.TabIndex = 10;
            // 
            // lblProPnp
            // 
            lblProPnp.AutoSize = true;
            lblProPnp.BackColor = SystemColors.ButtonHighlight;
            lblProPnp.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProPnp.Location = new Point(68, 150);
            lblProPnp.Name = "lblProPnp";
            lblProPnp.Size = new Size(90, 19);
            lblProPnp.TabIndex = 11;
            lblProPnp.Text = "Process ID:";
            // 
            // lblBtPnp
            // 
            lblBtPnp.AutoSize = true;
            lblBtPnp.BackColor = SystemColors.ButtonHighlight;
            lblBtPnp.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBtPnp.Location = new Point(68, 242);
            lblBtPnp.Name = "lblBtPnp";
            lblBtPnp.Size = new Size(92, 19);
            lblBtPnp.TabIndex = 12;
            lblBtPnp.Text = "Burst Time:";
            // 
            // lblAtPnp
            // 
            lblAtPnp.AutoSize = true;
            lblAtPnp.BackColor = SystemColors.ButtonHighlight;
            lblAtPnp.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtPnp.Location = new Point(68, 197);
            lblAtPnp.Name = "lblAtPnp";
            lblAtPnp.Size = new Size(103, 19);
            lblAtPnp.TabIndex = 13;
            lblAtPnp.Text = "Arrival Time:";
            // 
            // txtProPnp
            // 
            txtProPnp.Location = new Point(161, 150);
            txtProPnp.Margin = new Padding(3, 2, 3, 2);
            txtProPnp.Name = "txtProPnp";
            txtProPnp.Size = new Size(117, 23);
            txtProPnp.TabIndex = 14;
            // 
            // txtAtPnp
            // 
            txtAtPnp.Location = new Point(161, 197);
            txtAtPnp.Margin = new Padding(3, 2, 3, 2);
            txtAtPnp.Name = "txtAtPnp";
            txtAtPnp.Size = new Size(117, 23);
            txtAtPnp.TabIndex = 15;
            // 
            // txtBtPnp
            // 
            txtBtPnp.Location = new Point(161, 242);
            txtBtPnp.Margin = new Padding(3, 2, 3, 2);
            txtBtPnp.Name = "txtBtPnp";
            txtBtPnp.Size = new Size(117, 23);
            txtBtPnp.TabIndex = 16;
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.FromArgb(136, 111, 104);
            btnRun.BorderColor = Color.FromArgb(136, 111, 104);
            btnRun.BorderRadius = 25;
            btnRun.BorderSize = 1.5F;
            btnRun.FlatAppearance.BorderSize = 0;
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.ForeColor = Color.White;
            btnRun.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnRun.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnRun.Location = new Point(68, 304);
            btnRun.Margin = new Padding(3, 2, 3, 2);
            btnRun.Name = "btnRun";
            btnRun.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnRun.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnRun.Size = new Size(105, 36);
            btnRun.TabIndex = 19;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(136, 111, 104);
            btnDelete.BorderColor = Color.FromArgb(136, 111, 104);
            btnDelete.BorderRadius = 25;
            btnDelete.BorderSize = 1.5F;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnDelete.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnDelete.Location = new Point(186, 304);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnDelete.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnDelete.Size = new Size(105, 36);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete Process";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(136, 111, 104);
            btnClear.BorderColor = Color.FromArgb(136, 111, 104);
            btnClear.BorderRadius = 25;
            btnClear.BorderSize = 1.5F;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnClear.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnClear.Location = new Point(68, 360);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnClear.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnClear.Size = new Size(105, 36);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnComparePnp
            // 
            btnComparePnp.BackColor = Color.FromArgb(136, 111, 104);
            btnComparePnp.BorderColor = Color.FromArgb(136, 111, 104);
            btnComparePnp.BorderRadius = 25;
            btnComparePnp.BorderSize = 1.5F;
            btnComparePnp.FlatAppearance.BorderSize = 0;
            btnComparePnp.FlatStyle = FlatStyle.Flat;
            btnComparePnp.ForeColor = Color.White;
            btnComparePnp.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnComparePnp.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnComparePnp.Location = new Point(678, 360);
            btnComparePnp.Margin = new Padding(3, 2, 3, 2);
            btnComparePnp.Name = "btnComparePnp";
            btnComparePnp.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnComparePnp.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnComparePnp.Size = new Size(149, 36);
            btnComparePnp.TabIndex = 22;
            btnComparePnp.Text = "Compare Algorithm";
            btnComparePnp.UseVisualStyleBackColor = false;
            btnComparePnp.Click += btnComparePnp_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(136, 111, 104);
            btnBack.BorderColor = Color.FromArgb(136, 111, 104);
            btnBack.BorderRadius = 25;
            btnBack.BorderSize = 1.5F;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnBack.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnBack.Location = new Point(186, 360);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnBack.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnBack.Size = new Size(105, 36);
            btnBack.TabIndex = 23;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pnp11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 414);
            Controls.Add(btnBack);
            Controls.Add(btnComparePnp);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnRun);
            Controls.Add(txtBtPnp);
            Controls.Add(txtAtPnp);
            Controls.Add(txtProPnp);
            Controls.Add(lblAtPnp);
            Controls.Add(lblBtPnp);
            Controls.Add(lblProPnp);
            Controls.Add(pnlGanttPnp);
            Controls.Add(dgvProcessPnp);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "pnpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pnpForm";
            ((System.ComponentModel.ISupportInitialize)dgvProcessPnp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProcessPnp;
        private Panel pnlGanttPnp;
        private Label lblProPnp;
        private Label lblBtPnp;
        private Label lblAtPnp;
        private TextBox txtProPnp;
        private TextBox txtAtPnp;
        private TextBox txtBtPnp;
        private ProcViz.RoundedButton btnRun;
        private DataGridViewTextBoxColumn ProcessID;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn Burst;
        private DataGridViewTextBoxColumn Completion;
        private DataGridViewTextBoxColumn Turnaround;
        private DataGridViewTextBoxColumn Waiting;
        private ProcViz.RoundedButton btnDelete;
        private ProcViz.RoundedButton btnClear;
        private ProcViz.RoundedButton btnComparePnp;
        private ProcViz.RoundedButton btnBack;
    }
}