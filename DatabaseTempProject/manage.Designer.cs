namespace DatabaseTeamProject
{
    partial class manage
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
            this.logout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.정보수정하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.아이디만수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.나머지정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.내가예약한환자들목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.의사관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seedoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.새의사등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.의사정보삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seepatient = new System.Windows.Forms.ToolStripMenuItem();
            this.새환자등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.환자정보삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환자예약관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환자진료예약ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예약현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예약수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예약삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.특정환자예약내역검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.각종조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.진료과예약순위ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.의사예약순위ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.행정직원예약순위ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Post = new System.Windows.Forms.TextBox();
            this.postClear = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Button();
            this.empPhoto = new System.Windows.Forms.PictureBox();
            this.empName = new System.Windows.Forms.Label();
            this.patientRank = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.logout.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(416, 68);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(151, 61);
            this.logout.TabIndex = 1;
            this.logout.Text = "로그아웃";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보수정하기ToolStripMenuItem,
            this.의사관리ToolStripMenuItem,
            this.환자관리ToolStripMenuItem,
            this.환자예약관리ToolStripMenuItem,
            this.각종조회ToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 40);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 정보수정하기ToolStripMenuItem
            // 
            this.정보수정하기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.아이디만수정ToolStripMenuItem,
            this.나머지정보수정ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.내가예약한환자들목록ToolStripMenuItem});
            this.정보수정하기ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.정보수정하기ToolStripMenuItem.Name = "정보수정하기ToolStripMenuItem";
            this.정보수정하기ToolStripMenuItem.ShowShortcutKeys = false;
            this.정보수정하기ToolStripMenuItem.Size = new System.Drawing.Size(124, 36);
            this.정보수정하기ToolStripMenuItem.Text = "마이페이지";
            // 
            // 아이디만수정ToolStripMenuItem
            // 
            this.아이디만수정ToolStripMenuItem.Name = "아이디만수정ToolStripMenuItem";
            this.아이디만수정ToolStripMenuItem.Size = new System.Drawing.Size(311, 32);
            this.아이디만수정ToolStripMenuItem.Text = "아이디만 수정";
            this.아이디만수정ToolStripMenuItem.Click += new System.EventHandler(this.아이디만수정ToolStripMenuItem_Click);
            // 
            // 나머지정보수정ToolStripMenuItem
            // 
            this.나머지정보수정ToolStripMenuItem.Name = "나머지정보수정ToolStripMenuItem";
            this.나머지정보수정ToolStripMenuItem.Size = new System.Drawing.Size(311, 32);
            this.나머지정보수정ToolStripMenuItem.Text = "나머지 정보 수정";
            this.나머지정보수정ToolStripMenuItem.Click += new System.EventHandler(this.나머지정보수정ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(311, 32);
            this.toolStripMenuItem1.Text = "내 정보 보기";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 내가예약한환자들목록ToolStripMenuItem
            // 
            this.내가예약한환자들목록ToolStripMenuItem.Name = "내가예약한환자들목록ToolStripMenuItem";
            this.내가예약한환자들목록ToolStripMenuItem.Size = new System.Drawing.Size(311, 32);
            this.내가예약한환자들목록ToolStripMenuItem.Text = "내가 예약한 환자들 목록";
            this.내가예약한환자들목록ToolStripMenuItem.Click += new System.EventHandler(this.내가예약한환자들목록ToolStripMenuItem_Click);
            // 
            // 의사관리ToolStripMenuItem
            // 
            this.의사관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seedoctors,
            this.새의사등록ToolStripMenuItem,
            this.doctorEdit,
            this.의사정보삭제ToolStripMenuItem});
            this.의사관리ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.의사관리ToolStripMenuItem.Name = "의사관리ToolStripMenuItem";
            this.의사관리ToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.의사관리ToolStripMenuItem.Text = "의사 관리";
            // 
            // seedoctors
            // 
            this.seedoctors.Name = "seedoctors";
            this.seedoctors.Size = new System.Drawing.Size(224, 32);
            this.seedoctors.Text = "의사 목록";
            this.seedoctors.Click += new System.EventHandler(this.seedoctors_Click);
            // 
            // 새의사등록ToolStripMenuItem
            // 
            this.새의사등록ToolStripMenuItem.Name = "새의사등록ToolStripMenuItem";
            this.새의사등록ToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.새의사등록ToolStripMenuItem.Text = "새 의사 등록";
            this.새의사등록ToolStripMenuItem.Click += new System.EventHandler(this.새의사등록ToolStripMenuItem_Click);
            // 
            // doctorEdit
            // 
            this.doctorEdit.Name = "doctorEdit";
            this.doctorEdit.Size = new System.Drawing.Size(224, 32);
            this.doctorEdit.Text = "의사 정보 수정";
            this.doctorEdit.Click += new System.EventHandler(this.doctorEdit_Click);
            // 
            // 의사정보삭제ToolStripMenuItem
            // 
            this.의사정보삭제ToolStripMenuItem.Name = "의사정보삭제ToolStripMenuItem";
            this.의사정보삭제ToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.의사정보삭제ToolStripMenuItem.Text = "의사 정보 삭제";
            this.의사정보삭제ToolStripMenuItem.Click += new System.EventHandler(this.의사정보삭제ToolStripMenuItem_Click);
            // 
            // 환자관리ToolStripMenuItem
            // 
            this.환자관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seepatient,
            this.새환자등록ToolStripMenuItem,
            this.patientEdit,
            this.환자정보삭제ToolStripMenuItem});
            this.환자관리ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.환자관리ToolStripMenuItem.Name = "환자관리ToolStripMenuItem";
            this.환자관리ToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.환자관리ToolStripMenuItem.Text = "환자 관리";
            // 
            // seepatient
            // 
            this.seepatient.Name = "seepatient";
            this.seepatient.Size = new System.Drawing.Size(224, 32);
            this.seepatient.Text = "환자 목록";
            this.seepatient.Click += new System.EventHandler(this.seepatient_Click);
            // 
            // 새환자등록ToolStripMenuItem
            // 
            this.새환자등록ToolStripMenuItem.Name = "새환자등록ToolStripMenuItem";
            this.새환자등록ToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.새환자등록ToolStripMenuItem.Text = "새 환자 등록";
            this.새환자등록ToolStripMenuItem.Click += new System.EventHandler(this.새환자등록ToolStripMenuItem_Click);
            // 
            // patientEdit
            // 
            this.patientEdit.Name = "patientEdit";
            this.patientEdit.Size = new System.Drawing.Size(224, 32);
            this.patientEdit.Text = "환자 정보 수정";
            this.patientEdit.Click += new System.EventHandler(this.patientEdit_Click);
            // 
            // 환자정보삭제ToolStripMenuItem
            // 
            this.환자정보삭제ToolStripMenuItem.Name = "환자정보삭제ToolStripMenuItem";
            this.환자정보삭제ToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.환자정보삭제ToolStripMenuItem.Text = "환자 정보 삭제";
            this.환자정보삭제ToolStripMenuItem.Click += new System.EventHandler(this.환자정보삭제ToolStripMenuItem_Click);
            // 
            // 환자예약관리ToolStripMenuItem
            // 
            this.환자예약관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.환자진료예약ToolStripMenuItem,
            this.예약현황ToolStripMenuItem,
            this.예약수정ToolStripMenuItem,
            this.예약삭제ToolStripMenuItem,
            this.특정환자예약내역검색ToolStripMenuItem});
            this.환자예약관리ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.환자예약관리ToolStripMenuItem.Name = "환자예약관리ToolStripMenuItem";
            this.환자예약관리ToolStripMenuItem.Size = new System.Drawing.Size(158, 36);
            this.환자예약관리ToolStripMenuItem.Text = "환자 예약 관리";
            // 
            // 환자진료예약ToolStripMenuItem
            // 
            this.환자진료예약ToolStripMenuItem.Name = "환자진료예약ToolStripMenuItem";
            this.환자진료예약ToolStripMenuItem.Size = new System.Drawing.Size(318, 32);
            this.환자진료예약ToolStripMenuItem.Text = "환자 진료 예약";
            this.환자진료예약ToolStripMenuItem.Click += new System.EventHandler(this.환자진료예약ToolStripMenuItem_Click);
            // 
            // 예약현황ToolStripMenuItem
            // 
            this.예약현황ToolStripMenuItem.Name = "예약현황ToolStripMenuItem";
            this.예약현황ToolStripMenuItem.Size = new System.Drawing.Size(318, 32);
            this.예약현황ToolStripMenuItem.Text = "예약 현황";
            this.예약현황ToolStripMenuItem.Click += new System.EventHandler(this.예약현황ToolStripMenuItem_Click);
            // 
            // 예약수정ToolStripMenuItem
            // 
            this.예약수정ToolStripMenuItem.Name = "예약수정ToolStripMenuItem";
            this.예약수정ToolStripMenuItem.Size = new System.Drawing.Size(318, 32);
            this.예약수정ToolStripMenuItem.Text = "예약 시간 수정";
            this.예약수정ToolStripMenuItem.Click += new System.EventHandler(this.예약수정ToolStripMenuItem_Click);
            // 
            // 예약삭제ToolStripMenuItem
            // 
            this.예약삭제ToolStripMenuItem.Name = "예약삭제ToolStripMenuItem";
            this.예약삭제ToolStripMenuItem.Size = new System.Drawing.Size(318, 32);
            this.예약삭제ToolStripMenuItem.Text = "예약 삭제";
            this.예약삭제ToolStripMenuItem.Click += new System.EventHandler(this.예약삭제ToolStripMenuItem_Click);
            // 
            // 특정환자예약내역검색ToolStripMenuItem
            // 
            this.특정환자예약내역검색ToolStripMenuItem.Name = "특정환자예약내역검색ToolStripMenuItem";
            this.특정환자예약내역검색ToolStripMenuItem.Size = new System.Drawing.Size(318, 32);
            this.특정환자예약내역검색ToolStripMenuItem.Text = "특정 환자 예약 내역 검색";
            this.특정환자예약내역검색ToolStripMenuItem.Click += new System.EventHandler(this.특정환자예약내역검색ToolStripMenuItem_Click);
            // 
            // 각종조회ToolStripMenuItem
            // 
            this.각종조회ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.진료과예약순위ToolStripMenuItem,
            this.의사예약순위ToolStripMenuItem,
            this.행정직원예약순위ToolStripMenuItem,
            this.patientRank});
            this.각종조회ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.각종조회ToolStripMenuItem.Name = "각종조회ToolStripMenuItem";
            this.각종조회ToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.각종조회ToolStripMenuItem.Text = "순위";
            // 
            // 진료과예약순위ToolStripMenuItem
            // 
            this.진료과예약순위ToolStripMenuItem.Name = "진료과예약순위ToolStripMenuItem";
            this.진료과예약순위ToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.진료과예약순위ToolStripMenuItem.Text = "진료과 예약 순위";
            this.진료과예약순위ToolStripMenuItem.Click += new System.EventHandler(this.진료과예약순위ToolStripMenuItem_Click);
            // 
            // 의사예약순위ToolStripMenuItem
            // 
            this.의사예약순위ToolStripMenuItem.Name = "의사예약순위ToolStripMenuItem";
            this.의사예약순위ToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.의사예약순위ToolStripMenuItem.Text = "의사 예약 순위";
            this.의사예약순위ToolStripMenuItem.Click += new System.EventHandler(this.의사예약순위ToolStripMenuItem_Click);
            // 
            // 행정직원예약순위ToolStripMenuItem
            // 
            this.행정직원예약순위ToolStripMenuItem.Name = "행정직원예약순위ToolStripMenuItem";
            this.행정직원예약순위ToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.행정직원예약순위ToolStripMenuItem.Text = "행정직원 예약 순위";
            this.행정직원예약순위ToolStripMenuItem.Click += new System.EventHandler(this.행정직원예약순위ToolStripMenuItem_Click);
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(163, 68);
            this.Post.Multiline = true;
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(237, 195);
            this.Post.TabIndex = 11;
            // 
            // postClear
            // 
            this.postClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.postClear.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.postClear.ForeColor = System.Drawing.Color.White;
            this.postClear.Location = new System.Drawing.Point(416, 202);
            this.postClear.Name = "postClear";
            this.postClear.Size = new System.Drawing.Size(151, 61);
            this.postClear.TabIndex = 14;
            this.postClear.Text = "지우기";
            this.postClear.UseVisualStyleBackColor = false;
            this.postClear.Click += new System.EventHandler(this.postClear_Click);
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Total.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(416, 135);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(151, 61);
            this.Total.TabIndex = 15;
            this.Total.Text = "총 현황";
            this.Total.UseVisualStyleBackColor = false;
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // empPhoto
            // 
            this.empPhoto.Location = new System.Drawing.Point(12, 68);
            this.empPhoto.Name = "empPhoto";
            this.empPhoto.Size = new System.Drawing.Size(98, 138);
            this.empPhoto.TabIndex = 16;
            this.empPhoto.TabStop = false;
            // 
            // empName
            // 
            this.empName.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.empName.Location = new System.Drawing.Point(7, 227);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(150, 36);
            this.empName.TabIndex = 76;
            this.empName.Text = "이름";
            // 
            // patientRank
            // 
            this.patientRank.Name = "patientRank";
            this.patientRank.Size = new System.Drawing.Size(264, 32);
            this.patientRank.Text = "환자 예약 횟수";
            this.patientRank.Click += new System.EventHandler(this.patientRank_Click);
            // 
            // manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 281);
            this.ControlBox = false;
            this.Controls.Add(this.empName);
            this.Controls.Add(this.empPhoto);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.postClear);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "manage";
            this.Text = "진료 예약 시스템";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 정보수정하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 아이디만수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 나머지정보수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환자관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새환자등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환자정보삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환자예약관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환자진료예약ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예약현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예약수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예약삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 의사관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새의사등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 의사정보삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 각종조회ToolStripMenuItem;
        public System.Windows.Forms.TextBox Post;
        private System.Windows.Forms.Button postClear;
        private System.Windows.Forms.ToolStripMenuItem 진료과예약순위ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 의사예약순위ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 행정직원예약순위ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.ToolStripMenuItem seedoctors;
        private System.Windows.Forms.ToolStripMenuItem seepatient;
        private System.Windows.Forms.PictureBox empPhoto;
        public System.Windows.Forms.Label empName;
        private System.Windows.Forms.ToolStripMenuItem 내가예약한환자들목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 특정환자예약내역검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorEdit;
        private System.Windows.Forms.ToolStripMenuItem patientEdit;
        private System.Windows.Forms.ToolStripMenuItem patientRank;
    }
}