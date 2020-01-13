namespace DatabaseTeamProject
{
    partial class patRank
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
            this.patientRankGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.patientRankGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(156, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 31);
            this.label7.TabIndex = 57;
            this.label7.Text = "지금까지 환자들이 병원에 예약한 횟수";
            // 
            // patientRankGridView
            // 
            this.patientRankGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientRankGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientRankGridView.BackgroundColor = System.Drawing.Color.White;
            this.patientRankGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientRankGridView.GridColor = System.Drawing.Color.Black;
            this.patientRankGridView.Location = new System.Drawing.Point(1, 0);
            this.patientRankGridView.Name = "patientRankGridView";
            this.patientRankGridView.RowTemplate.Height = 27;
            this.patientRankGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientRankGridView.Size = new System.Drawing.Size(673, 410);
            this.patientRankGridView.TabIndex = 56;
            this.patientRankGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.patientRankGridView_RowPostPaint);
            // 
            // patRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 499);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.patientRankGridView);
            this.Name = "patRank";
            this.Text = "환자들의 예약 횟수";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.patRank_FormClosed);
            this.Load += new System.EventHandler(this.patRank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientRankGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView patientRankGridView;
    }
}