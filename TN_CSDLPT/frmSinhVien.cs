using DevExpress.XtraEditors;
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
        private Boolean isAdd = false;
        private Boolean isEdit = false;
        private Stack<string> undoList = new Stack<string>();
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            cmbCoSo.DataSource = Program.bsDanhSachPhanManh;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";

            cmbCoSo.SelectedIndex = Program.mCoso;

            this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);

            this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);

            
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                btnThem.Visibility = btnHieuChinh.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnPhucHoi.Visibility
                       = btnReload.Visibility = btnDSSV.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //Truong thì login đó có thể đăng nhập vào bất kỳ phân mảnh  nào để xem dữ liệu 
            else if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                btnThem.Visibility = btnHieuChinh.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnPhucHoi.Visibility
                       = btnReload.Visibility = btnDSSV.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            if (undoList.Count == 0)
            {
                btnPhucHoi.Enabled = false;
            }

        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kiem tra cmbCoSo co du lieu chua
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbCoSo.SelectedValue.ToString();
            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.mLogin = Program.remoteLogin;
                Program.password = Program.remoteLoginPassword;
                Program.mCoso = cmbCoSo.SelectedIndex;

            }
            else
            {
                Program.mLogin = Program.mLoginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.ketNoi() == 0) return;
            else
            {
                this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.BANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);

                this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

                this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHOATableAdapter.Fill(this.DS.KHOA);

                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.DS.LOP);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsSV.AddNew();
                isAdd = true;
                dgvSV.Enabled = gcLop.Enabled = false;
                txtMaSV.Enabled = txtHoSV.Enabled = txtTenSV.Enabled = txtDiaChiSV.Enabled = dateNgaySinh.Enabled = true;
                txtMaSV.Focus();
                btnThem.Enabled = btnHieuChinh.Enabled = btnPhucHoi.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi thêm sinh viên " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count == 0)
            {
                XtraMessageBox.Show("Không có sinh viên để sửa!", "", MessageBoxButtons.OK);
            }
            else
            {
                isEdit = true;
                dgvSV.Enabled = gcLop.Enabled = true;
                txtMaSV.Enabled = false;
                txtHoSV.Enabled = txtTenSV.Enabled = txtDiaChiSV.Enabled = dateNgaySinh.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnPhucHoi.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count == 0)
            {
                XtraMessageBox.Show("Không có sinh viên để xóa!", "", MessageBoxButtons.OK);
            }
            else
            {
                if(bdsBangDiem.Count > 0)
                {
                    XtraMessageBox.Show("Sinh viên này đã có bảng điểm, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên: " + ((DataRowView)this.bdsSV.Current).Row["TEN"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string maSV = "";
                    try
                    {
                        string undo = string.Format("INSERT INTO DBO.SINHVIEN( MASV,TENSV)" +
                            "VALUES('{0}','{1}')", txtMaSV.Text.Trim(), txtTenSV.Text.Trim());
                        undoList.Push(undo);

                        maSV = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();

                        bdsSV.RemoveCurrent();
                        this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);

                        this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                        XtraMessageBox.Show("Xóa sinh viên thành công!", "", MessageBoxButtons.OK);
                    }
                    catch(Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa sinh viên " + ex.Message, "", MessageBoxButtons.OK);
                        this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                        bdsSV.Position = bdsSV.Find("MASV", maSV);
                        return;
                    }
                }
            }
        }
        private void writeToDB()
        {
            dgvSV.Enabled = gcLop.Enabled = true;
            txtHoSV.Enabled = txtTenSV.Enabled = txtDiaChiSV.Enabled = dateNgaySinh.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnXoa.Enabled = true;
            try
            {
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi ghi sinh viên" + ex.Message, "", MessageBoxButtons.OK);
            }
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdd)
            {
                String sql = "EXEC SP_KTSinhVienTonTai '" + txtMaSV.Text.Trim() + "'";
                try
                {
                    int kq = Program.execSqlNonQuery(sql);
                    if (kq == 1)
                    {
                        txtMaSV.Focus();
                        return;
                    }
                    else
                    {
                        string maSV = txtMaSV.Text.Trim();
                        //Lấy dữ liệu để cho vào xử lí hoàn tác
                        string str = "DELETE DBO.SINHVIEN WHERE MASV = '" + txtMaSV.Text.Trim() + "'";
                        undoList.Push(str);

                        writeToDB();
                        bdsSV.Position = bdsSV.Find("MASV", maSV);
                        isAdd = false;

                        XtraMessageBox.Show("Thêm sinh viên thành công!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    undoList.Pop();
                    //XtraMessageBox.Show("Thêm sinh viên thất bại " + ex.Message, "", MessageBoxButtons.OK);
                }
                finally
                {
                    Program.conn.Close();
                }
            }
            else if (isEdit)
            {

                string maSV = txtMaSV.Text.Trim();
                //lấy dữ liệu trước khi sửa
                string str = "UPDATE DBO.SINHVIEN " +
                                "SET " +
                                "TENSV = '" + txtTenSV.Text.Trim() + "' WHERE " +
                                "MASV = '" + txtMaSV.Text.Trim() + "', ";
                writeToDB();
                isEdit = false;
                bdsSV.Position = bdsSV.Find("MASV", maSV);


                XtraMessageBox.Show("Sửa sinh viên thành công!", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoList.Count == 0)
            {
                btnPhucHoi.Enabled = false;
                return;
            }
            try
            {
                if (isAdd)
                {
                    bdsSV.RemoveCurrent(); 
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    dgvSV.Enabled = true;
                    isAdd = false;
                    return;
                }

                bdsSV.CancelEdit();
                string str = undoList.Pop();
                MessageBox.Show(str);
                int result = Program.execSqlNonQuery(str);
                if (result == 0) MessageBox.Show("Lôi khi hoan tác");
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hoàn tác dữ liệu" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
