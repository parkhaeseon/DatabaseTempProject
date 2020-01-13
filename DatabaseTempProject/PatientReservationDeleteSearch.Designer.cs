namespace DatabaseTeamProject
{
    partial class PatientReservationDeleteSearch
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
            this.patresnow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patresnow)).BeginInit();
            this.SuspendLayout();
            // 
            // patresnow
            // 
            this.patresnow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patresnow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patresnow.BackgroundColor = System.Drawing.Color.White;
            this.patresnow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patresnow.GridColor = System.Drawing.Color.Black;
            this.patresnow.Location = new System.Drawing.Point(0, 53);
            this.patresnow.Name = "patresnow";
            this.patresnow.RowTemplate.Height = 27;
            this.patresnow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patresnow.Size = new System.Drawing.Size(675, 376);
            this.patresnow.TabIndex = 11;
            this.patresnow.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.patresnow_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "마우스 더블 클릭 시 삭제됩니다.";
            // 
            // PatientReservationDeleteSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patresnow);
            this.Name = "PatientReservationDeleteSearch";
            this.Text = "해당 환자 예약 내역";
            this.Load += new System.EventHandler(this.PatientReservationDeleteSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patresnow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patresnow;
        private System.Windows.Forms.Label label1;
    }
}