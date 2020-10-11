using System;
using System.Windows.Forms;
using QLBH.Common;

namespace QLBanHang.Modules.HeThong
{
    public partial class frmGioiThieu : Form
    {
        public frmGioiThieu()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}