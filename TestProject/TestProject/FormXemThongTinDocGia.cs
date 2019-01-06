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
    public partial class FormXemThongTinDocGia : Form
    {
        public FormXemThongTinDocGia()
        {
            InitializeComponent();
        }

        private void FormXemThongTinDocGia_Load(object sender, EventArgs e)
        {
            LoadThongTinDocGiaNguoiLon();
        }

        private void LoadThongTinDocGiaNguoiLon()
        {

            // Bước 1: Mở kết nối đến SQL Server
            SqlConnection connection;
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=HQT_CSDL;Integrated Security=True";
            connection.Open();
            // Bước 2: SQL
            string SQL;
            SQL = "select DocGia.ma_docgia,DocGia.ho + ' ' + DocGia.tenlot + ' ' + DocGia.ten as HoTen from DocGia inner join NguoiLon on DocGia.ma_docgia = NguoiLon.ma_docgia order by HoTen";
            // Bước 3: Thực hiện SQl
            /*Câu select: DataSet + SQLDataAdapter*/
            SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            /*Câu insert, delete, update: SqlCommand*/
            // Bước 4: Xử lý data ( nếu insert, delete, update thì bỏ qua )
            if(dataSet.Tables.Count > 0)
            {
                cbNguoiLon.DataSource = dataSet.Tables[0];
                cbNguoiLon.DisplayMember = "HoTen";
                cbNguoiLon.ValueMember = "ma_docgia";

                //cbNguoiLon.SelectedValue.ToString();
            }
            // Bước 5: Ngắt kết nối
            connection.Close();
        }

        private void btnTimTreEm_Click(object sender, EventArgs e)
        {
            // Bước 1: Mở kết nối đến SQL Server
            SqlConnection connection;
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=HQT_CSDL;Integrated Security=True";
            connection.Open();
            // Bước 2: SQL
            string SQL;
            SQL = "select DocGia.ma_docgia,DocGia.ho + ' ' + DocGia.tenlot + ' ' + DocGia.ten as HoTen, DocGia.NgaySinh from DocGia inner join TreEm on DocGia.ma_docgia=TreEm.ma_docgia where TreEm.ma_docgia_nguoilon =" + cbNguoiLon.SelectedValue.ToString();
            // Bước 3: Thực hiện SQl
            /*Câu select: DataSet + SQLDataAdapter*/
            SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            /*Câu insert, delete, update: SqlCommand*/
            // Bước 4: Xử lý data ( nếu insert, delete, update thì bỏ qua )
            if (dataSet.Tables.Count > 0)
            {
                if(dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không có trẻ em");
                }
                else
                {
                    dgvDSTreEm.DataSource = dataSet.Tables[0];
                }
                //cbNguoiLon.SelectedValue.ToString();
            }
            // Bước 5: Ngắt kết nối
            connection.Close();
        }
    }
}
