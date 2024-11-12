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
using System.Security.Cryptography.X509Certificates;
namespace OnTap
{
    public partial class FrmCau3 : Form
    {
        public FrmCau3()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void FrmCau3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source =.\SQLEXPRESS;Initial Catalog = QLbong; Integrated Security = True");
            con.Open();
            Hienthi();
        }
        
        public void Hienthi()
        {
            string sqlSelect = "SELECT *FROM bong ";
            SqlCommand command = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvcauthu.DataSource = dt;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sqlAdd = "INSERT INTO bong VALUES (@ten,@tuoi,@sobanthang,@luong)";
            SqlCommand command = new SqlCommand(sqlAdd, con);
            command.CommandText = sqlAdd;
            command.Parameters.AddWithValue("ten", txtTen.Text);
            command.Parameters.AddWithValue("tuoi", txtTuoi.Text);
            command.Parameters.AddWithValue("sobanthang", txtBanthang.Text);
            command.Parameters.AddWithValue("luong", txtluong.Text);
            command.ExecuteNonQuery();
            Hienthi();
        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDau_Click(object sender, EventArgs e)
        {
            int i = 0;
            Hienthi();
            MessageBox.Show("Bạn đang ở đầu trang","Thông báo");
        }

        private void btTruoc_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(i > 0 )
            {
                i -= 1;
                Hienthi();
            } 
            else {
                MessageBox.Show("Bạn đang ở trước trang","Thông báo");
            }
        }

        private void btSau_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (i < 0)
            {
                i += 1;
                Hienthi();
            }
            else {
                MessageBox.Show("Bạn đang ở sau trang", "Thông báo");
            }
        }

        private void btCuoi_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvcauthu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.ReadOnly = true;
            int i;
            i = dgvcauthu.CurrentRow.Index;
            txtTen.Text = dgvcauthu.Rows[i].Cells[0].Value.ToString();
            txtTuoi .Text = dgvcauthu.Rows[i].Cells[1].Value.ToString();
            txtBanthang.Text = dgvcauthu.Rows[i].Cells[2].Value.ToString();
            txtluong.Text = dgvcauthu.Rows[i].Cells[3].Value.ToString();
            //tb_QueQuan.Text = dgv_DanhSachSinhVien.Rows[i].Cells[4].Value.ToString();
        }
    }
}
