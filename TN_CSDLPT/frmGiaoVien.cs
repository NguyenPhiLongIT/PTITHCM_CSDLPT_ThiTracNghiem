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
    public partial class frmGiaoVien : Form
    {
        int vitri = 0;
        string macs = "";
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false; //khong bat buoc kiem tra dieu kien khoa ngoai

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.BODE' table. You can move, or remove it, as needed.
            this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.BODETableAdapter.Fill(this.DS.BODE);
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.DSKHOA' table. You can move, or remove it, as needed.
            //this.dSKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            //this.dSKHOATableAdapter.Fill(this.DS.DSKHOA);

            macs = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            cmbCoSo.DataSource = Program.bsDanhSachPhanManh;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true; //Bat tat cho phep chuyen co so
                btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;

                // Deny edit for role TRUONG for form GiaoVien
                hOTextBox.ReadOnly = true;
                tENTextBox.ReadOnly = true;
                dIACHITextBox.ReadOnly = true;
                txtMAKH.ReadOnly = true;
                cmbDSKhoa.Enabled = false;
            }
            else
            {
                cmbCoSo.Enabled = false;
            }

        }

        private void tENKHLabel_Click(object sender, EventArgs e)
        {

        }


        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbCoSo.SelectedValue.ToString();
            Console.WriteLine(Program.mCoso);

            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.mLogin = Program.remoteLogin;
                Program.password = Program.remoteLoginPassword;
            }
            else
            {
                Program.mLogin = Program.mLoginDN;
                Program.password = Program.passwordDN;
            }



            if (Program.ketNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối vào cơ sở mới", "", MessageBoxButtons.OK);
            }

            else
            {
                this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

                this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.BODETableAdapter.Fill(this.DS.BODE);

                this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

                this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOATableAdapter.Fill(this.DS.KHOA);

                //this.dSKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                //this.dSKHOATableAdapter.Fill(this.DS.DSKHOA);


                macs = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            }
        }
    }
}
