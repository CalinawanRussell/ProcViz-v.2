namespace ProcVIz
{
    partial class rrForm
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
            dgvProcessRr = new DataGridView();
            ProcessID = new DataGridViewTextBoxColumn();
            Arrival = new DataGridViewTextBoxColumn();
            Burst = new DataGridViewTextBoxColumn();
            Completion = new DataGridViewTextBoxColumn();
            Turnaround = new DataGridViewTextBoxColumn();
            Waiting = new DataGridViewTextBoxColumn();
            pnlGanttRr = new Panel();
            lblProRr = new Label();
            lblBtRr = new Label();
            lblAtRr = new Label();
            txtProRr = new TextBox();
            txtBtRr = new TextBox();
            txtAtRr = new TextBox();
            lblQtRr = new Label();
            txtQtRr = new TextBox();
            btnStart = new ProcViz.RoundedButton();
            btnDelete = new ProcViz.RoundedButton();
            btnClear = new ProcViz.RoundedButton();
            btnCompareRr = new ProcViz.RoundedButton();
            btnBack = new ProcViz.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dgvProcessRr).BeginInit();
            SuspendLayout();
            // 
            // dgvProcessRr
            // 
            dgvProcessRr.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProcessRr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcessRr.Columns.AddRange(new DataGridViewColumn[] { ProcessID, Arrival, Burst, Completion, Turnaround, Waiting });
            dgvProcessRr.Location = new Point(312, 17);
            dgvProcessRr.Margin = new Padding(3, 2, 3, 2);
            dgvProcessRr.Name = "dgvProcessRr";
            dgvProcessRr.RowHeadersWidth = 49;
            dgvProcessRr.Size = new Size(531, 186);
            dgvProcessRr.TabIndex = 1;
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
            // pnlGanttRr
            // 
            pnlGanttRr.BackColor = SystemColors.ButtonHighlight;
            pnlGanttRr.Location = new Point(312, 219);
            pnlGanttRr.Margin = new Padding(3, 2, 3, 2);
            pnlGanttRr.Name = "pnlGanttRr";
            pnlGanttRr.Size = new Size(531, 122);
            pnlGanttRr.TabIndex = 9;
            pnlGanttRr.Paint += pnlGanttRr_Paint;
            // 
            // lblProRr
            // 
            lblProRr.AutoSize = true;
            lblProRr.BackColor = SystemColors.ButtonHighlight;
            lblProRr.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProRr.Location = new Point(69, 126);
            lblProRr.Name = "lblProRr";
            lblProRr.Size = new Size(90, 19);
            lblProRr.TabIndex = 10;
            lblProRr.Text = "Process ID:";
            // 
            // lblBtRr
            // 
            lblBtRr.AutoSize = true;
            lblBtRr.BackColor = SystemColors.ButtonHighlight;
            lblBtRr.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBtRr.Location = new Point(69, 170);
            lblBtRr.Name = "lblBtRr";
            lblBtRr.Size = new Size(92, 19);
            lblBtRr.TabIndex = 11;
            lblBtRr.Text = "Burst Time:";
            // 
            // lblAtRr
            // 
            lblAtRr.AutoSize = true;
            lblAtRr.BackColor = SystemColors.ButtonHighlight;
            lblAtRr.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtRr.Location = new Point(69, 213);
            lblAtRr.Name = "lblAtRr";
            lblAtRr.Size = new Size(103, 19);
            lblAtRr.TabIndex = 12;
            lblAtRr.Text = "Arrival Time:";
            // 
            // txtProRr
            // 
            txtProRr.Location = new Point(162, 126);
            txtProRr.Margin = new Padding(3, 2, 3, 2);
            txtProRr.Name = "txtProRr";
            txtProRr.Size = new Size(117, 23);
            txtProRr.TabIndex = 13;
            // 
            // txtBtRr
            // 
            txtBtRr.Location = new Point(162, 167);
            txtBtRr.Margin = new Padding(3, 2, 3, 2);
            txtBtRr.Name = "txtBtRr";
            txtBtRr.Size = new Size(117, 23);
            txtBtRr.TabIndex = 14;
            // 
            // txtAtRr
            // 
            txtAtRr.Location = new Point(162, 213);
            txtAtRr.Margin = new Padding(3, 2, 3, 2);
            txtAtRr.Name = "txtAtRr";
            txtAtRr.Size = new Size(117, 23);
            txtAtRr.TabIndex = 15;
            // 
            // lblQtRr
            // 
            lblQtRr.AutoSize = true;
            lblQtRr.BackColor = SystemColors.ButtonHighlight;
            lblQtRr.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQtRr.Location = new Point(66, 257);
            lblQtRr.Name = "lblQtRr";
            lblQtRr.Size = new Size(122, 19);
            lblQtRr.TabIndex = 16;
            lblQtRr.Text = "Quantum Time:";
            // 
            // txtQtRr
            // 
            txtQtRr.Location = new Point(182, 257);
            txtQtRr.Margin = new Padding(3, 2, 3, 2);
            txtQtRr.Name = "txtQtRr";
            txtQtRr.Size = new Size(97, 23);
            txtQtRr.TabIndex = 17;
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
            btnStart.Location = new Point(69, 307);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnStart.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnStart.Size = new Size(105, 36);
            btnStart.TabIndex = 18;
            btnStart.Text = "Run";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
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
            btnDelete.Location = new Point(183, 307);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnDelete.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnDelete.Size = new Size(105, 36);
            btnDelete.TabIndex = 19;
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
            btnClear.Location = new Point(69, 360);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnClear.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnClear.Size = new Size(105, 36);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCompareRr
            // 
            btnCompareRr.BackColor = Color.FromArgb(136, 111, 104);
            btnCompareRr.BorderColor = Color.FromArgb(136, 111, 104);
            btnCompareRr.BorderRadius = 25;
            btnCompareRr.BorderSize = 1.5F;
            btnCompareRr.FlatAppearance.BorderSize = 0;
            btnCompareRr.FlatStyle = FlatStyle.Flat;
            btnCompareRr.ForeColor = Color.White;
            btnCompareRr.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnCompareRr.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnCompareRr.Location = new Point(678, 360);
            btnCompareRr.Margin = new Padding(3, 2, 3, 2);
            btnCompareRr.Name = "btnCompareRr";
            btnCompareRr.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnCompareRr.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnCompareRr.Size = new Size(149, 36);
            btnCompareRr.TabIndex = 21;
            btnCompareRr.Text = "Compare Algorithm";
            btnCompareRr.UseVisualStyleBackColor = false;
            btnCompareRr.Click += btnCompareRr_Click;
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
            btnBack.Location = new Point(183, 360);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnBack.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnBack.Size = new Size(105, 36);
            btnBack.TabIndex = 22;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // rrForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RR;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 414);
            Controls.Add(btnBack);
            Controls.Add(btnCompareRr);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnStart);
            Controls.Add(txtQtRr);
            Controls.Add(lblQtRr);
            Controls.Add(txtAtRr);
            Controls.Add(txtBtRr);
            Controls.Add(txtProRr);
            Controls.Add(lblAtRr);
            Controls.Add(lblBtRr);
            Controls.Add(lblProRr);
            Controls.Add(pnlGanttRr);
            Controls.Add(dgvProcessRr);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "rrForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "rrForm";
            ((System.ComponentModel.ISupportInitialize)dgvProcessRr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProcessRr;
        private Panel pnlGanttRr;
        private Label lblProRr;
        private Label lblBtRr;
        private Label lblAtRr;
        private TextBox txtProRr;
        private TextBox txtBtRr;
        private TextBox txtAtRr;
        private Label lblQtRr;
        private TextBox txtQtRr;
        private ProcViz.RoundedButton btnStart;
        private DataGridViewTextBoxColumn ProcessID;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn Burst;
        private DataGridViewTextBoxColumn Completion;
        private DataGridViewTextBoxColumn Turnaround;
        private DataGridViewTextBoxColumn Waiting;
        private ProcViz.RoundedButton btnDelete;
        private ProcViz.RoundedButton btnClear;
        private ProcViz.RoundedButton btnCompareRr;
        private ProcViz.RoundedButton btnBack;
    }
}