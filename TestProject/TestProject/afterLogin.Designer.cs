namespace TestProject
{
    partial class afterLogin
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
            this.userName = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.dk_hp = new System.Windows.Forms.Button();
            this.x_hp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(410, 21);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 13);
            this.userName.TabIndex = 1;
            this.userName.Text = "tên sinh viên";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(493, 16);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 2;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // dk_hp
            // 
            this.dk_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dk_hp.Location = new System.Drawing.Point(52, 85);
            this.dk_hp.Name = "dk_hp";
            this.dk_hp.Size = new System.Drawing.Size(152, 43);
            this.dk_hp.TabIndex = 3;
            this.dk_hp.Text = "Đăng ký học phần";
            this.dk_hp.UseVisualStyleBackColor = true;
            this.dk_hp.Click += new System.EventHandler(this.dk_hp_Click);
            // 
            // x_hp
            // 
            this.x_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.x_hp.Location = new System.Drawing.Point(293, 85);
            this.x_hp.Name = "x_hp";
            this.x_hp.Size = new System.Drawing.Size(184, 43);
            this.x_hp.TabIndex = 4;
            this.x_hp.Text = "Xem học phần đã đăng ký";
            this.x_hp.UseVisualStyleBackColor = true;
            this.x_hp.Click += new System.EventHandler(this.x_hp_Click);
            // 
            // afterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 187);
            this.Controls.Add(this.x_hp);
            this.Controls.Add(this.dk_hp);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Name = "afterLogin";
            this.Text = "afterLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button dk_hp;
        private System.Windows.Forms.Button x_hp;
    }
}