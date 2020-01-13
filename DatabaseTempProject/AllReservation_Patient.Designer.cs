namespace DatabaseTeamProject
{
    partial class AllReservation_Patient
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
            this.Allreservation = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.DayReservationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // Allreservation
            // 
            this.Allreservation.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Allreservation.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Allreservation.ForeColor = System.Drawing.Color.White;
            this.Allreservation.Location = new System.Drawing.Point(12, 368);
            this.Allreservation.Name = "Allreservation";
            this.Allreservation.Size = new System.Drawing.Size(248, 61);
            this.Allreservation.TabIndex = 8;
            this.Allreservation.Text = "전체 예약 보기";
            this.Allreservation.UseVisualStyleBackColor = false;
            this.Allreservation.Click += new System.EventHandler(this.Allreservation_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(12, 18);
            this.monthCalendar2.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.monthCalendar2.MaxSelectionCount = 1;
            this.monthCalendar2.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 9;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.Color.Black;
            this.dataGridView3.Location = new System.Drawing.Point(272, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1220, 429);
            this.dataGridView3.TabIndex = 10;
            // 
            // DayReservationButton
            // 
            this.DayReservationButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DayReservationButton.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DayReservationButton.ForeColor = System.Drawing.Color.White;
            this.DayReservationButton.Location = new System.Drawing.Point(12, 237);
            this.DayReservationButton.Name = "DayReservationButton";
            this.DayReservationButton.Size = new System.Drawing.Size(248, 61);
            this.DayReservationButton.TabIndex = 11;
            this.DayReservationButton.Text = "해당 날짜 예약 보기";
            this.DayReservationButton.UseVisualStyleBackColor = false;
            this.DayReservationButton.Click += new System.EventHandler(this.DayReservationButton_Click);
            // 
            // AllReservation_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1493, 445);
            this.Controls.Add(this.DayReservationButton);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.Allreservation);
            this.Name = "AllReservation_Patient";
            this.Text = "당일 및 전체 예약 현황";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Allreservation;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button DayReservationButton;
    }
}