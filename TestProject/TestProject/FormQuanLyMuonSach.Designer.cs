namespace TestProject
{
    partial class FormQuanLyMuonSach
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
            this.cbTuaSach = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSachCoTheMuon = new System.Windows.Forms.DataGridView();
            this.btnMuon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCoTheMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tựa sách";
            // 
            // cbTuaSach
            // 
            this.cbTuaSach.FormattingEnabled = true;
            this.cbTuaSach.Location = new System.Drawing.Point(408, 22);
            this.cbTuaSach.Name = "cbTuaSach";
            this.cbTuaSach.Size = new System.Drawing.Size(121, 21);
            this.cbTuaSach.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sách có thể mượn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvSachCoTheMuon
            // 
            this.dgvSachCoTheMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachCoTheMuon.Location = new System.Drawing.Point(107, 148);
            this.dgvSachCoTheMuon.Name = "dgvSachCoTheMuon";
            this.dgvSachCoTheMuon.Size = new System.Drawing.Size(572, 236);
            this.dgvSachCoTheMuon.TabIndex = 4;
            // 
            // btnMuon
            // 
            this.btnMuon.Location = new System.Drawing.Point(631, 405);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(75, 23);
            this.btnMuon.TabIndex = 5;
            this.btnMuon.Text = "Mượn";
            this.btnMuon.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.dgvSachCoTheMuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTuaSach);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLyMuonSach";
            this.Text = "d2ws1aqcxdxsz";
            this.Load += new System.EventHandler(this.FormQuanLyMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCoTheMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTuaSach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSachCoTheMuon;
        private System.Windows.Forms.Button btnMuon;
    }
}