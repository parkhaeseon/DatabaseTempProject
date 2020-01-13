namespace DatabaseTeamProject
{
    partial class patientinformation
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
            this.patients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.patients)).BeginInit();
            this.SuspendLayout();
            // 
            // patients
            // 
            this.patients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patients.BackgroundColor = System.Drawing.Color.White;
            this.patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.patients.GridColor = System.Drawing.Color.Black;
            this.patients.Location = new System.Drawing.Point(0, 1);
            this.patients.Name = "patients";
            this.patients.ReadOnly = true;
            this.patients.RowTemplate.Height = 27;
            this.patients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.patients.Size = new System.Drawing.Size(1174, 476);
            this.patients.TabIndex = 37;
            // 
            // patientinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 478);
            this.Controls.Add(this.patients);
            this.Name = "patientinformation";
            this.Text = "환자 목록";
            this.Load += new System.EventHandler(this.patientinformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView patients;
    }
}