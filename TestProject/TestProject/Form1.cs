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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát ko?????", "Thông báo", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }*/
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            FormXemThongTinDocGia form = new FormXemThongTinDocGia();
            form.ShowDialog();*/
        }

        private void danhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            FormQuanLyMuonSach form = new FormQuanLyMuonSach();
            form.ShowDialog();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sự kiên cho nút Login
            String x = text_username.Text;
            if (x == "sv")
            {
                afterLogin form = new afterLogin();
                form.Show();
            }
            else if(x== "gv")
            {
                teacher_afterLogin form = new teacher_afterLogin();
                form.Show();
            }
            this.Hide();
        }
    }
}
