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
        int currentPos = 0; //vị trí con trỏ đang đứng trên gridview

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
            //Không kiểm tra khóa ngoại nữa
            DS.EnforceConstraints = false;

            cmbCoSo.DataSource = Program.bsDanhSachPhanManh;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            this.BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);

            this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);

            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);

            //CO SO & GIANGVIEN co the xem - xoa - sua du lieu nhung khong the chuyen sang chi nhanh khac
            if (Program.mGroup == "COSO" || Program.mGroup == "GIANGVIEN")
            {
                cmbCoSo.Enabled = false;
                btnThem.Visibility = btnHieuChinh.Visibility = btnGhi.Visibility = btnXoa.Visibility = btnPhucHoi.Visibility
                       = btnReload.Visibility = btnDSSV.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //TRUONG thì login đó có thể đăng nhập vào bất kỳ phân mảnh nào để xem dữ liệu 
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
                //Program.mCoso = cmbCoSo.SelectedIndex;

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
                currentPos = bdsSV.Position;   //lấy vị trí hiện tại của con trỏ
                isAdd = true;
                bdsSV.AddNew(); //tự động thêm 1 dòng mới 
                dgvSV.Enabled = gcLop.Enabled = false;
                txtMaSV.Enabled = txtHoSV.Enabled = txtTenSV.Enabled = txtDiaChiSV.Enabled = dateNgaySinh.Enabled = true;
                txtMaLop.Enabled = txtTenLop.Enabled = txtTenKhoa.Enabled = false;
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
                XtraMessageBox.Show("Không có sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                isEdit = true;
                dgvSV.Enabled = gcLop.Enabled = true;
                txtMaSV.Enabled = txtMaLop.Enabled = txtTenLop.Enabled = txtTenKhoa.Enabled = false;
                txtHoSV.Enabled = txtTenSV.Enabled = txtDiaChiSV.Enabled = dateNgaySinh.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnPhucHoi.Enabled = btnReload.Enabled = btnXoa.Enabled = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            else
            {
                if(bdsBangDiem.Count > 0)
                {
                    XtraMessageBox.Show("Sinh viên này đã có bảng điểm, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên: " + ((DataRowView)this.bdsSV.Current).Row["TEN"].ToString() + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string maSV = "";
                    DateTime NGAYSINH = (DateTime)((DataRowView)bdsSV[bdsSV.Position])["NGAYSINH"];
                    try
                    {
                        string strPhucHoi = string.Format("INSERT INTO DBO.SINHVIEN( MASV,HO,TEN,NGAYSINH,DIACHI,MALOP)" +
                            "VALUES('{0}','{1}','{2}',CAST({3} AS DATETIME),'{4}','{5}')", txtMaSV.Text.Trim(), txtHoSV.Text.Trim(), txtTenSV.Text.Trim(), NGAYSINH.ToString("yyyy-MM-dd"), txtDiaChiSV.Text.Trim(), txtMaLop.Text.Trim());
                        undoList.Push(strPhucHoi);

                        maSV = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
                        currentPos = bdsSV.Position;
                        bdsSV.RemoveCurrent();

                        this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                        this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

                        XtraMessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                        this.btnPhucHoi.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa sinh viên " + ex.Message, "", MessageBoxButtons.OK);
                        this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                        bdsSV.Position = currentPos;
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
            //Lấy dữ liệu trước khi chọn btnGhi, phục vụ btnPhucHoi
            String maSV = txtMaSV.Text.Trim();
            DataRowView drv = ((DataRowView)bdsSV[bdsSV.Position]);
            String ho = drv["HO"].ToString();
            String ten = drv["TEN"].ToString();
            String diaChi = drv["DIACHI"].ToString();
            DateTime ngaySinh = ((DateTime)drv["NGAYSINH"]);

            try 
            {
                string strPhucHoi = "";
                btnPhucHoi.Enabled = true;
                if (isAdd)
                {
                    String sql = "EXEC SP_KTSinhVienTonTai '" + txtMaSV.Text.Trim() + "'";
                    int kq = Program.execSqlNonQuery(sql);
                    if (kq == 1)    //Kiểm tra MASV đã tồn tại
                    {
                        txtMaSV.Focus();
                        return;
                    }
                    else
                    {
                        //Lấy dữ liệu để cho vào xử lí hoàn tác
                        strPhucHoi = "DELETE DBO.SINHVIEN WHERE MASV = '" + txtMaSV.Text.Trim() + "'";
                        isAdd = false;
                    }
                }
                else if (isEdit)
                {
                    //lấy dữ liệu trước khi sửa
                    strPhucHoi = "UPDATE DBO.SINHVIEN " +
                                    "SET " +
                                    "HO = '" + ho + "'," +
                                    "TEN = '" + ten + "'," +
                                    "DIACHI = '" + diaChi + "'," +
                                    "NGAYSINH = CAST('" + ngaySinh.ToString("yyyy-MM-dd") + "' AS DATETIME)," +
                                    "WHERE MASV = '" + maSV + "'";
                    isEdit = false;
                }

                XtraMessageBox.Show("Ghi thành công!", "Thông báo", MessageBoxButtons.OK);
                undoList.Push(strPhucHoi);
                writeToDB();
                bdsSV.Position = bdsSV.Find("MASV", maSV);

                return;
            }
            catch (Exception ex)
            {
                undoList.Pop();
                //XtraMessageBox.Show("Ghi thất bại " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnPhucHoi.Enabled = false;
                return;
            }
            try
            {
                if (isAdd)
                {
                    isAdd = false;

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    dgvSV.Enabled = true;

                    bdsSV.CancelEdit();
                    bdsSV.RemoveCurrent();
                    bdsSV.Position = currentPos;
                    return;
                }

                bdsSV.CancelEdit();
                string strPhucHoi = undoList.Pop().ToString();
                MessageBox.Show(strPhucHoi);

                if (Program.ketNoi() == 0)
                {
                    return;
                }
                int result = Program.execSqlNonQuery(strPhucHoi);
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hoàn tác dữ liệu" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi tải lại :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdd)
            {
                if (XtraMessageBox.Show("Bạn đang tạo mới sinh viên, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }

            }
            else if (isEdit)
            {
                if (XtraMessageBox.Show("Bạn đang sửa sinh viên, bạn có muốn ghi thông tin này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGhi_ItemClick(sender, e);
                }

            }

            this.Close();
        }

        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
