﻿namespace DatabaseTeamProject
{
    partial class findPatientReservation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Entersure = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(588, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // Entersure
            // 
            this.Entersure.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Entersure.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Entersure.ForeColor = System.Drawing.Color.White;
            this.Entersure.Location = new System.Drawing.Point(191, 452);
            this.Entersure.Name = "Entersure";
            this.Entersure.Size = new System.Drawing.Size(204, 76);
            this.Entersure.TabIndex = 32;
            this.Entersure.Text = "등록하기";
            this.Entersure.UseVisualStyleBackColor = false;
            this.Entersure.Click += new System.EventHandler(this.Entersure_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(44, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 36);
            this.label2.TabIndex = 34;
            this.label2.Text = "※ 드래그일 경우, 마우스를 뗀 행이 선택됩니다.";
            // 
            // findPatientReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Entersure);
            this.Controls.Add(this.dataGridView1);
            this.Name = "findPatientReservation";
            this.Text = "환자 조회";
            this.Load += new System.EventHandler(this.findPatientReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Entersure;
        private System.Windows.Forms.Label label2;
    }
}