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
    public partial class afterLogin : Form
    {
        public afterLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dk_hp_Click(object sender, EventArgs e)
        {
            student_regis_course form = new student_regis_course();
            form.ShowDialog();
        }

        private void x_hp_Click(object sender, EventArgs e)
        {
            coure_of_student form = new coure_of_student();
            form.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
