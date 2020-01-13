namespace DatabaseTeamProject
{
    partial class doctorinformation
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
            this.doctors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.doctors)).BeginInit();
            this.SuspendLayout();
            // 
            // doctors
            // 
            this.doctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctors.BackgroundColor = System.Drawing.Color.White;
            this.doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.doctors.GridColor = System.Drawing.Color.Black;
            this.doctors.Location = new System.Drawing.Point(0, 1);
            this.doctors.Name = "doctors";
            this.doctors.ReadOnly = true;
            this.doctors.RowTemplate.Height = 27;
            this.doctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.doctors.Size = new System.Drawing.Size(1179, 459);
            this.doctors.TabIndex = 36;
            this.doctors.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.doctors_CellFormatting);
            // 
            // doctorinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 460);
            this.Controls.Add(this.doctors);
            this.Name = "doctorinformation";
            this.Text = "의사 목록";
            this.Load += new System.EventHandler(this.doctorinformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView doctors;
    }
}