using System.Windows.Forms;

namespace DatabaseTeamProject
{
    partial class employeeEnter
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
            this.id = new System.Windows.Forms.TextBox();
            this.dup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.epw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.retry_pw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mg = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.residentnumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.home2 = new System.Windows.Forms.TextBox();
            this.home1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.alldelete = new System.Windows.Forms.Button();
            this.Entersure = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.saddr = new System.Windows.Forms.Button();
            this.selfinput = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Address2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("굴림", 14F);
            this.id.Location = new System.Drawing.Point(231, 47);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(220, 34);
            this.id.TabIndex = 1;
            // 
            // dup
            // 
            this.dup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dup.Font = new System.Drawing.Font("맑은 고딕", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dup.ForeColor = System.Drawing.Color.White;
            this.dup.Location = new System.Drawing.Point(469, 35);
            this.dup.Name = "dup";
            this.dup.Size = new System.Drawing.Size(183, 55);
            this.dup.TabIndex = 2;
            this.dup.Text = "중복 확인";
            this.dup.UseVisualStyleBackColor = false;
            this.dup.Click += new System.EventHandler(this.dup_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호";
            // 
            // epw
            // 
            this.epw.Font = new System.Drawing.Font("굴림", 14F);
            this.epw.Location = new System.Drawing.Point(231, 109);
            this.epw.Name = "epw";
            this.epw.Size = new System.Drawing.Size(220, 34);
            this.epw.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "비밀번호 재확인";
            // 
            // retry_pw
            // 
            this.retry_pw.Font = new System.Drawing.Font("굴림", 14F);
            this.retry_pw.Location = new System.Drawing.Point(231, 166);
            this.retry_pw.Name = "retry_pw";
            this.retry_pw.Size = new System.Drawing.Size(220, 34);
            this.retry_pw.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "이름";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("굴림", 14F);
            this.name.Location = new System.Drawing.Point(231, 225);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(220, 34);
            this.name.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(13, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "성별";
            // 
            // mg
            // 
            this.mg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mg.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mg.FormattingEnabled = true;
            this.mg.Location = new System.Drawing.Point(231, 285);
            this.mg.Name = "mg";
            this.mg.Size = new System.Drawing.Size(65, 39);
            this.mg.TabIndex = 13;
            this.mg.SelectedIndexChanged += new System.EventHandler(this.mg_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(12, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "주민등록번호";
            // 
            // residentnumber
            // 
            this.residentnumber.Font = new System.Drawing.Font("굴림", 14F);
            this.residentnumber.Location = new System.Drawing.Point(231, 349);
            this.residentnumber.Name = "residentnumber";
            this.residentnumber.Size = new System.Drawing.Size(263, 34);
            this.residentnumber.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(13, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 36);
            this.label9.TabIndex = 18;
            this.label9.Text = "집 주소";
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("굴림", 14F);
            this.Address.Location = new System.Drawing.Point(231, 411);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(348, 34);
            this.Address.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(14, 602);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 36);
            this.label10.TabIndex = 20;
            this.label10.Text = "집 전화번호";
            // 
            // home2
            // 
            this.home2.Font = new System.Drawing.Font("굴림", 14F);
            this.home2.Location = new System.Drawing.Point(325, 602);
            this.home2.Name = "home2";
            this.home2.Size = new System.Drawing.Size(152, 34);
            this.home2.TabIndex = 21;
            // 
            // home1
            // 
            this.home1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.home1.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.home1.FormattingEnabled = true;
            this.home1.Location = new System.Drawing.Point(231, 601);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(79, 39);
            this.home1.TabIndex = 22;
            this.home1.SelectedIndexChanged += new System.EventHandler(this.home1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(492, 601);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 36);
            this.label11.TabIndex = 23;
            this.label11.Text = "\'-\' 없이 입력";
            // 
            // alldelete
            // 
            this.alldelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.alldelete.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.alldelete.ForeColor = System.Drawing.Color.White;
            this.alldelete.Location = new System.Drawing.Point(811, 693);
            this.alldelete.Name = "alldelete";
            this.alldelete.Size = new System.Drawing.Size(149, 59);
            this.alldelete.TabIndex = 30;
            this.alldelete.Text = "지우기";
            this.alldelete.UseVisualStyleBackColor = false;
            this.alldelete.Click += new System.EventHandler(this.alldelete_Click);
            // 
            // Entersure
            // 
            this.Entersure.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Entersure.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Entersure.ForeColor = System.Drawing.Color.White;
            this.Entersure.Location = new System.Drawing.Point(393, 676);
            this.Entersure.Name = "Entersure";
            this.Entersure.Size = new System.Drawing.Size(204, 76);
            this.Entersure.TabIndex = 31;
            this.Entersure.Text = "등록하기";
            this.Entersure.UseVisualStyleBackColor = false;
            this.Entersure.Click += new System.EventHandler(this.Entersure_Click);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("굴림", 14F);
            this.phone.Location = new System.Drawing.Point(231, 542);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(246, 34);
            this.phone.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(14, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 36);
            this.label5.TabIndex = 32;
            this.label5.Text = "핸드폰 번호";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(492, 542);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 36);
            this.label12.TabIndex = 34;
            this.label12.Text = "\'-\' 없이 11자리 숫자";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(510, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 36);
            this.label13.TabIndex = 35;
            this.label13.Text = "\'-\' 없이 13자리 숫자";
            // 
            // saddr
            // 
            this.saddr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saddr.Font = new System.Drawing.Font("맑은 고딕", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saddr.ForeColor = System.Drawing.Color.White;
            this.saddr.Location = new System.Drawing.Point(599, 399);
            this.saddr.Name = "saddr";
            this.saddr.Size = new System.Drawing.Size(212, 59);
            this.saddr.TabIndex = 36;
            this.saddr.Text = "도로명 주소 검색";
            this.saddr.UseVisualStyleBackColor = false;
            this.saddr.Click += new System.EventHandler(this.button1_Click);
            // 
            // selfinput
            // 
            this.selfinput.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.selfinput.Font = new System.Drawing.Font("맑은 고딕", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selfinput.ForeColor = System.Drawing.Color.White;
            this.selfinput.Location = new System.Drawing.Point(827, 399);
            this.selfinput.Name = "selfinput";
            this.selfinput.Size = new System.Drawing.Size(133, 59);
            this.selfinput.TabIndex = 37;
            this.selfinput.Text = "직접 입력";
            this.selfinput.UseVisualStyleBackColor = false;
            this.selfinput.Click += new System.EventHandler(this.selfinput_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(14, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 36);
            this.label8.TabIndex = 38;
            this.label8.Text = "나머지 주소";
            // 
            // Address2
            // 
            this.Address2.Font = new System.Drawing.Font("굴림", 14F);
            this.Address2.Location = new System.Drawing.Point(231, 474);
            this.Address2.Name = "Address2";
            this.Address2.Size = new System.Drawing.Size(348, 34);
            this.Address2.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(464, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 36);
            this.label14.TabIndex = 40;
            this.label14.Text = "8자리 이상";
            // 
            // employeeEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 774);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Address2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selfinput);
            this.Controls.Add(this.saddr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Entersure);
            this.Controls.Add(this.alldelete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.home2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.residentnumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.retry_pw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.epw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dup);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Name = "employeeEnter";
            this.Text = "직원 등록";
            this.Load += new System.EventHandler(this.employeeEnter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button dup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox epw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox retry_pw;
        private new System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox mg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox residentnumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox home2;
        private System.Windows.Forms.ComboBox home1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button alldelete;
        private Button Entersure;
        private TextBox phone;
        private Label label5;
        private Label label12;
        private Label label13;
        private Button saddr;
        private Button selfinput;
        public TextBox Address;
        private Label label8;
        public TextBox Address2;
        private Label label14;

        public Button Enter1 { get => Enter; set => Enter = value; }
    }
}