namespace DatabaseTeamProject
{
    partial class namepat
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
            this.NamePatient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NamePatient)).BeginInit();
            this.SuspendLayout();
            // 
            // NamePatient
            // 
            this.NamePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NamePatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NamePatient.BackgroundColor = System.Drawing.Color.White;
            this.NamePatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NamePatient.GridColor = System.Drawing.Color.Black;
            this.NamePatient.Location = new System.Drawing.Point(1, 0);
            this.NamePatient.Name = "NamePatient";
            this.NamePatient.RowTemplate.Height = 27;
            this.NamePatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.NamePatient.Size = new System.Drawing.Size(1222, 429);
            this.NamePatient.TabIndex = 11;
            // 
            // namepat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 430);
            this.Controls.Add(this.NamePatient);
            this.Name = "namepat";
            this.Text = "이름으로 환자 예약 내역 검색";
            this.Load += new System.EventHandler(this.namepat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NamePatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NamePatient;
    }
}