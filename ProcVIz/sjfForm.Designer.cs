namespace ProcVIz
{
    partial class sjfForm
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
            dgvProcessSjf = new DataGridView();
            ProcessID = new DataGridViewTextBoxColumn();
            Arrival = new DataGridViewTextBoxColumn();
            Burst = new DataGridViewTextBoxColumn();
            Completion = new DataGridViewTextBoxColumn();
            Turnaround = new DataGridViewTextBoxColumn();
            Waiting = new DataGridViewTextBoxColumn();
            lblProSjf = new Label();
            lblBtSjf = new Label();
            lblAtSjf = new Label();
            btnStart = new ProcViz.RoundedButton();
            txtProSjf = new TextBox();
            txtBtSjf = new TextBox();
            txtAtSjf = new TextBox();
            pnlGanttSjf = new Panel();
            btnDelete = new ProcViz.RoundedButton();
            btnClear = new ProcViz.RoundedButton();
            btnCompareSjf = new ProcViz.RoundedButton();
            btnBack = new ProcViz.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dgvProcessSjf).BeginInit();
            SuspendLayout();
            // 
            // dgvProcessSjf
            // 
            dgvProcessSjf.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProcessSjf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcessSjf.Columns.AddRange(new DataGridViewColumn[] { ProcessID, Arrival, Burst, Completion, Turnaround, Waiting });
            dgvProcessSjf.Location = new Point(303, 21);
            dgvProcessSjf.Margin = new Padding(3, 2, 3, 2);
            dgvProcessSjf.Name = "dgvProcessSjf";
            dgvProcessSjf.RowHeadersWidth = 49;
            dgvProcessSjf.Size = new Size(531, 186);
            dgvProcessSjf.TabIndex = 1;
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
            // lblProSjf
            // 
            lblProSjf.AutoSize = true;
            lblProSjf.BackColor = SystemColors.ButtonHighlight;
            lblProSjf.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProSjf.Location = new Point(75, 152);
            lblProSjf.Name = "lblProSjf";
            lblProSjf.Size = new Size(90, 19);
            lblProSjf.TabIndex = 2;
            lblProSjf.Text = "Process ID:";
            // 
            // lblBtSjf
            // 
            lblBtSjf.AutoSize = true;
            lblBtSjf.BackColor = SystemColors.ButtonHighlight;
            lblBtSjf.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBtSjf.Location = new Point(75, 197);
            lblBtSjf.Name = "lblBtSjf";
            lblBtSjf.Size = new Size(92, 19);
            lblBtSjf.TabIndex = 4;
            lblBtSjf.Text = "Burst Time:";
            // 
            // lblAtSjf
            // 
            lblAtSjf.AutoSize = true;
            lblAtSjf.BackColor = SystemColors.ButtonHighlight;
            lblAtSjf.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtSjf.Location = new Point(75, 243);
            lblAtSjf.Name = "lblAtSjf";
            lblAtSjf.Size = new Size(103, 19);
            lblAtSjf.TabIndex = 5;
            lblAtSjf.Text = "Arrival Time:";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(136, 111, 104);
            btnStart.BorderColor = Color.FromArgb(136, 111, 104);
            btnStart.BorderRadius = 25;
            btnStart.BorderSize = 1.5F;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.ForeColor = Color.White;
            btnStart.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnStart.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnStart.Location = new Point(60, 297);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnStart.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnStart.Size = new Size(105, 36);
            btnStart.TabIndex = 8;
            btnStart.Text = "Run";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // txtProSjf
            // 
            txtProSjf.Location = new Point(168, 148);
            txtProSjf.Margin = new Padding(3, 2, 3, 2);
            txtProSjf.Name = "txtProSjf";
            txtProSjf.Size = new Size(117, 23);
            txtProSjf.TabIndex = 9;
            // 
            // txtBtSjf
            // 
            txtBtSjf.Location = new Point(168, 194);
            txtBtSjf.Margin = new Padding(3, 2, 3, 2);
            txtBtSjf.Name = "txtBtSjf";
            txtBtSjf.Size = new Size(117, 23);
            txtBtSjf.TabIndex = 10;
            // 
            // txtAtSjf
            // 
            txtAtSjf.Location = new Point(175, 243);
            txtAtSjf.Margin = new Padding(3, 2, 3, 2);
            txtAtSjf.Name = "txtAtSjf";
            txtAtSjf.Size = new Size(110, 23);
            txtAtSjf.TabIndex = 11;
            // 
            // pnlGanttSjf
            // 
            pnlGanttSjf.BackColor = SystemColors.ButtonHighlight;
            pnlGanttSjf.Location = new Point(303, 220);
            pnlGanttSjf.Margin = new Padding(3, 2, 3, 2);
            pnlGanttSjf.Name = "pnlGanttSjf";
            pnlGanttSjf.Size = new Size(531, 122);
            pnlGanttSjf.TabIndex = 12;
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
            btnDelete.Location = new Point(178, 297);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnDelete.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnDelete.Size = new Size(105, 36);
            btnDelete.TabIndex = 13;
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
            btnClear.Location = new Point(60, 346);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnClear.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnClear.Size = new Size(105, 36);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCompareSjf
            // 
            btnCompareSjf.BackColor = Color.FromArgb(136, 111, 104);
            btnCompareSjf.BorderColor = Color.FromArgb(136, 111, 104);
            btnCompareSjf.BorderRadius = 25;
            btnCompareSjf.BorderSize = 1.5F;
            btnCompareSjf.FlatAppearance.BorderSize = 0;
            btnCompareSjf.FlatStyle = FlatStyle.Flat;
            btnCompareSjf.ForeColor = Color.White;
            btnCompareSjf.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnCompareSjf.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnCompareSjf.Location = new Point(678, 360);
            btnCompareSjf.Margin = new Padding(3, 2, 3, 2);
            btnCompareSjf.Name = "btnCompareSjf";
            btnCompareSjf.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnCompareSjf.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnCompareSjf.Size = new Size(149, 36);
            btnCompareSjf.TabIndex = 15;
            btnCompareSjf.Text = "Compare Algorithm";
            btnCompareSjf.UseVisualStyleBackColor = false;
            btnCompareSjf.Click += btnCompareSjf_Click_1;
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
            btnBack.Location = new Point(178, 346);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnBack.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnBack.Size = new Size(105, 36);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // sjfForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.SJF1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 414);
            Controls.Add(btnBack);
            Controls.Add(btnCompareSjf);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(pnlGanttSjf);
            Controls.Add(txtAtSjf);
            Controls.Add(txtBtSjf);
            Controls.Add(txtProSjf);
            Controls.Add(btnStart);
            Controls.Add(lblAtSjf);
            Controls.Add(lblBtSjf);
            Controls.Add(lblProSjf);
            Controls.Add(dgvProcessSjf);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "sjfForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sjfForm";
            ((System.ComponentModel.ISupportInitialize)dgvProcessSjf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProcessSjf;
        private Label lblProSjf;
        private Label lblBtSjf;
        private Label lblAtSjf;
        private ProcViz.RoundedButton btnStart;
        private TextBox txtProSjf;
        private TextBox txtBtSjf;
        private TextBox txtAtSjf;
        private Panel pnlGanttSjf;
        private DataGridViewTextBoxColumn ProcessID;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn Burst;
        private DataGridViewTextBoxColumn Completion;
        private DataGridViewTextBoxColumn Turnaround;
        private DataGridViewTextBoxColumn Waiting;
        private ProcViz.RoundedButton btnDelete;
        private ProcViz.RoundedButton btnClear;
        private ProcViz.RoundedButton btnCompareSjf;
        private ProcViz.RoundedButton btnBack;
    }
}