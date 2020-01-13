namespace DatabaseTeamProject
{
    partial class patientDelete
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
            this.patientDelete_Button = new System.Windows.Forms.Button();
            this.patientIdDelete = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patientDelete_Button
            // 
            this.patientDelete_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.patientDelete_Button.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.patientDelete_Button.ForeColor = System.Drawing.Color.White;
            this.patientDelete_Button.Location = new System.Drawing.Point(236, 187);
            this.patientDelete_Button.Name = "patientDelete_Button";
            this.patientDelete_Button.Size = new System.Drawing.Size(204, 76);
            this.patientDelete_Button.TabIndex = 90;
            this.patientDelete_Button.Text = "삭제하기";
            this.patientDelete_Button.UseVisualStyleBackColor = false;
            this.patientDelete_Button.Click += new System.EventHandler(this.patientDelete_Button_Click);
            // 
            // patientIdDelete
            // 
            this.patientIdDelete.Font = new System.Drawing.Font("굴림", 14F);
            this.patientIdDelete.Location = new System.Drawing.Point(321, 81);
            this.patientIdDelete.Name = "patientIdDelete";
            this.patientIdDelete.Size = new System.Drawing.Size(263, 34);
            this.patientIdDelete.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(57, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 36);
            this.label7.TabIndex = 87;
            this.label7.Text = "삭제할 환자 아이디";
            // 
            // patientDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 298);
            this.Controls.Add(this.patientDelete_Button);
            this.Controls.Add(this.patientIdDelete);
            this.Controls.Add(this.label7);
            this.Name = "patientDelete";
            this.Text = "해당 환자에 관한 정보 모두 삭제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button patientDelete_Button;
        private System.Windows.Forms.TextBox patientIdDelete;
        private System.Windows.Forms.Label label7;
    }
}