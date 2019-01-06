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
    public partial class teacher_afterLogin : Form
    {
        public teacher_afterLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nm_cntt_Click(object sender, EventArgs e)
        {
            course_of_teacher form = new course_of_teacher();
            form.ShowDialog();
        }

        private void dbms_Click(object sender, EventArgs e)
        {
            course_of_teacher form = new course_of_teacher();
            form.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
