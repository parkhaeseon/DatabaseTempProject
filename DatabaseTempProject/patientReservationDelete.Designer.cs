namespace DatabaseTeamProject
{
    partial class patientReservationDelete
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
            this.patIdResDelete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.patressearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patIdResDelete
            // 
            this.patIdResDelete.Font = new System.Drawing.Font("굴림", 14F);
            this.patIdResDelete.Location = new System.Drawing.Point(399, 50);
            this.patIdResDelete.Name = "patIdResDelete";
            this.patIdResDelete.Size = new System.Drawing.Size(340, 34);
            this.patIdResDelete.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(113, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(295, 36);
            this.label9.TabIndex = 79;
            this.label9.Text = "예약을 삭제할 환자 아이디";
            // 
            // patressearch
            // 
            this.patressearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.patressearch.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.patressearch.ForeColor = System.Drawing.Color.White;
            this.patressearch.Location = new System.Drawing.Point(305, 123);
            this.patressearch.Name = "patressearch";
            this.patressearch.Size = new System.Drawing.Size(233, 52);
            this.patressearch.TabIndex = 84;
            this.patressearch.Text = "환자 예약 내역 조회";
            this.patressearch.UseVisualStyleBackColor = false;
            this.patressearch.Click += new System.EventHandler(this.patressearch_Click);
            // 
            // patientReservationDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 219);
            this.Controls.Add(this.patressearch);
            this.Controls.Add(this.patIdResDelete);
            this.Controls.Add(this.label9);
            this.Name = "patientReservationDelete";
            this.Text = "예약 내역을 삭제할 환자 검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox patIdResDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button patressearch;
    }
}