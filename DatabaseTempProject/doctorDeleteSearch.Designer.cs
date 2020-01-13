namespace DatabaseTeamProject
{
    partial class doctorDeleteSearch
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
            this.doctorIdDelete = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.doctorDelete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doctorIdDelete
            // 
            this.doctorIdDelete.Font = new System.Drawing.Font("굴림", 14F);
            this.doctorIdDelete.Location = new System.Drawing.Point(336, 97);
            this.doctorIdDelete.Name = "doctorIdDelete";
            this.doctorIdDelete.Size = new System.Drawing.Size(263, 34);
            this.doctorIdDelete.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(98, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 36);
            this.label7.TabIndex = 69;
            this.label7.Text = "삭제할 의사 아이디";
            // 
            // doctorDelete_Button
            // 
            this.doctorDelete_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.doctorDelete_Button.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doctorDelete_Button.ForeColor = System.Drawing.Color.White;
            this.doctorDelete_Button.Location = new System.Drawing.Point(263, 192);
            this.doctorDelete_Button.Name = "doctorDelete_Button";
            this.doctorDelete_Button.Size = new System.Drawing.Size(204, 76);
            this.doctorDelete_Button.TabIndex = 84;
            this.doctorDelete_Button.Text = "삭제하기";
            this.doctorDelete_Button.UseVisualStyleBackColor = false;
            this.doctorDelete_Button.Click += new System.EventHandler(this.doctorDelete_Button_Click);
            // 
            // doctorDeleteSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 298);
            this.Controls.Add(this.doctorDelete_Button);
            this.Controls.Add(this.doctorIdDelete);
            this.Controls.Add(this.label7);
            this.Name = "doctorDeleteSearch";
            this.Text = "해당 의사에 관한 정보 모두 삭제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox doctorIdDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button doctorDelete_Button;
    }
}