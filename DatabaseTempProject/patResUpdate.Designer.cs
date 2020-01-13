namespace DatabaseTeamProject
{
    partial class patResUpdate
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
            this.existRes = new System.Windows.Forms.DataGridView();
            this.ResUpdateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeMinute = new System.Windows.Forms.ComboBox();
            this.timeHour = new System.Windows.Forms.ComboBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.existRes)).BeginInit();
            this.SuspendLayout();
            // 
            // existRes
            // 
            this.existRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.existRes.BackgroundColor = System.Drawing.Color.White;
            this.existRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.existRes.GridColor = System.Drawing.Color.Black;
            this.existRes.Location = new System.Drawing.Point(0, 0);
            this.existRes.Name = "existRes";
            this.existRes.ReadOnly = true;
            this.existRes.RowTemplate.Height = 27;
            this.existRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.existRes.Size = new System.Drawing.Size(603, 414);
            this.existRes.TabIndex = 37;
            this.existRes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.existRes_CellClick);
            // 
            // ResUpdateButton
            // 
            this.ResUpdateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ResUpdateButton.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResUpdateButton.ForeColor = System.Drawing.Color.White;
            this.ResUpdateButton.Location = new System.Drawing.Point(646, 315);
            this.ResUpdateButton.Name = "ResUpdateButton";
            this.ResUpdateButton.Size = new System.Drawing.Size(278, 76);
            this.ResUpdateButton.TabIndex = 90;
            this.ResUpdateButton.Text = "위의 날짜로 수정하기";
            this.ResUpdateButton.UseVisualStyleBackColor = false;
            this.ResUpdateButton.Click += new System.EventHandler(this.ResUpdateButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(874, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 36);
            this.label2.TabIndex = 89;
            this.label2.Text = "분";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(736, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 36);
            this.label1.TabIndex = 88;
            this.label1.Text = "시";
            // 
            // timeMinute
            // 
            this.timeMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeMinute.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeMinute.FormattingEnabled = true;
            this.timeMinute.Location = new System.Drawing.Point(803, 245);
            this.timeMinute.Name = "timeMinute";
            this.timeMinute.Size = new System.Drawing.Size(65, 39);
            this.timeMinute.TabIndex = 87;
            this.timeMinute.SelectedIndexChanged += new System.EventHandler(this.timeMinute_SelectedIndexChanged);
            // 
            // timeHour
            // 
            this.timeHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeHour.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeHour.FormattingEnabled = true;
            this.timeHour.Location = new System.Drawing.Point(665, 246);
            this.timeHour.Name = "timeHour";
            this.timeHour.Size = new System.Drawing.Size(65, 39);
            this.timeHour.TabIndex = 86;
            this.timeHour.SelectedIndexChanged += new System.EventHandler(this.timeHour_SelectedIndexChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(656, 18);
            this.monthCalendar2.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.monthCalendar2.MaxSelectionCount = 1;
            this.monthCalendar2.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 85;
            // 
            // patResUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 415);
            this.Controls.Add(this.ResUpdateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeMinute);
            this.Controls.Add(this.timeHour);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.existRes);
            this.Name = "patResUpdate";
            this.Text = "수정할 날짜 선택";
            this.Load += new System.EventHandler(this.patResUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.existRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView existRes;
        private System.Windows.Forms.Button ResUpdateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timeMinute;
        private System.Windows.Forms.ComboBox timeHour;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}