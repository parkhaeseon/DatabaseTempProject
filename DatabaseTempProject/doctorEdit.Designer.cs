namespace DatabaseTeamProject
{
    partial class doctorEdit
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
            this.docedit = new System.Windows.Forms.Button();
            this.docId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // docedit
            // 
            this.docedit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.docedit.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.docedit.ForeColor = System.Drawing.Color.White;
            this.docedit.Location = new System.Drawing.Point(242, 126);
            this.docedit.Name = "docedit";
            this.docedit.Size = new System.Drawing.Size(281, 52);
            this.docedit.TabIndex = 87;
            this.docedit.Text = "해당 의사 정보 수정하기";
            this.docedit.UseVisualStyleBackColor = false;
            this.docedit.Click += new System.EventHandler(this.docedit_Click);
            // 
            // docId
            // 
            this.docId.Font = new System.Drawing.Font("굴림", 14F);
            this.docId.Location = new System.Drawing.Point(340, 53);
            this.docId.Name = "docId";
            this.docId.Size = new System.Drawing.Size(340, 34);
            this.docId.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(54, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 36);
            this.label9.TabIndex = 85;
            this.label9.Text = "정보를 수정할 의사 아이디";
            // 
            // doctorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 219);
            this.Controls.Add(this.docedit);
            this.Controls.Add(this.docId);
            this.Controls.Add(this.label9);
            this.Name = "doctorEdit";
            this.Text = "정보를 수정할 의사 검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button docedit;
        public System.Windows.Forms.TextBox docId;
        private System.Windows.Forms.Label label9;
    }
}