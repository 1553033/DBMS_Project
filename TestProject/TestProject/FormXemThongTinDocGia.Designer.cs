namespace TestProject
{
    partial class FormXemThongTinDocGia
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbNguoiLon = new System.Windows.Forms.ComboBox();
            this.btnTimTreEm = new System.Windows.Forms.Button();
            this.dgvDSTreEm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTreEm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Độc giả";
            // 
            // cbNguoiLon
            // 
            this.cbNguoiLon.FormattingEnabled = true;
            this.cbNguoiLon.Location = new System.Drawing.Point(92, 9);
            this.cbNguoiLon.Name = "cbNguoiLon";
            this.cbNguoiLon.Size = new System.Drawing.Size(303, 21);
            this.cbNguoiLon.TabIndex = 1;
            // 
            // btnTimTreEm
            // 
            this.btnTimTreEm.Location = new System.Drawing.Point(25, 41);
            this.btnTimTreEm.Name = "btnTimTreEm";
            this.btnTimTreEm.Size = new System.Drawing.Size(75, 23);
            this.btnTimTreEm.TabIndex = 2;
            this.btnTimTreEm.Text = "Tìm trẻ em";
            this.btnTimTreEm.UseVisualStyleBackColor = true;
            this.btnTimTreEm.Click += new System.EventHandler(this.btnTimTreEm_Click);
            // 
            // dgvDSTreEm
            // 
            this.dgvDSTreEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTreEm.Location = new System.Drawing.Point(25, 71);
            this.dgvDSTreEm.Name = "dgvDSTreEm";
            this.dgvDSTreEm.Size = new System.Drawing.Size(370, 249);
            this.dgvDSTreEm.TabIndex = 3;
            // 
            // FormXemThongTinDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 339);
            this.Controls.Add(this.dgvDSTreEm);
            this.Controls.Add(this.btnTimTreEm);
            this.Controls.Add(this.cbNguoiLon);
            this.Controls.Add(this.label1);
            this.Name = "FormXemThongTinDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem thông tin độc giả";
            this.Load += new System.EventHandler(this.FormXemThongTinDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTreEm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNguoiLon;
        private System.Windows.Forms.Button btnTimTreEm;
        private System.Windows.Forms.DataGridView dgvDSTreEm;
    }
}