using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestProject
{
    public partial class FormQuanLyMuonSach : Form
    {
        public FormQuanLyMuonSach()
        {
            InitializeComponent();
        }

        private void FormQuanLyMuonSach_Load(object sender, EventArgs e)
        {
            LoadDSTuaSach();
            // Tắt nút Mượn
            btnMuon.Enabled = false;
        }

        private void LoadDSTuaSach()
        {
            // Bước 1: Mở kết nối đến SQL Server
            SqlConnection connection;
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=HQT_CSDL;Integrated Security=True";
            connection.Open();

            // Bước 2
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_danhsachtuasach";
            command.Connection = connection;

            //SqlParameter sqlParameter = new SqlParameter("isbn", 12);
            //command.Parameters.Add(sqlParameter);

            // Bước 3: Thực hiện SQl
            /*Câu select: DataSet + SQLDataAdapter*/
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            /*Câu insert, delete, update: SqlCommand*/
            // Bước 4: Xử lý data ( nếu insert, delete, update thì bỏ qua )
            if(dataSet.Tables.Count > 0)
            {
                cbTuaSach.DataSource = dataSet.Tables[0];
                cbTuaSach.DisplayMember = "tua_sach";
                cbTuaSach.ValueMember = "isbn";
            }
            // Bước 5: Ngắt kết nối
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = cbTuaSach.SelectedValue.ToString();
            // Bước 1: Mở kết nối đến SQL Server
            SqlConnection connection;
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=HQT_CSDL;Integrated Security=True";
            connection.Open();

            // Bước 2
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cuonsachtheotua";
            command.Connection = connection;
            SqlParameter sqlParameter = new SqlParameter("isbn", Int32.Parse(isbn));
            command.Parameters.Add(sqlParameter);

            // Bước 3
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            // Bước 4: Xử lý data ( nếu insert, delete, update thì bỏ qua )
            if (dataSet.Tables.Count > 0)
            {
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không có thể mượn");
                }
                else
                {
                    dgvSachCoTheMuon.DataSource = dataSet.Tables[0];
                }
            }
            // Bước 5: Ngắt kết nối
            connection.Close();

            btnMuon.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
