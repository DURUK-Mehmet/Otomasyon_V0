
namespace Otomasyon_V0.Forms.FrmHome
{
    partial class FrmHomePage
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
            this.grdControlHome1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdControlHome2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grdControlHome3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlHome1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlHome2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlHome3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // grdControlHome1
            // 
            this.grdControlHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdControlHome1.Location = new System.Drawing.Point(2, 23);
            this.grdControlHome1.MainView = this.gridView1;
            this.grdControlHome1.Name = "grdControlHome1";
            this.grdControlHome1.Size = new System.Drawing.Size(596, 485);
            this.grdControlHome1.TabIndex = 0;
            this.grdControlHome1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdControlHome1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grdControlHome2
            // 
            this.grdControlHome2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdControlHome2.Location = new System.Drawing.Point(2, 23);
            this.grdControlHome2.MainView = this.gridView2;
            this.grdControlHome2.Name = "grdControlHome2";
            this.grdControlHome2.Size = new System.Drawing.Size(646, 225);
            this.grdControlHome2.TabIndex = 1;
            this.grdControlHome2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdControlHome2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grdControlHome1);
            this.groupControl1.Location = new System.Drawing.Point(1, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(600, 510);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Devam Eden Görevler";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grdControlHome2);
            this.groupControl2.Location = new System.Drawing.Point(605, 1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(650, 250);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Bugün Yapılacaklar Görevler";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.grdControlHome3);
            this.groupControl3.Location = new System.Drawing.Point(605, 255);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(650, 250);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Geçmiş Görevler";
            // 
            // grdControlHome3
            // 
            this.grdControlHome3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdControlHome3.Location = new System.Drawing.Point(2, 23);
            this.grdControlHome3.MainView = this.gridView3;
            this.grdControlHome3.Name = "grdControlHome3";
            this.grdControlHome3.Size = new System.Drawing.Size(646, 225);
            this.grdControlHome3.TabIndex = 1;
            this.grdControlHome3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grdControlHome3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 511);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmHomePage";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdControlHome1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlHome2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdControlHome3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlHome1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdControlHome2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl grdControlHome3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}