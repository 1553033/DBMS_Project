namespace TestProject
{
    partial class teacher_afterLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.nm_cntt = new System.Windows.Forms.Button();
            this.dbms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(129, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giáo vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "giao vụ name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(342, 18);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 2;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // nm_cntt
            // 
            this.nm_cntt.Location = new System.Drawing.Point(44, 127);
            this.nm_cntt.Name = "nm_cntt";
            this.nm_cntt.Size = new System.Drawing.Size(130, 53);
            this.nm_cntt.TabIndex = 3;
            this.nm_cntt.Text = "Nhập Môn CNTT";
            this.nm_cntt.UseVisualStyleBackColor = true;
            this.nm_cntt.Click += new System.EventHandler(this.nm_cntt_Click);
            // 
            // dbms
            // 
            this.dbms.Location = new System.Drawing.Point(258, 127);
            this.dbms.Name = "dbms";
            this.dbms.Size = new System.Drawing.Size(119, 53);
            this.dbms.TabIndex = 4;
            this.dbms.Text = "DBMS";
            this.dbms.UseVisualStyleBackColor = true;
            this.dbms.Click += new System.EventHandler(this.dbms_Click);
            // 
            // teacher_afterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 229);
            this.Controls.Add(this.dbms);
            this.Controls.Add(this.nm_cntt);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "teacher_afterLogin";
            this.Text = "teacher_afterLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button nm_cntt;
        private System.Windows.Forms.Button dbms;
    }
}