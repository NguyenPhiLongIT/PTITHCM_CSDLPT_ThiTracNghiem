using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private int ketNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại tên Server của Publisher và tên CSDL trong chuỗi kết nối.\n" + e.Message, "Thông báo", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (ketNoi_CSDLGOC() == 0) return;
            layDSPM("SELECT * FROM view_DanhSachPhanManh");
            cmbCoSo.SelectedIndex = 1;
            cmbCoSo.SelectedIndex = 0;
        }
        private void layDSPM(String cmd)
        {
            DataTable dataTable = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conn_publisher);
            dataAdapter.Fill(dataTable);
            conn_publisher.Close();
            Program.bsDanhSachPhanManh.DataSource = dataTable;

            cmbCoSo.DataSource = Program.bsDanhSachPhanManh;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cmbCoSo.SelectedValue.ToString();
            }
            catch (Exception){}
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (edtTenDangNhap.Text.Trim() == "" || edtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được trống", "Dialog", MessageBoxButtons.OK);
                return;
            }

            if (rbSinhVien.Checked)
            {
                Program.mLogin = Program.mLoginSV;
                Program.password = Program.passwordSV;
                Program.maSV = edtTenDangNhap.Text;

            }
            else 
            { 
                Program.mLogin = edtTenDangNhap.Text;
                Program.password = edtMatKhau.Text;
            }
            
            if (Program.ketNoi() == 0) return;

            Program.mCoso = cmbCoSo.SelectedIndex;
            Program.mLoginDN = Program.mLogin;
            Program.passwordDN = Program.password;
            string strLenh = "";
            if (rbSinhVien.Checked)
                strLenh = "EXEC SP_DangNhapSinhVien '" + Program.maSV + "','" + edtMatKhau.Text + "'";
            else strLenh = "EXEC SP_DangNhapGiangVien '" + Program.mLogin + "'";


            try
            {
                Program.myReader = Program.execSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.userName = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.userName))
                {
                    MessageBox.Show("Login nhập vào không có quyền\nXem lại username và password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login nhập vào không có quyền\nXem lại username và password\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Hide();

            if (rbSinhVien.Checked)
            {
                //this.Hide();
                Program.frmMainSinhVien = new frmMainSinhVien();
                Program.frmMainSinhVien.Activate();
                Program.frmMainSinhVien.MASO.Text = "Mã SV: " + Program.maSV;
                Program.frmMainSinhVien.HOTEN.Text = "Mã SV: " + Program.mHoten;
                Program.frmMainSinhVien.NHOM.Text = "Nhóm: " + Program.mGroup;
                Program.frmMainSinhVien.ShowDialog();
                //this.Close();
            }
            else
            {
                //this.Hide();
                Program.frmChinh = new frmMain();
                Program.frmChinh.MASO.Text = "Mã số: " + Program.userName;
                Program.frmChinh.HOTEN.Text = "Họ tên: " + Program.mHoten;
                Program.frmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;

                //Program.frmChinh.btnDangNhap.Enabled = false;
                //Program.frmChinh.btnTaoTaiKhoan.Enabled = true;
                //Program.frmChinh.btnDangXuat.Enabled = true;
                //Program.frmChinh.pageBaoCao.Visible = true;
                //Program.frmChinh.pageNhapXuat.Visible = true;

                Program.frmChinh.ShowDialog();
                //this.Close();
            }
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked)
            {
                edtMatKhau.UseSystemPasswordChar = false;
                cbHienMK.Text = "Ẩn MK";
            }
            else
            {
                edtMatKhau.UseSystemPasswordChar = true;
                cbHienMK.Text = "Hiện MK";
            }
        }
    }
}
