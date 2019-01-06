namespace TestProject
{
    partial class student_regis_course
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
            this.sv_dk = new System.Windows.Forms.DataGridView();
            this.dk_button = new System.Windows.Forms.Button();
            this.huy_button = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sv_dk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(134, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký học phần";
            // 
            // sv_dk
            // 
            this.sv_dk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sv_dk.Location = new System.Drawing.Point(12, 102);
            this.sv_dk.Name = "sv_dk";
            this.sv_dk.Size = new System.Drawing.Size(360, 195);
            this.sv_dk.TabIndex = 1;
            // 
            // dk_button
            // 
            this.dk_button.Location = new System.Drawing.Point(390, 117);
            this.dk_button.Name = "dk_button";
            this.dk_button.Size = new System.Drawing.Size(75, 23);
            this.dk_button.TabIndex = 2;
            this.dk_button.Text = "Đăng ký";
            this.dk_button.UseVisualStyleBackColor = true;
            // 
            // huy_button
            // 
            this.huy_button.Location = new System.Drawing.Point(390, 172);
            this.huy_button.Name = "huy_button";
            this.huy_button.Size = new System.Drawing.Size(75, 23);
            this.huy_button.TabIndex = 3;
            this.huy_button.Text = "Huy ĐK";
            this.huy_button.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(22, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // student_regis_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 352);
            this.Controls.Add(this.back);
            this.Controls.Add(this.huy_button);
            this.Controls.Add(this.dk_button);
            this.Controls.Add(this.sv_dk);
            this.Controls.Add(this.label1);
            this.Name = "student_regis_course";
            this.Text = "student_regis_course";
            ((System.ComponentModel.ISupportInitialize)(this.sv_dk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView sv_dk;
        private System.Windows.Forms.Button dk_button;
        private System.Windows.Forms.Button huy_button;
        private System.Windows.Forms.Button back;
    }
}