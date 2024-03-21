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
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPTDataSet);

        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {

            TN_CSDLPTDataSet.EnforceConstraints = false; //khong bat buoc kiem tra dieu kien khoa ngoai

            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN);

            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.TN_CSDLPTDataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.TN_CSDLPTDataSet.BODE);
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.DSKHOA' table. You can move, or remove it, as needed.
            this.dSKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSKHOATableAdapter.Fill(this.TN_CSDLPTDataSet.DSKHOA);

            macs = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            cmbCoSo.DataSource = Program.bsDanhSachPhanManh;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true; //Bat tat cho phep chuyen co so
            }
            else
            {
                cmbCoSo.Enabled = false;
            }

        }

        private void tENKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENKHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMAKH.Text = cmbDSKhoa.SelectedValue.ToString();
            } catch (Exception ex) { }
        }
    }
}
