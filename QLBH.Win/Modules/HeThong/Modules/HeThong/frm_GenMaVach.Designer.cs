using QLBH.Core.Form;
namespace QLBanHang.Modules.HeThong
{
    partial class frm_GenMaVach
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GenMaVach));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsPrint = new System.Windows.Forms.ToolStripButton();
            this.tlsClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaVach1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVach2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVach3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVach4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVach5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVach6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsPrint,
            this.tlsClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(941, 25);
            this.toolStrip1.TabIndex = 63;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsPrint
            // 
            this.tlsPrint.Image = ((System.Drawing.Image)(resources.GetObject("tlsPrint.Image")));
            this.tlsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsPrint.Name = "tlsPrint";
            this.tlsPrint.Size = new System.Drawing.Size(86, 22);
            this.tlsPrint.Text = "Export (F2)";
            this.tlsPrint.Click += new System.EventHandler(this.tlsPrint_Click);
            // 
            // tlsClose
            // 
            this.tlsClose.Image = ((System.Drawing.Image)(resources.GetObject("tlsClose.Image")));
            this.tlsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsClose.Name = "tlsClose";
            this.tlsClose.Size = new System.Drawing.Size(90, 22);
            this.tlsClose.Text = "Thoát (F12)";
            this.tlsClose.Click += new System.EventHandler(this.tlsClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.gSanPham);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(941, 455);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách mã vạch";
            // 
            // gSanPham
            // 
            this.gSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gSanPham.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gSanPham.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gSanPham.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gSanPham.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gSanPham.EmbeddedNavigator.TextStringFormat = "{0} / {1}";
            this.gSanPham.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gSanPham.Location = new System.Drawing.Point(6, 22);
            this.gSanPham.MainView = this.gvSanPham;
            this.gSanPham.Name = "gSanPham";
            this.gSanPham.Size = new System.Drawing.Size(929, 426);
            this.gSanPham.TabIndex = 139;
            this.gSanPham.UseEmbeddedNavigator = true;
            this.gSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham,
            this.gridView2});
            // 
            // gvSanPham
            // 
            this.gvSanPham.ColumnPanelRowHeight = 25;
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaVach1,
            this.MaVach2,
            this.MaVach3,
            this.MaVach4,
            this.MaVach5,
            this.MaVach6});
            this.gvSanPham.GridControl = this.gSanPham;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsView.ShowAutoFilterRow = true;
            this.gvSanPham.OptionsView.ShowDetailButtons = false;
            this.gvSanPham.OptionsView.ShowGroupPanel = false;
            // 
            // MaVach1
            // 
            this.MaVach1.Caption = "1";
            this.MaVach1.FieldName = "MaVach1";
            this.MaVach1.Name = "MaVach1";
            this.MaVach1.Visible = true;
            this.MaVach1.VisibleIndex = 0;
            this.MaVach1.Width = 186;
            // 
            // MaVach2
            // 
            this.MaVach2.Caption = "2";
            this.MaVach2.FieldName = "MaVach2";
            this.MaVach2.Name = "MaVach2";
            this.MaVach2.Visible = true;
            this.MaVach2.VisibleIndex = 1;
            this.MaVach2.Width = 199;
            // 
            // MaVach3
            // 
            this.MaVach3.Caption = "3";
            this.MaVach3.FieldName = "MaVach3";
            this.MaVach3.Name = "MaVach3";
            this.MaVach3.Visible = true;
            this.MaVach3.VisibleIndex = 2;
            this.MaVach3.Width = 182;
            // 
            // MaVach4
            // 
            this.MaVach4.Caption = "4";
            this.MaVach4.FieldName = "MaVach4";
            this.MaVach4.Name = "MaVach4";
            this.MaVach4.Visible = true;
            this.MaVach4.VisibleIndex = 3;
            this.MaVach4.Width = 163;
            // 
            // MaVach5
            // 
            this.MaVach5.Caption = "5";
            this.MaVach5.FieldName = "MaVach5";
            this.MaVach5.Name = "MaVach5";
            this.MaVach5.Visible = true;
            this.MaVach5.VisibleIndex = 4;
            this.MaVach5.Width = 163;
            // 
            // MaVach6
            // 
            this.MaVach6.Caption = "6";
            this.MaVach6.FieldName = "MaVach6";
            this.MaVach6.Name = "MaVach6";
            this.MaVach6.Visible = true;
            this.MaVach6.VisibleIndex = 5;
            this.MaVach6.Width = 181;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gSanPham;
            this.gridView2.Name = "gridView2";
            // 
            // frm_GenMaVach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 484);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frm_GenMaVach";
            this.Text = "Export mã vạch sản phẩm";
            this.Load += new System.EventHandler(this.frm_BangGiaHienTai_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsPrint;
        private System.Windows.Forms.ToolStripButton tlsClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn MaVach1;
        private DevExpress.XtraGrid.Columns.GridColumn MaVach2;
        private DevExpress.XtraGrid.Columns.GridColumn MaVach3;
        private DevExpress.XtraGrid.Columns.GridColumn MaVach4;
        private DevExpress.XtraGrid.Columns.GridColumn MaVach5;
        private DevExpress.XtraGrid.Columns.GridColumn MaVach6;

    }
}