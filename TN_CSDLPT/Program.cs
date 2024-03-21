using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=MSI;Initial Catalog=TN_CSDLPT; Integrated Security=True;User ID=sa;Password=kc";

        public static SqlDataReader myReader;
        public static String serverName = "";
        public static String userName = "";
        public static String mLogin = "";
        public static String password = "";
        public static String mLoginSV = "SV";
        public static String passwordSV = "kc";
        public static String maSV = "";

        public static String database = "TN_CSDLPT";
        public static String remoteLogin = "sa";
        public static String remoteLoginPassword = "sa";
        public static String mLoginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mCoso = 0;

        //Lưu ds phân mảnh khi đăng nhập gồm 2 cột tên CS và tên Server
        public static BindingSource bsDanhSachPhanManh = new BindingSource();
        public static frmMain frmChinh = null;
        public static frmDangNhap frmDangNhap = null;
        public static frmMainSinhVien frmMainSinhVien = null;

        public static int ketNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                return 0;
            }
            try
            {

                connstr = "Data Source=" + serverName + ";Initial Catalog=" + database + ";User ID=" +
                         mLogin + ";password=" + password;
                conn.ConnectionString = connstr;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi Kết nối CSDL\nBạn xem lại username và password" + e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;

            }
        }
        //Thực thi tải dữ liệu về ko cho hiệu chỉnh
        public static SqlDataReader execSqlDataReader(string strLenh)
        {
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand(strLenh, conn);
            cmd.CommandType = CommandType.Text;

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (SqlException e)
            {
                conn.Close();
                MessageBox.Show("Chạy lệnh Data Reader lỗi\n" + e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        //Thực thi tải dữ liệu về và cho thêm xóa sửa
        public static DataTable execSqlDataTable(string sql)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //Cập nhật sp nhưng không trả về giá trị
        public static int execSqlNonQuery(string sql)
        {
            SqlCommand Sqlcmd = new SqlCommand(sql, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException e)
            {

                MessageBox.Show("Thực thi lệnh sql non query sai\n" + e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return 1;

            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDangNhap = new frmDangNhap();
            Application.Run(frmDangNhap);
        }
    }
}
