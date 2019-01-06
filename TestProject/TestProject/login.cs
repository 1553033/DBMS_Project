using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String x = text_username.Text;
            if (x == "sv")
            {
                afterLogin form = new afterLogin();
                form.FormClosed += new FormClosedEventHandler(form_colsed);
                form.Show();
            }
            else if (x == "gv")
            {
                teacher_afterLogin form = new teacher_afterLogin();
                form.FormClosed += new FormClosedEventHandler(form_colsed);
                form.Show();
            }
            this.Hide();
        }

        private void form_colsed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
