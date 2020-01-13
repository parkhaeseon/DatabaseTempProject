namespace DatabaseTeamProject
{
    partial class doctorRank
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
            this.label7 = new System.Windows.Forms.Label();
            this.doctorRankGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.doctorRankGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(131, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 31);
            this.label7.TabIndex = 55;
            this.label7.Text = "지금까지 예약된 의사 순위";
            // 
            // doctorRankGridView
            // 
            this.doctorRankGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorRankGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorRankGridView.BackgroundColor = System.Drawing.Color.White;
            this.doctorRankGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorRankGridView.GridColor = System.Drawing.Color.Black;
            this.doctorRankGridView.Location = new System.Drawing.Point(0, 0);
            this.doctorRankGridView.Name = "doctorRankGridView";
            this.doctorRankGridView.RowTemplate.Height = 27;
            this.doctorRankGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctorRankGridView.Size = new System.Drawing.Size(519, 410);
            this.doctorRankGridView.TabIndex = 54;
            this.doctorRankGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.doctorRankGridView_RowPostPaint);
            // 
            // doctorRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 499);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.doctorRankGridView);
            this.Name = "doctorRank";
            this.Text = "의사 예약 순위";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.doctorRank_FormClosed);
            this.Load += new System.EventHandler(this.doctorRank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorRankGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView doctorRankGridView;
    }
}