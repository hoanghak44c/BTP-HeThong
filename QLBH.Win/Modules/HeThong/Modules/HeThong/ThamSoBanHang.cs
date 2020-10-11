using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Core.Data;
//using QLBanHang.Class;

namespace QLBanHang.Modules.HeThong
{
    public partial class ThamSoBanHang : DevExpress.XtraEditors.XtraForm
    {
        public ThamSoBanHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            LoadThongTin();            
        }
        private void LoadThongTin()
        {
            txtlstnotinhoadon.Text = Declare.LstNotInHoaDon;
            txtlstsuagiaban.Text = Declare.LstSuaGiaBan;
            txtlstsuackhaukolenodt.Text = Declare.LstSuaCKhauKoLenODT;
            txtlstsuackhaukolenod.Text = Declare.LstSuaCKhauKoLenOD;
            txtlstkmduocbanod.Text = Declare.LstKMDuocBanOD;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "Delete From tbl_thamso_banhang";
            if (DBTools.ExecuteQuery(sql, CommandType.Text) != null)
            {
                sql = "Insert Into tbl_thamso_banhang(lstnotinhoadon, lstsuagiaban, lstsuackhaukolenodt, lstsuackhaukolenod, lstkmduocbanod) Values(N'" +
                        txtlstnotinhoadon.Text + "', N'" + txtlstsuagiaban.Text + "', N'" + txtlstsuackhaukolenodt.Text + "', N'" +
                        txtlstsuackhaukolenod.Text + "', N'" + txtlstkmduocbanod.Text + "') ";
                if (DBTools.ExecuteQuery(sql, CommandType.Text) != null)
                {
                    Declare.LstNotInHoaDon = txtlstnotinhoadon.Text;
                    Declare.LstSuaGiaBan = txtlstsuagiaban.Text;
                    Declare.LstSuaCKhauKoLenODT = txtlstsuackhaukolenodt.Text;
                    Declare.LstSuaCKhauKoLenOD = txtlstsuackhaukolenod.Text;
                    Declare.LstKMDuocBanOD = txtlstkmduocbanod.Text;
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Declare.msgUpdateErr, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}