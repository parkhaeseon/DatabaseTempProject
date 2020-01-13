namespace DatabaseTeamProject
{
    partial class possibleDoctorSelect
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
            this.label2 = new System.Windows.Forms.Label();
            this.Entersure = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 36);
            this.label2.TabIndex = 37;
            this.label2.Text = "※ 드래그일 경우, 마우스를 뗀 행이 선택됩니다.";
            // 
            // Entersure
            // 
            this.Entersure.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Entersure.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Entersure.ForeColor = System.Drawing.Color.White;
            this.Entersure.Location = new System.Drawing.Point(152, 451);
            this.Entersure.Name = "Entersure";
            this.Entersure.Size = new System.Drawing.Size(204, 76);
            this.Entersure.TabIndex = 36;
            this.Entersure.Text = "선택하기";
            this.Entersure.UseVisualStyleBackColor = false;
            this.Entersure.Click += new System.EventHandler(this.Entersure_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.GridColor = System.Drawing.Color.Black;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(508, 361);
            this.dataGridView2.TabIndex = 35;
            // 
            // possibleDoctorSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Entersure);
            this.Controls.Add(this.dataGridView2);
            this.Name = "possibleDoctorSelect";
            this.Text = "진료 가능한 의사";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.possibleDoctorSelect_FormClosed);
            this.Load += new System.EventHandler(this.possibleDoctorSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Entersure;
        public System.Windows.Forms.DataGridView dataGridView2;
    }
}