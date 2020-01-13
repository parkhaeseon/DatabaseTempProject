namespace DatabaseTeamProject
{
    partial class depRank
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
            this.deptRankGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deptRankGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deptRankGridView
            // 
            this.deptRankGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deptRankGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deptRankGridView.BackgroundColor = System.Drawing.Color.White;
            this.deptRankGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptRankGridView.GridColor = System.Drawing.Color.Black;
            this.deptRankGridView.Location = new System.Drawing.Point(0, 0);
            this.deptRankGridView.Name = "deptRankGridView";
            this.deptRankGridView.RowTemplate.Height = 27;
            this.deptRankGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deptRankGridView.Size = new System.Drawing.Size(487, 407);
            this.deptRankGridView.TabIndex = 0;
            this.deptRankGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.deptRankGridView_RowPostPaint);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(102, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 31);
            this.label7.TabIndex = 53;
            this.label7.Text = "지금까지 예약된 진료과 순위";
            // 
            // depRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 499);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deptRankGridView);
            this.Name = "depRank";
            this.Text = "진료과 예약 순위";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.depRank_FormClosed);
            this.Load += new System.EventHandler(this.depRank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deptRankGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deptRankGridView;
        private System.Windows.Forms.Label label7;
    }
}