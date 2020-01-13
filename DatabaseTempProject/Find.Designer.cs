namespace DatabaseTeamProject
{
    partial class FindIDPW
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frrn = new System.Windows.Forms.TextBox();
            this.fid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.findclick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.label2.Location = new System.Drawing.Point(33, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "주민등록번호";
            // 
            // frrn
            // 
            this.frrn.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.frrn.Location = new System.Drawing.Point(197, 125);
            this.frrn.Multiline = true;
            this.frrn.Name = "frrn";
            this.frrn.Size = new System.Drawing.Size(166, 36);
            this.frrn.TabIndex = 4;
            // 
            // fid
            // 
            this.fid.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fid.Location = new System.Drawing.Point(197, 59);
            this.fid.Multiline = true;
            this.fid.Name = "fid";
            this.fid.Size = new System.Drawing.Size(166, 36);
            this.fid.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(383, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 36);
            this.label13.TabIndex = 36;
            this.label13.Text = "\'-\' 없이 13자리";
            // 
            // findclick
            // 
            this.findclick.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.findclick.Font = new System.Drawing.Font("돋움", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findclick.ForeColor = System.Drawing.Color.White;
            this.findclick.Location = new System.Drawing.Point(197, 186);
            this.findclick.Name = "findclick";
            this.findclick.Size = new System.Drawing.Size(166, 59);
            this.findclick.TabIndex = 37;
            this.findclick.Text = "찾기";
            this.findclick.UseVisualStyleBackColor = false;
            this.findclick.Click += new System.EventHandler(this.findclick_Click);
            // 
            // FindIDPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 274);
            this.Controls.Add(this.findclick);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.fid);
            this.Controls.Add(this.frrn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindIDPW";
            this.Text = "아이디 / 비밀번호 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox frrn;
        public System.Windows.Forms.TextBox fid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button findclick;
    }
}