namespace DatabaseTeamProject
{
    partial class mypatients
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
            this.mypat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mypat)).BeginInit();
            this.SuspendLayout();
            // 
            // mypat
            // 
            this.mypat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mypat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mypat.BackgroundColor = System.Drawing.Color.White;
            this.mypat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mypat.GridColor = System.Drawing.Color.Black;
            this.mypat.Location = new System.Drawing.Point(2, 1);
            this.mypat.Name = "mypat";
            this.mypat.RowTemplate.Height = 27;
            this.mypat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mypat.Size = new System.Drawing.Size(1200, 429);
            this.mypat.TabIndex = 11;
            // 
            // mypatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 430);
            this.Controls.Add(this.mypat);
            this.Name = "mypatients";
            this.Text = "내가 예약을 해준 환자들";
            this.Load += new System.EventHandler(this.mypatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mypat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mypat;
    }
}