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
    public partial class frmKhoa : Form
    {
        string macs = "";
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.TN_CSDLPTDataSet);

        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            TN_CSDLPTDataSet.EnforceConstraints = false;
            //macs = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            cmbCoSo.DataSource = Program.bsDanhSachPhanManh;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";

            cmbCoSo.SelectedIndex = Program.mCoso;

            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);

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
