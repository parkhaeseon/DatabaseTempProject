namespace DatabaseTeamProject
{
    partial class empRank
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
            this.empRankGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empRankGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(102, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 31);
            this.label7.TabIndex = 57;
            this.label7.Text = "지금까지 예약을 담당한 직원 순위";
            // 
            // empRankGridView
            // 
            this.empRankGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empRankGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empRankGridView.BackgroundColor = System.Drawing.Color.White;
            this.empRankGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empRankGridView.GridColor = System.Drawing.Color.Black;
            this.empRankGridView.Location = new System.Drawing.Point(0, 1);
            this.empRankGridView.Name = "empRankGridView";
            this.empRankGridView.RowTemplate.Height = 27;
            this.empRankGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empRankGridView.Size = new System.Drawing.Size(536, 410);
            this.empRankGridView.TabIndex = 56;
            this.empRankGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.empRankGridView_RowPostPaint);
            // 
            // empRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 499);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.empRankGridView);
            this.Name = "empRank";
            this.Text = "예약 담당 직원 순위";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.empRank_FormClosed);
            this.Load += new System.EventHandler(this.empRank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empRankGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView empRankGridView;
    }
}