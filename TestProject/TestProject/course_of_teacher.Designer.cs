namespace TestProject
{
    partial class course_of_teacher
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
            this.button1 = new System.Windows.Forms.Button();
            this.ds_sv = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.minute = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(114, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DS sinh viên trong học phần";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ds_sv
            // 
            this.ds_sv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds_sv.Location = new System.Drawing.Point(38, 112);
            this.ds_sv.Name = "ds_sv";
            this.ds_sv.Size = new System.Drawing.Size(408, 205);
            this.ds_sv.TabIndex = 2;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.add.Location = new System.Drawing.Point(466, 122);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(99, 36);
            this.add.TabIndex = 3;
            this.add.Text = "Thêm 1 slot";
            this.add.UseVisualStyleBackColor = true;
            // 
            // minute
            // 
            this.minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.minute.Location = new System.Drawing.Point(466, 189);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(99, 40);
            this.minute.TabIndex = 4;
            this.minute.Text = "Giảm 1 slot";
            this.minute.UseVisualStyleBackColor = true;
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sum.Location = new System.Drawing.Point(211, 345);
            this.sum.Name = "sum";
            this.sum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sum.Size = new System.Drawing.Size(95, 20);
            this.sum.TabIndex = 5;
            this.sum.Text = "Tổng 4 slots";
            // 
            // course_of_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 385);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.add);
            this.Controls.Add(this.ds_sv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "course_of_teacher";
            this.Text = "course_of_teacher";
            ((System.ComponentModel.ISupportInitialize)(this.ds_sv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ds_sv;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minute;
        private System.Windows.Forms.Label sum;
    }
}