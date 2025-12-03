namespace ProcVIz
{
    partial class CompareForm
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
            dgvCompare = new DataGridView();
            Algorithm = new DataGridViewTextBoxColumn();
            AvgWT = new DataGridViewTextBoxColumn();
            AvgTAT = new DataGridViewTextBoxColumn();
            Througput = new DataGridViewTextBoxColumn();
            picboxBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCompare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxBack).BeginInit();
            SuspendLayout();
            // 
            // dgvCompare
            // 
            dgvCompare.BackgroundColor = SystemColors.ButtonFace;
            dgvCompare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompare.Columns.AddRange(new DataGridViewColumn[] { Algorithm, AvgWT, AvgTAT, Througput });
            dgvCompare.Location = new Point(34, 47);
            dgvCompare.Name = "dgvCompare";
            dgvCompare.Size = new Size(727, 376);
            dgvCompare.TabIndex = 0;
            // 
            // Algorithm
            // 
            Algorithm.HeaderText = "Algorithm";
            Algorithm.Name = "Algorithm";
            Algorithm.Width = 170;
            // 
            // AvgWT
            // 
            AvgWT.HeaderText = "Average Waiting Time";
            AvgWT.Name = "AvgWT";
            AvgWT.Width = 170;
            // 
            // AvgTAT
            // 
            AvgTAT.HeaderText = "Average Turnaround Time";
            AvgTAT.Name = "AvgTAT";
            AvgTAT.Width = 170;
            // 
            // Througput
            // 
            Througput.HeaderText = "Throughput";
            Througput.Name = "Througput";
            Througput.Width = 170;
            // 
            // picboxBack
            // 
            picboxBack.Image = Properties.Resources.Black_and_White_Retro_Y2K_Streetwear_Clothing_Logo_removebg_preview;
            picboxBack.Location = new Point(11, 3);
            picboxBack.Name = "picboxBack";
            picboxBack.Size = new Size(57, 38);
            picboxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBack.TabIndex = 1;
            picboxBack.TabStop = false;
            picboxBack.Click += picboxBack_Click;
            // 
            // CompareForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 431);
            Controls.Add(picboxBack);
            Controls.Add(dgvCompare);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CompareForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CompareForm";
            Load += CompareForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCompare).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCompare;
        private DataGridViewTextBoxColumn Algorithm;
        private DataGridViewTextBoxColumn AvgWT;
        private DataGridViewTextBoxColumn AvgTAT;
        private DataGridViewTextBoxColumn Througput;
        private PictureBox picboxBack;
    }
}