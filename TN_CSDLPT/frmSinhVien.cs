using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class frmSinhVien : Form
    {
        string macs = "";
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPTDataSet);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            TN_CSDLPTDataSet.EnforceConstraints = false;
            //macs = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            cmbCoSo.DataSource = Program.bsDanhSachPhanManh;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";

            cmbCoSo.SelectedIndex = Program.mCoso;

            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.TN_CSDLPTDataSet.SINHVIEN);

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);

            
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                //btnThem.Visibility = btnHuy.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnSua.Visibility
                //       = btnUndo.Visibility = btnRedo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                //btnThem.Visibility = btnHuy.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnSua.Visibility
                //    = btnUndo.Visibility = btnRedo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            //btnHuy.Enabled = btnGhi.Enabled = false;


            //if (undoList.Count == 0)
            //{
            //    btnUndo.Enabled = false;
            //}

        }

        private void tenLopComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaLop.Text = tenLopComboBox.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cmbCoSo.SelectedValue.ToString();
            }
            catch (Exception) { }
        }
    }
}
