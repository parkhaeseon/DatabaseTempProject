namespace DatabaseTeamProject
{
    partial class docaddredit
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roadaddr = new System.Windows.Forms.Button();
            this.searchRoad = new System.Windows.Forms.TextBox();
            this.labeladd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(53, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 36);
            this.label3.TabIndex = 40;
            this.label3.Text = "※ 도로명과 건물 번호는 띄어쓰기 해야함";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(53, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "※ 도로명(숫자 포함)과 건물 번호 모두 입력";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(54, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 36);
            this.label1.TabIndex = 38;
            this.label1.Text = "예시) 고덕로61길 37, 반포대로 58";
            // 
            // roadaddr
            // 
            this.roadaddr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.roadaddr.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.roadaddr.ForeColor = System.Drawing.Color.White;
            this.roadaddr.Location = new System.Drawing.Point(217, 276);
            this.roadaddr.Name = "roadaddr";
            this.roadaddr.Size = new System.Drawing.Size(211, 74);
            this.roadaddr.TabIndex = 37;
            this.roadaddr.Text = "검색하기";
            this.roadaddr.UseVisualStyleBackColor = false;
            this.roadaddr.Click += new System.EventHandler(this.roadaddr_Click);
            // 
            // searchRoad
            // 
            this.searchRoad.Font = new System.Drawing.Font("굴림", 14F);
            this.searchRoad.Location = new System.Drawing.Point(238, 151);
            this.searchRoad.Name = "searchRoad";
            this.searchRoad.Size = new System.Drawing.Size(220, 34);
            this.searchRoad.TabIndex = 36;
            // 
            // labeladd
            // 
            this.labeladd.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labeladd.Location = new System.Drawing.Point(54, 149);
            this.labeladd.Name = "labeladd";
            this.labeladd.Size = new System.Drawing.Size(155, 36);
            this.labeladd.TabIndex = 35;
            this.labeladd.Text = "검색할 도로명";
            // 
            // docaddredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roadaddr);
            this.Controls.Add(this.searchRoad);
            this.Controls.Add(this.labeladd);
            this.Name = "docaddredit";
            this.Text = "도로명 주소 검색창";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button roadaddr;
        private System.Windows.Forms.TextBox searchRoad;
        private System.Windows.Forms.Label labeladd;
    }
}