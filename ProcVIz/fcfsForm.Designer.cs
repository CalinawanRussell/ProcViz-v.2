
namespace ProcVIz
{
    partial class fcfsForm
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
            dgvProcess = new DataGridView();
            Process = new DataGridViewTextBoxColumn();
            Arrival = new DataGridViewTextBoxColumn();
            Burst = new DataGridViewTextBoxColumn();
            Completion = new DataGridViewTextBoxColumn();
            Turnaround = new DataGridViewTextBoxColumn();
            Waiting = new DataGridViewTextBoxColumn();
            lblProFcfs = new Label();
            txtProFcfs = new TextBox();
            lblBtFcfs = new Label();
            lblAtFcfs = new Label();
            txtBtFcfs = new TextBox();
            txtAtFcfs = new TextBox();
            pnlGantt = new Panel();
            btnStartFcfs = new ProcViz.RoundedButton();
            btnDelete = new ProcViz.RoundedButton();
            btnClear = new ProcViz.RoundedButton();
            btnCompare = new ProcViz.RoundedButton();
            btnBack = new ProcViz.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dgvProcess).BeginInit();
            SuspendLayout();
            // 
            // dgvProcess
            // 
            dgvProcess.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProcess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcess.Columns.AddRange(new DataGridViewColumn[] { Process, Arrival, Burst, Completion, Turnaround, Waiting });
            dgvProcess.Location = new Point(296, 19);
            dgvProcess.Margin = new Padding(3, 2, 3, 2);
            dgvProcess.Name = "dgvProcess";
            dgvProcess.RowHeadersWidth = 49;
            dgvProcess.Size = new Size(531, 186);
            dgvProcess.TabIndex = 0;
            // 
            // Process
            // 
            Process.HeaderText = "Process ID";
            Process.MinimumWidth = 6;
            Process.Name = "Process";
            Process.Width = 90;
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
            // lblProFcfs
            // 
            lblProFcfs.AutoSize = true;
            lblProFcfs.BackColor = SystemColors.ButtonHighlight;
            lblProFcfs.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProFcfs.Location = new Point(67, 160);
            lblProFcfs.Name = "lblProFcfs";
            lblProFcfs.Size = new Size(90, 19);
            lblProFcfs.TabIndex = 1;
            lblProFcfs.Text = "Process ID:";
            // 
            // txtProFcfs
            // 
            txtProFcfs.Location = new Point(157, 160);
            txtProFcfs.Margin = new Padding(3, 2, 3, 2);
            txtProFcfs.Name = "txtProFcfs";
            txtProFcfs.Size = new Size(117, 23);
            txtProFcfs.TabIndex = 2;
            // 
            // lblBtFcfs
            // 
            lblBtFcfs.AutoSize = true;
            lblBtFcfs.BackColor = SystemColors.ButtonHighlight;
            lblBtFcfs.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBtFcfs.Location = new Point(67, 250);
            lblBtFcfs.Name = "lblBtFcfs";
            lblBtFcfs.Size = new Size(92, 19);
            lblBtFcfs.TabIndex = 3;
            lblBtFcfs.Text = "Burst Time:";
            // 
            // lblAtFcfs
            // 
            lblAtFcfs.AutoSize = true;
            lblAtFcfs.BackColor = SystemColors.ButtonHighlight;
            lblAtFcfs.Font = new Font("Tahoma", 11.2695656F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtFcfs.Location = new Point(66, 207);
            lblAtFcfs.Name = "lblAtFcfs";
            lblAtFcfs.Size = new Size(103, 19);
            lblAtFcfs.TabIndex = 4;
            lblAtFcfs.Text = "Arrival Time:";
            // 
            // txtBtFcfs
            // 
            txtBtFcfs.Location = new Point(158, 249);
            txtBtFcfs.Margin = new Padding(3, 2, 3, 2);
            txtBtFcfs.Name = "txtBtFcfs";
            txtBtFcfs.Size = new Size(117, 23);
            txtBtFcfs.TabIndex = 5;
            // 
            // txtAtFcfs
            // 
            txtAtFcfs.Location = new Point(164, 204);
            txtAtFcfs.Margin = new Padding(3, 2, 3, 2);
            txtAtFcfs.Name = "txtAtFcfs";
            txtAtFcfs.Size = new Size(110, 23);
            txtAtFcfs.TabIndex = 6;
            // 
            // pnlGantt
            // 
            pnlGantt.BackColor = SystemColors.ButtonHighlight;
            pnlGantt.Location = new Point(296, 216);
            pnlGantt.Margin = new Padding(3, 2, 3, 2);
            pnlGantt.Name = "pnlGantt";
            pnlGantt.Size = new Size(531, 122);
            pnlGantt.TabIndex = 8;
            pnlGantt.Paint += pnlGantt_Paint;
            // 
            // btnStartFcfs
            // 
            btnStartFcfs.BackColor = Color.FromArgb(136, 111, 104);
            btnStartFcfs.BorderColor = Color.FromArgb(136, 111, 104);
            btnStartFcfs.BorderRadius = 25;
            btnStartFcfs.BorderSize = 1.5F;
            btnStartFcfs.FlatAppearance.BorderSize = 0;
            btnStartFcfs.FlatStyle = FlatStyle.Flat;
            btnStartFcfs.ForeColor = Color.White;
            btnStartFcfs.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnStartFcfs.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnStartFcfs.Location = new Point(65, 302);
            btnStartFcfs.Margin = new Padding(3, 2, 3, 2);
            btnStartFcfs.Name = "btnStartFcfs";
            btnStartFcfs.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnStartFcfs.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnStartFcfs.Size = new Size(105, 36);
            btnStartFcfs.TabIndex = 20;
            btnStartFcfs.Text = "Run";
            btnStartFcfs.UseVisualStyleBackColor = false;
            btnStartFcfs.Click += btnStartFcfs_Click_1;
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
            btnDelete.Location = new Point(178, 302);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnDelete.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnDelete.Size = new Size(105, 36);
            btnDelete.TabIndex = 21;
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
            btnClear.Location = new Point(67, 351);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnClear.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnClear.Size = new Size(105, 36);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCompare
            // 
            btnCompare.BackColor = Color.FromArgb(136, 111, 104);
            btnCompare.BorderColor = Color.FromArgb(136, 111, 104);
            btnCompare.BorderRadius = 25;
            btnCompare.BorderSize = 1.5F;
            btnCompare.FlatAppearance.BorderSize = 0;
            btnCompare.FlatStyle = FlatStyle.Flat;
            btnCompare.ForeColor = Color.White;
            btnCompare.HoverBackColor = Color.FromArgb(142, 117, 110);
            btnCompare.HoverBorderColor = Color.FromArgb(142, 117, 110);
            btnCompare.Location = new Point(678, 360);
            btnCompare.Margin = new Padding(3, 2, 3, 2);
            btnCompare.Name = "btnCompare";
            btnCompare.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnCompare.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnCompare.Size = new Size(149, 36);
            btnCompare.TabIndex = 23;
            btnCompare.Text = "Compare Algorithm";
            btnCompare.UseVisualStyleBackColor = false;
            btnCompare.Click += btnCompare_Click_1;
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
            btnBack.Location = new Point(178, 351);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.PressedBackColor = Color.FromArgb(130, 105, 98);
            btnBack.PressedBorderColor = Color.FromArgb(130, 105, 98);
            btnBack.Size = new Size(105, 36);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // fcfsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FCFS1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 414);
            Controls.Add(btnBack);
            Controls.Add(btnCompare);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnStartFcfs);
            Controls.Add(pnlGantt);
            Controls.Add(txtAtFcfs);
            Controls.Add(txtBtFcfs);
            Controls.Add(lblAtFcfs);
            Controls.Add(lblBtFcfs);
            Controls.Add(txtProFcfs);
            Controls.Add(lblProFcfs);
            Controls.Add(dgvProcess);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "fcfsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fcfs";
            ((System.ComponentModel.ISupportInitialize)dgvProcess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProcess;
        private Label lblProFcfs;
        private TextBox txtProFcfs;
        private Label lblBtFcfs;
        private Label lblAtFcfs;
        private TextBox txtBtFcfs;
        private TextBox txtAtFcfs;
        private ProcViz.RoundedButton btnStartFcfs;
        private DataGridViewTextBoxColumn Process;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn Burst;
        private DataGridViewTextBoxColumn Completion;
        private DataGridViewTextBoxColumn Turnaround;
        private DataGridViewTextBoxColumn Waiting;
        private Panel pnlGantt;
        private EventHandler fcfsForm_Load;
        private ProcViz.RoundedButton btnDelete;
        private ProcViz.RoundedButton btnClear;
        private ProcViz.RoundedButton btnCompare;
        private ProcViz.RoundedButton btnBack;
    }
}