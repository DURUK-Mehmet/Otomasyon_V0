
namespace Otomasyon_V0.Forms
{
    partial class FrmCompaniesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompaniesList));
            this.grdControlCompaniesList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpControlCompainesList = new DevExpress.XtraEditors.GroupControl();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.BtnCompanieUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCompanieList = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCompanieDelet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCompanieAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlCompaniesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlCompainesList)).BeginInit();
            this.grpControlCompainesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdControlCompaniesList
            // 
            this.grdControlCompaniesList.Location = new System.Drawing.Point(1, 10);
            this.grdControlCompaniesList.MainView = this.gridView1;
            this.grdControlCompaniesList.Name = "grdControlCompaniesList";
            this.grdControlCompaniesList.Size = new System.Drawing.Size(1260, 385);
            this.grdControlCompaniesList.TabIndex = 0;
            this.grdControlCompaniesList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdControlCompaniesList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grpControlCompainesList
            // 
            this.grpControlCompainesList.Controls.Add(this.TxtID);
            this.grpControlCompainesList.Controls.Add(this.BtnCompanieUpdate);
            this.grpControlCompainesList.Controls.Add(this.BtnCompanieList);
            this.grpControlCompainesList.Controls.Add(this.BtnCompanieDelet);
            this.grpControlCompainesList.Controls.Add(this.BtnCompanieAdd);
            this.grpControlCompainesList.Controls.Add(this.labelControl1);
            this.grpControlCompainesList.Location = new System.Drawing.Point(1, 401);
            this.grpControlCompainesList.Name = "grpControlCompainesList";
            this.grpControlCompainesList.Size = new System.Drawing.Size(1260, 110);
            this.grpControlCompainesList.TabIndex = 1;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(0, 56);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(45, 20);
            this.TxtID.TabIndex = 2;
            this.TxtID.Visible = false;
            // 
            // BtnCompanieUpdate
            // 
            this.BtnCompanieUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCompanieUpdate.ImageOptions.Image")));
            this.BtnCompanieUpdate.Location = new System.Drawing.Point(700, 43);
            this.BtnCompanieUpdate.Name = "BtnCompanieUpdate";
            this.BtnCompanieUpdate.Size = new System.Drawing.Size(160, 45);
            this.BtnCompanieUpdate.TabIndex = 4;
            this.BtnCompanieUpdate.Text = "Seçili Firmayı Güncelle";
            this.BtnCompanieUpdate.Click += new System.EventHandler(this.BtnCompanieUpdate_Click);
            // 
            // BtnCompanieList
            // 
            this.BtnCompanieList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCompanieList.ImageOptions.Image")));
            this.BtnCompanieList.Location = new System.Drawing.Point(1000, 43);
            this.BtnCompanieList.Name = "BtnCompanieList";
            this.BtnCompanieList.Size = new System.Drawing.Size(160, 45);
            this.BtnCompanieList.TabIndex = 3;
            this.BtnCompanieList.Text = "Firmaları Listele";
            this.BtnCompanieList.Click += new System.EventHandler(this.BtnCompanieList_Click);
            // 
            // BtnCompanieDelet
            // 
            this.BtnCompanieDelet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCompanieDelet.ImageOptions.Image")));
            this.BtnCompanieDelet.Location = new System.Drawing.Point(400, 43);
            this.BtnCompanieDelet.Name = "BtnCompanieDelet";
            this.BtnCompanieDelet.Size = new System.Drawing.Size(160, 45);
            this.BtnCompanieDelet.TabIndex = 2;
            this.BtnCompanieDelet.Text = "Seçili Firmayı Sil";
            this.BtnCompanieDelet.Click += new System.EventHandler(this.BtnCompanieDelet_Click);
            // 
            // BtnCompanieAdd
            // 
            this.BtnCompanieAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCompanieAdd.ImageOptions.Image")));
            this.BtnCompanieAdd.Location = new System.Drawing.Point(100, 43);
            this.BtnCompanieAdd.Name = "BtnCompanieAdd";
            this.BtnCompanieAdd.Size = new System.Drawing.Size(160, 45);
            this.BtnCompanieAdd.TabIndex = 1;
            this.BtnCompanieAdd.Text = "Yeni Firma Ekle";
            this.BtnCompanieAdd.Click += new System.EventHandler(this.BtnCompanieAdd_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(591, 1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Firma İşlemleri";
            // 
            // FrmCompaniesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 511);
            this.Controls.Add(this.grpControlCompainesList);
            this.Controls.Add(this.grdControlCompaniesList);
            this.Name = "FrmCompaniesList";
            this.Text = "Firmalar Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.grdControlCompaniesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlCompainesList)).EndInit();
            this.grpControlCompainesList.ResumeLayout(false);
            this.grpControlCompainesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlCompaniesList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpControlCompainesList;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnCompanieUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnCompanieList;
        private DevExpress.XtraEditors.SimpleButton BtnCompanieDelet;
        private DevExpress.XtraEditors.SimpleButton BtnCompanieAdd;
        private DevExpress.XtraEditors.TextEdit TxtID;
    }
}