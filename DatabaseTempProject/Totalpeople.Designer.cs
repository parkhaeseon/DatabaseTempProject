namespace DatabaseTeamProject
{
    partial class Totalpeople
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
            this.totalemp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totaldoctor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalpatient = new System.Windows.Forms.TextBox();
            this.totalp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // totalemp
            // 
            this.totalemp.Font = new System.Drawing.Font("굴림", 14F);
            this.totalemp.Location = new System.Drawing.Point(226, 67);
            this.totalemp.Name = "totalemp";
            this.totalemp.ReadOnly = true;
            this.totalemp.Size = new System.Drawing.Size(56, 34);
            this.totalemp.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(35, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 36);
            this.label7.TabIndex = 57;
            this.label7.Text = "총 행정직원 수";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(35, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 36);
            this.label6.TabIndex = 56;
            this.label6.Text = "총 환자 수";
            // 
            // totaldoctor
            // 
            this.totaldoctor.Font = new System.Drawing.Font("굴림", 14F);
            this.totaldoctor.Location = new System.Drawing.Point(226, 135);
            this.totaldoctor.Name = "totaldoctor";
            this.totaldoctor.ReadOnly = true;
            this.totaldoctor.Size = new System.Drawing.Size(56, 34);
            this.totaldoctor.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(35, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 36);
            this.label4.TabIndex = 54;
            this.label4.Text = "총 의사 수";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(35, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 36);
            this.label1.TabIndex = 59;
            this.label1.Text = "총 인원";
            // 
            // totalpatient
            // 
            this.totalpatient.Font = new System.Drawing.Font("굴림", 14F);
            this.totalpatient.Location = new System.Drawing.Point(226, 198);
            this.totalpatient.Name = "totalpatient";
            this.totalpatient.ReadOnly = true;
            this.totalpatient.Size = new System.Drawing.Size(56, 34);
            this.totalpatient.TabIndex = 60;
            // 
            // totalp
            // 
            this.totalp.Font = new System.Drawing.Font("굴림", 14F);
            this.totalp.Location = new System.Drawing.Point(226, 263);
            this.totalp.Name = "totalp";
            this.totalp.ReadOnly = true;
            this.totalp.Size = new System.Drawing.Size(56, 34);
            this.totalp.TabIndex = 61;
            // 
            // Totalpeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 364);
            this.Controls.Add(this.totalp);
            this.Controls.Add(this.totalpatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalemp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totaldoctor);
            this.Controls.Add(this.label4);
            this.Name = "Totalpeople";
            this.Text = "총 인원 현황";
            this.Load += new System.EventHandler(this.Totalpeople_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalemp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totaldoctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalpatient;
        private System.Windows.Forms.TextBox totalp;
    }
}