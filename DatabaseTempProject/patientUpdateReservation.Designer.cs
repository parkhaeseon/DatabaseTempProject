namespace DatabaseTeamProject
{
    partial class patientUpdateReservation
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
            this.pId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Entersure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pId
            // 
            this.pId.Font = new System.Drawing.Font("굴림", 14F);
            this.pId.Location = new System.Drawing.Point(380, 78);
            this.pId.Name = "pId";
            this.pId.Size = new System.Drawing.Size(263, 34);
            this.pId.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(37, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(337, 36);
            this.label7.TabIndex = 68;
            this.label7.Text = "예약 시간을 수정할 환자 아이디";
            // 
            // Entersure
            // 
            this.Entersure.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Entersure.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Entersure.ForeColor = System.Drawing.Color.White;
            this.Entersure.Location = new System.Drawing.Point(220, 177);
            this.Entersure.Name = "Entersure";
            this.Entersure.Size = new System.Drawing.Size(314, 76);
            this.Entersure.TabIndex = 71;
            this.Entersure.Text = "해당 환자 예약 내역 보기";
            this.Entersure.UseVisualStyleBackColor = false;
            this.Entersure.Click += new System.EventHandler(this.Entersure_Click);
            // 
            // patientUpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 290);
            this.Controls.Add(this.Entersure);
            this.Controls.Add(this.pId);
            this.Controls.Add(this.label7);
            this.Name = "patientUpdateReservation";
            this.Text = "예약 시간을 수정할 환자 검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox pId;
        private System.Windows.Forms.Button Entersure;
    }
}