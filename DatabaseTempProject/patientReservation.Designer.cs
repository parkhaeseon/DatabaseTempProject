namespace DatabaseTeamProject
{
    partial class patientReservation
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
            this.patientIdReservation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.patientNameReservation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.doctorNameReservation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorIdReservation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patientSelect = new System.Windows.Forms.Button();
            this.possibleDoctor = new System.Windows.Forms.Button();
            this.timeReser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeSelect = new System.Windows.Forms.Button();
            this.goReservation = new System.Windows.Forms.Button();
            this.alldelete = new System.Windows.Forms.Button();
            this.reSelect = new System.Windows.Forms.Button();
            this.res_pat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientIdReservation
            // 
            this.patientIdReservation.Font = new System.Drawing.Font("굴림", 14F);
            this.patientIdReservation.Location = new System.Drawing.Point(272, 106);
            this.patientIdReservation.Name = "patientIdReservation";
            this.patientIdReservation.ReadOnly = true;
            this.patientIdReservation.Size = new System.Drawing.Size(240, 34);
            this.patientIdReservation.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(12, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 36);
            this.label8.TabIndex = 72;
            this.label8.Text = "환자 아이디";
            // 
            // patientNameReservation
            // 
            this.patientNameReservation.Font = new System.Drawing.Font("굴림", 14F);
            this.patientNameReservation.Location = new System.Drawing.Point(272, 42);
            this.patientNameReservation.Name = "patientNameReservation";
            this.patientNameReservation.Size = new System.Drawing.Size(240, 34);
            this.patientNameReservation.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(12, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 36);
            this.label9.TabIndex = 70;
            this.label9.Text = "환자 이름";
            // 
            // doctorNameReservation
            // 
            this.doctorNameReservation.Font = new System.Drawing.Font("굴림", 14F);
            this.doctorNameReservation.Location = new System.Drawing.Point(272, 327);
            this.doctorNameReservation.Name = "doctorNameReservation";
            this.doctorNameReservation.ReadOnly = true;
            this.doctorNameReservation.Size = new System.Drawing.Size(240, 34);
            this.doctorNameReservation.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 74;
            this.label1.Text = "진료 의사 이름";
            // 
            // doctorIdReservation
            // 
            this.doctorIdReservation.Font = new System.Drawing.Font("굴림", 14F);
            this.doctorIdReservation.Location = new System.Drawing.Point(272, 390);
            this.doctorIdReservation.Name = "doctorIdReservation";
            this.doctorIdReservation.ReadOnly = true;
            this.doctorIdReservation.Size = new System.Drawing.Size(240, 34);
            this.doctorIdReservation.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 36);
            this.label2.TabIndex = 76;
            this.label2.Text = "진료 의사 아이디";
            // 
            // patientSelect
            // 
            this.patientSelect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.patientSelect.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.patientSelect.ForeColor = System.Drawing.Color.White;
            this.patientSelect.Location = new System.Drawing.Point(554, 31);
            this.patientSelect.Name = "patientSelect";
            this.patientSelect.Size = new System.Drawing.Size(195, 52);
            this.patientSelect.TabIndex = 78;
            this.patientSelect.Text = "환자 조회";
            this.patientSelect.UseVisualStyleBackColor = false;
            this.patientSelect.Click += new System.EventHandler(this.patientSelect_Click);
            // 
            // possibleDoctor
            // 
            this.possibleDoctor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.possibleDoctor.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.possibleDoctor.ForeColor = System.Drawing.Color.White;
            this.possibleDoctor.Location = new System.Drawing.Point(554, 316);
            this.possibleDoctor.Name = "possibleDoctor";
            this.possibleDoctor.Size = new System.Drawing.Size(231, 52);
            this.possibleDoctor.TabIndex = 79;
            this.possibleDoctor.Text = "진료 가능 의사 조회";
            this.possibleDoctor.UseVisualStyleBackColor = false;
            this.possibleDoctor.Click += new System.EventHandler(this.possibleDoctor_Click);
            // 
            // timeReser
            // 
            this.timeReser.Font = new System.Drawing.Font("굴림", 14F);
            this.timeReser.Location = new System.Drawing.Point(272, 169);
            this.timeReser.Name = "timeReser";
            this.timeReser.ReadOnly = true;
            this.timeReser.Size = new System.Drawing.Size(399, 34);
            this.timeReser.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 36);
            this.label3.TabIndex = 80;
            this.label3.Text = "진료 예약 시간";
            // 
            // TimeSelect
            // 
            this.TimeSelect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TimeSelect.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimeSelect.ForeColor = System.Drawing.Color.White;
            this.TimeSelect.Location = new System.Drawing.Point(747, 158);
            this.TimeSelect.Name = "TimeSelect";
            this.TimeSelect.Size = new System.Drawing.Size(231, 52);
            this.TimeSelect.TabIndex = 82;
            this.TimeSelect.Text = "날짜 및 시간 선택";
            this.TimeSelect.UseVisualStyleBackColor = false;
            this.TimeSelect.Click += new System.EventHandler(this.TimeSelect_Click);
            // 
            // goReservation
            // 
            this.goReservation.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.goReservation.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goReservation.ForeColor = System.Drawing.Color.White;
            this.goReservation.Location = new System.Drawing.Point(370, 485);
            this.goReservation.Name = "goReservation";
            this.goReservation.Size = new System.Drawing.Size(204, 76);
            this.goReservation.TabIndex = 83;
            this.goReservation.Text = "예약하기";
            this.goReservation.UseVisualStyleBackColor = false;
            this.goReservation.Click += new System.EventHandler(this.goReservation_Click);
            // 
            // alldelete
            // 
            this.alldelete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.alldelete.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.alldelete.ForeColor = System.Drawing.Color.White;
            this.alldelete.Location = new System.Drawing.Point(829, 497);
            this.alldelete.Name = "alldelete";
            this.alldelete.Size = new System.Drawing.Size(149, 59);
            this.alldelete.TabIndex = 84;
            this.alldelete.Text = "지우기";
            this.alldelete.UseVisualStyleBackColor = false;
            this.alldelete.Click += new System.EventHandler(this.alldelete_Click);
            // 
            // reSelect
            // 
            this.reSelect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.reSelect.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reSelect.ForeColor = System.Drawing.Color.White;
            this.reSelect.Location = new System.Drawing.Point(747, 216);
            this.reSelect.Name = "reSelect";
            this.reSelect.Size = new System.Drawing.Size(231, 52);
            this.reSelect.TabIndex = 85;
            this.reSelect.Text = "다시 선택";
            this.reSelect.UseVisualStyleBackColor = false;
            this.reSelect.Click += new System.EventHandler(this.reSelect_Click);
            // 
            // res_pat
            // 
            this.res_pat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.res_pat.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.res_pat.ForeColor = System.Drawing.Color.White;
            this.res_pat.Location = new System.Drawing.Point(770, 31);
            this.res_pat.Name = "res_pat";
            this.res_pat.Size = new System.Drawing.Size(181, 52);
            this.res_pat.TabIndex = 86;
            this.res_pat.Text = "다시 검색";
            this.res_pat.UseVisualStyleBackColor = false;
            this.res_pat.Click += new System.EventHandler(this.res_pat_Click);
            // 
            // patientReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 581);
            this.Controls.Add(this.res_pat);
            this.Controls.Add(this.reSelect);
            this.Controls.Add(this.alldelete);
            this.Controls.Add(this.goReservation);
            this.Controls.Add(this.TimeSelect);
            this.Controls.Add(this.timeReser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.possibleDoctor);
            this.Controls.Add(this.patientSelect);
            this.Controls.Add(this.doctorIdReservation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doctorNameReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientIdReservation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.patientNameReservation);
            this.Controls.Add(this.label9);
            this.Name = "patientReservation";
            this.Text = "환자 진료 예약";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox patientIdReservation;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox patientNameReservation;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox doctorNameReservation;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox doctorIdReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button patientSelect;
        private System.Windows.Forms.Button possibleDoctor;
        public System.Windows.Forms.TextBox timeReser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button goReservation;
        private System.Windows.Forms.Button alldelete;
        public System.Windows.Forms.Button TimeSelect;
        public System.Windows.Forms.Button reSelect;
        public System.Windows.Forms.Button res_pat;
    }
}