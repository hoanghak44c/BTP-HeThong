using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using QLBH.Core.Form;
namespace QLBanHang.Modules.HeThong
{
    partial class frmHT_SessionDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHT_SessionDB));
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.grpKetQuaImport = new System.Windows.Forms.GroupBox();
            this.chkOnStby = new System.Windows.Forms.CheckBox();
            this.chkOnPos = new System.Windows.Forms.CheckBox();
            this.gtidButton1 = new QLBH.Core.Form.GtidButton();
            this.gDB = new DevExpress.XtraGrid.GridControl();
            this.gvDB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpKetQuaImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(862, 420);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(146, 40);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng (F12)";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grpKetQuaImport
            // 
            this.grpKetQuaImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKetQuaImport.Controls.Add(this.chkOnStby);
            this.grpKetQuaImport.Controls.Add(this.chkOnPos);
            this.grpKetQuaImport.Controls.Add(this.gtidButton1);
            this.grpKetQuaImport.Controls.Add(this.btnDong);
            this.grpKetQuaImport.Controls.Add(this.gDB);
            this.grpKetQuaImport.Controls.Add(this.txtSession);
            this.grpKetQuaImport.Controls.Add(this.label4);
            this.grpKetQuaImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQuaImport.ForeColor = System.Drawing.Color.Black;
            this.grpKetQuaImport.Location = new System.Drawing.Point(1, 12);
            this.grpKetQuaImport.Name = "grpKetQuaImport";
            this.grpKetQuaImport.Size = new System.Drawing.Size(1018, 467);
            this.grpKetQuaImport.TabIndex = 2;
            this.grpKetQuaImport.TabStop = false;
            this.grpKetQuaImport.Text = "Danh sách phiên làm việc";
            // 
            // chkOnStby
            // 
            this.chkOnStby.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkOnStby.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.chkOnStby.Location = new System.Drawing.Point(64, 436);
            this.chkOnStby.Name = "chkOnStby";
            this.chkOnStby.Size = new System.Drawing.Size(61, 20);
            this.chkOnStby.TabIndex = 138;
            this.chkOnStby.Text = "STBY";
            this.chkOnStby.UseVisualStyleBackColor = true;
            this.chkOnStby.CheckedChanged += new System.EventHandler(this.chkOnStby_CheckedChanged);
            // 
            // chkOnPos
            // 
            this.chkOnPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkOnPos.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.chkOnPos.Location = new System.Drawing.Point(6, 436);
            this.chkOnPos.Name = "chkOnPos";
            this.chkOnPos.Size = new System.Drawing.Size(52, 20);
            this.chkOnPos.TabIndex = 137;
            this.chkOnPos.Text = "POS";
            this.chkOnPos.UseVisualStyleBackColor = true;
            this.chkOnPos.CheckedChanged += new System.EventHandler(this.chkOnPos_CheckedChanged);
            // 
            // gtidButton1
            // 
            this.gtidButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gtidButton1.Location = new System.Drawing.Point(710, 421);
            this.gtidButton1.Name = "gtidButton1";
            this.gtidButton1.ShortCutKey = System.Windows.Forms.Keys.None;
            this.gtidButton1.Size = new System.Drawing.Size(146, 40);
            this.gtidButton1.TabIndex = 135;
            this.gtidButton1.Text = "Tạm dừng";
            this.gtidButton1.Click += new System.EventHandler(this.gtidButton1_Click);
            // 
            // gDB
            // 
            this.gDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gDB.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gDB.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gDB.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gDB.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gDB.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gDB.EmbeddedNavigator.TextStringFormat = "{0} / Tổng số {1}";
            this.gDB.Location = new System.Drawing.Point(6, 26);
            this.gDB.MainView = this.gvDB;
            this.gDB.Name = "gDB";
            this.gDB.Size = new System.Drawing.Size(1002, 388);
            this.gDB.TabIndex = 2;
            this.gDB.UseEmbeddedNavigator = true;
            this.gDB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDB});
            // 
            // gvDB
            // 
            this.gvDB.GridControl = this.gDB;
            this.gvDB.Name = "gvDB";
            this.gvDB.OptionsBehavior.SmartVertScrollBar = false;
            this.gvDB.OptionsSelection.UseIndicatorForSelection = false;
            this.gvDB.OptionsView.ColumnAutoWidth = false;
            this.gvDB.OptionsView.ShowAutoFilterRow = true;
            this.gvDB.OptionsView.ShowGroupPanel = false;
            this.gvDB.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDB_FocusedRowChanged);
            this.gvDB.TopRowChanged += new System.EventHandler(this.gvDB_TopRowChanged);
            this.gvDB.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDB_RowClick);
            this.gvDB.DoubleClick += new System.EventHandler(this.gvDB_DoubleClick);
            this.gvDB.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvDB_RowCellClick);
            // 
            // txtSession
            // 
            this.txtSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSession.Location = new System.Drawing.Point(895, 0);
            this.txtSession.Name = "txtSession";
            this.txtSession.ReadOnly = true;
            this.txtSession.Size = new System.Drawing.Size(112, 22);
            this.txtSession.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(756, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 134;
            this.label4.Text = "Số lượng session Database";
            // 
            // frmHT_SessionDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 481);
            this.Controls.Add(this.grpKetQuaImport);
            this.KeyPreview = true;
            this.Name = "frmHT_SessionDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê phiên làm việc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBH_TimChungTu_Load);
            this.Activated += new System.EventHandler(this.frmHT_SessionDB_Activated);
            this.Leave += new System.EventHandler(this.frmHT_SessionDB_Leave);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHT_SessionDB_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBH_TimChungTu_KeyDown);
            this.grpKetQuaImport.ResumeLayout(false);
            this.grpKetQuaImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal GtidButton btnDong;
        private System.Windows.Forms.GroupBox grpKetQuaImport;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label label4;
        private GridControl gDB;
        private GridView gvDB;
        private GtidButton gtidButton1;
        private System.Windows.Forms.CheckBox chkOnStby;
        private System.Windows.Forms.CheckBox chkOnPos;
    }
}