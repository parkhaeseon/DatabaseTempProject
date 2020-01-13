namespace DatabaseTeamProject
{
    partial class employeeIDedit
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
            this.dup = new System.Windows.Forms.Button();
            this.newid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Editsure = new System.Windows.Forms.Button();
            this.alldelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dup
            // 
            this.dup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dup.Font = new System.Drawing.Font("맑은 고딕", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dup.ForeColor = System.Drawing.Color.White;
            this.dup.Location = new System.Drawing.Point(436, 48);
            this.dup.Name = "dup";
            this.dup.Size = new System.Drawing.Size(183, 55);
            this.dup.TabIndex = 5;
            this.dup.Text = "중복 확인";
            this.dup.UseVisualStyleBackColor = false;
            this.dup.Click += new System.EventHandler(this.dup_Click);
            // 
            // newid
            // 
            this.newid.Font = new System.Drawing.Font("굴림", 14F);
            this.newid.Location = new System.Drawing.Point(153, 60);
            this.newid.Name = "newid";
            this.newid.Size = new System.Drawing.Size(231, 34);
            this.newid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "아이디";
            // 
            // Editsure
            // 
            this.Editsure.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Editsure.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Editsure.ForeColor = System.Drawing.Color.White;
            this.Editsure.Location = new System.Drawing.Point(230, 138);
            this.Editsure.Name = "Editsure";
            this.Editsure.Size = new System.Drawing.Size(204, 76);
            this.Editsure.TabIndex = 32;
            this.Editsure.Text = "수정하기";
            this.Editsure.UseVisualStyleBackColor = false;
            this.Editsure.Click += new System.EventHandler(this.Editsure_Click);
            // 
            // alldelete
            // 
            this.alldelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.alldelete.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.alldelete.ForeColor = System.Drawing.Color.White;
            this.alldelete.Location = new System.Drawing.Point(506, 150);
            this.alldelete.Name = "alldelete";
            this.alldelete.Size = new System.Drawing.Size(149, 59);
            this.alldelete.TabIndex = 33;
            this.alldelete.Text = "지우기";
            this.alldelete.UseVisualStyleBackColor = false;
            this.alldelete.Click += new System.EventHandler(this.alldelete_Click);
            // 
            // employeeIDedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 238);
            this.Controls.Add(this.alldelete);
            this.Controls.Add(this.Editsure);
            this.Controls.Add(this.dup);
            this.Controls.Add(this.newid);
            this.Controls.Add(this.label1);
            this.Name = "employeeIDedit";
            this.Text = "행정 직원 아이디 수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dup;
        private System.Windows.Forms.TextBox newid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Editsure;
        private System.Windows.Forms.Button alldelete;
    }
}