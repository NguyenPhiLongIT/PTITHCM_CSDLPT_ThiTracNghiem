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
    public partial class frmNhapDe : Form
    {
        public frmNhapDe()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhapDe_Load(object sender, EventArgs e)
        {
            
            DS.EnforceConstraints = false; //khong bat buoc kiem tra dieu kien khoa ngoai
            this.CTBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTBAITHITableAdapter.Fill(this.DS.CTBAITHI);

            this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.BODETableAdapter.Fill(this.DS.BODE);

            // TODO: This line of code loads data into the 'DS.DSMONHOC' table. You can move, or remove it, as needed.
            this.dSMONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSMONHOCTableAdapter.Fill(this.DS.DSMONHOC);

            // TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bLabel_Click(object sender, EventArgs e)
        {

        }

        private void mAMHLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mAMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
