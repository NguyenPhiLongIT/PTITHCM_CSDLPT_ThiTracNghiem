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
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.TN_CSDLPTDataSet.KHOA);
            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.TN_CSDLPTDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Fill(this.TN_CSDLPTDataSet.LOP);

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
    }
}
