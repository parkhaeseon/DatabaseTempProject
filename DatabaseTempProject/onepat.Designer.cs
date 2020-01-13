namespace DatabaseTeamProject
{
    partial class onepat
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
            this.patn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Entersure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patn
            // 
            this.patn.Font = new System.Drawing.Font("굴림", 14F);
            this.patn.Location = new System.Drawing.Point(191, 63);
            this.patn.Name = "patn";
            this.patn.Size = new System.Drawing.Size(215, 34);
            this.patn.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(100, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 36);
            this.label7.TabIndex = 54;
            this.label7.Text = "이름";
            // 
            // Entersure
            // 
            this.Entersure.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Entersure.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Entersure.ForeColor = System.Drawing.Color.White;
            this.Entersure.Location = new System.Drawing.Point(185, 195);
            this.Entersure.Name = "Entersure";
            this.Entersure.Size = new System.Drawing.Size(204, 76);
            this.Entersure.TabIndex = 56;
            this.Entersure.Text = "예약 내역 검색";
            this.Entersure.UseVisualStyleBackColor = false;
            this.Entersure.Click += new System.EventHandler(this.Entersure_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(86, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 36);
            this.label1.TabIndex = 57;
            this.label1.Text = "같은 이름을 가진 환자들 전부 검색 가능";
            // 
            // onepat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entersure);
            this.Controls.Add(this.patn);
            this.Controls.Add(this.label7);
            this.Name = "onepat";
            this.Text = "예약 내역 검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Entersure;
        public System.Windows.Forms.TextBox patn;
        private System.Windows.Forms.Label label1;
    }
}