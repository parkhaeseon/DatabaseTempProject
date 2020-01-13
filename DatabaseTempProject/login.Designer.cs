namespace DatabaseTeamProject
{
    partial class login
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
            this.loginid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginpw = new System.Windows.Forms.TextBox();
            this.gomanage = new System.Windows.Forms.Button();
            this.EnterEmployee = new System.Windows.Forms.Button();
            this.startImage1 = new System.Windows.Forms.PictureBox();
            this.findidpw = new System.Windows.Forms.Button();
            this.startImage2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(53, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // loginid
            // 
            this.loginid.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginid.Location = new System.Drawing.Point(133, 250);
            this.loginid.Name = "loginid";
            this.loginid.Size = new System.Drawing.Size(166, 34);
            this.loginid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.label2.Location = new System.Drawing.Point(32, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "비밀번호";
            // 
            // loginpw
            // 
            this.loginpw.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginpw.Location = new System.Drawing.Point(133, 305);
            this.loginpw.Name = "loginpw";
            this.loginpw.Size = new System.Drawing.Size(166, 34);
            this.loginpw.TabIndex = 3;
            // 
            // gomanage
            // 
            this.gomanage.BackColor = System.Drawing.Color.LightBlue;
            this.gomanage.FlatAppearance.BorderSize = 0;
            this.gomanage.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gomanage.ForeColor = System.Drawing.Color.Black;
            this.gomanage.Location = new System.Drawing.Point(36, 375);
            this.gomanage.Name = "gomanage";
            this.gomanage.Size = new System.Drawing.Size(115, 50);
            this.gomanage.TabIndex = 4;
            this.gomanage.Text = "로그인";
            this.gomanage.UseVisualStyleBackColor = false;
            this.gomanage.Click += new System.EventHandler(this.gomanage_Click);
            this.gomanage.MouseLeave += new System.EventHandler(this.gomanage_MouseLeave);
            this.gomanage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gomanage_MouseMove);
            // 
            // EnterEmployee
            // 
            this.EnterEmployee.BackColor = System.Drawing.Color.LightPink;
            this.EnterEmployee.FlatAppearance.BorderSize = 0;
            this.EnterEmployee.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnterEmployee.Location = new System.Drawing.Point(181, 375);
            this.EnterEmployee.Name = "EnterEmployee";
            this.EnterEmployee.Size = new System.Drawing.Size(149, 50);
            this.EnterEmployee.TabIndex = 5;
            this.EnterEmployee.Text = "행정직원 등록";
            this.EnterEmployee.UseVisualStyleBackColor = false;
            this.EnterEmployee.Click += new System.EventHandler(this.EnterEmployee_Click);
            this.EnterEmployee.MouseLeave += new System.EventHandler(this.EnterEmployee_MouseLeave);
            this.EnterEmployee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EnterEmployee_MouseMove);
            // 
            // startImage1
            // 
            this.startImage1.Location = new System.Drawing.Point(23, 44);
            this.startImage1.Name = "startImage1";
            this.startImage1.Size = new System.Drawing.Size(148, 156);
            this.startImage1.TabIndex = 6;
            this.startImage1.TabStop = false;
            // 
            // findidpw
            // 
            this.findidpw.BackColor = System.Drawing.Color.LightGray;
            this.findidpw.FlatAppearance.BorderSize = 0;
            this.findidpw.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findidpw.Location = new System.Drawing.Point(100, 461);
            this.findidpw.Name = "findidpw";
            this.findidpw.Size = new System.Drawing.Size(168, 42);
            this.findidpw.TabIndex = 7;
            this.findidpw.Text = "ID / PW 찾기";
            this.findidpw.UseVisualStyleBackColor = false;
            this.findidpw.Click += new System.EventHandler(this.findidpw_Click);
            this.findidpw.MouseLeave += new System.EventHandler(this.findidpw_MouseLeave);
            this.findidpw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.findidpw_MouseMove);
            // 
            // startImage2
            // 
            this.startImage2.Location = new System.Drawing.Point(192, 44);
            this.startImage2.Name = "startImage2";
            this.startImage2.Size = new System.Drawing.Size(144, 156);
            this.startImage2.TabIndex = 8;
            this.startImage2.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 532);
            this.Controls.Add(this.startImage2);
            this.Controls.Add(this.findidpw);
            this.Controls.Add(this.startImage1);
            this.Controls.Add(this.EnterEmployee);
            this.Controls.Add(this.gomanage);
            this.Controls.Add(this.loginpw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginid);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "행정직원 간단 예약 시스템";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gomanage;
        private System.Windows.Forms.Button EnterEmployee;
        private System.Windows.Forms.PictureBox startImage1;
        private System.Windows.Forms.Button findidpw;
        public System.Windows.Forms.TextBox loginid;
        public System.Windows.Forms.TextBox loginpw;
        private System.Windows.Forms.PictureBox startImage2;
    }
}