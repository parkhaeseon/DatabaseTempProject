namespace DatabaseTeamProject
{
    partial class TimeSelectReservation
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timeHour = new System.Windows.Forms.ComboBox();
            this.timeMinute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(38, 33);
            this.monthCalendar1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // timeHour
            // 
            this.timeHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeHour.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeHour.FormattingEnabled = true;
            this.timeHour.Location = new System.Drawing.Point(38, 261);
            this.timeHour.Name = "timeHour";
            this.timeHour.Size = new System.Drawing.Size(65, 39);
            this.timeHour.TabIndex = 14;
            this.timeHour.SelectedIndexChanged += new System.EventHandler(this.timeHour_SelectedIndexChanged);
            // 
            // timeMinute
            // 
            this.timeMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeMinute.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeMinute.FormattingEnabled = true;
            this.timeMinute.Location = new System.Drawing.Point(176, 260);
            this.timeMinute.Name = "timeMinute";
            this.timeMinute.Size = new System.Drawing.Size(65, 39);
            this.timeMinute.TabIndex = 15;
            this.timeMinute.SelectedIndexChanged += new System.EventHandler(this.timeMinute_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(109, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "시";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(247, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "분";
            // 
            // DateSelect
            // 
            this.DateSelect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DateSelect.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DateSelect.ForeColor = System.Drawing.Color.White;
            this.DateSelect.Location = new System.Drawing.Point(59, 337);
            this.DateSelect.Name = "DateSelect";
            this.DateSelect.Size = new System.Drawing.Size(204, 76);
            this.DateSelect.TabIndex = 84;
            this.DateSelect.Text = "선택하기";
            this.DateSelect.UseVisualStyleBackColor = false;
            this.DateSelect.Click += new System.EventHandler(this.DateSelect_Click);
            // 
            // TimeSelectReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 456);
            this.Controls.Add(this.DateSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeMinute);
            this.Controls.Add(this.timeHour);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "TimeSelectReservation";
            this.Text = "날짜 및 시간 선택";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox timeHour;
        private System.Windows.Forms.ComboBox timeMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DateSelect;
    }
}