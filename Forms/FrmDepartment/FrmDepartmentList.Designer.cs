
namespace Otomasyon_V0.Forms
{
    partial class FrmDepartmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartmentList));
            this.grdControlDepartmentList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpControlDepartmentList = new DevExpress.XtraEditors.GroupControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDeleted = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnList = new DevExpress.XtraEditors.SimpleButton();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlDepartmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlDepartmentList)).BeginInit();
            this.grpControlDepartmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdControlDepartmentList
            // 
            this.grdControlDepartmentList.Location = new System.Drawing.Point(1, 10);
            this.grdControlDepartmentList.MainView = this.gridView1;
            this.grdControlDepartmentList.Name = "grdControlDepartmentList";
            this.grdControlDepartmentList.Size = new System.Drawing.Size(1000, 500);
            this.grdControlDepartmentList.TabIndex = 4;
            this.grdControlDepartmentList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdControlDepartmentList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grpControlDepartmentList
            // 
            this.grpControlDepartmentList.Controls.Add(this.BtnUpdate);
            this.grpControlDepartmentList.Controls.Add(this.BtnDeleted);
            this.grpControlDepartmentList.Controls.Add(this.BtnAdd);
            this.grpControlDepartmentList.Controls.Add(this.BtnList);
            this.grpControlDepartmentList.Controls.Add(this.TxtAd);
            this.grpControlDepartmentList.Controls.Add(this.TxtID);
            this.grpControlDepartmentList.Controls.Add(this.labelControl2);
            this.grpControlDepartmentList.Controls.Add(this.labelControl1);
            this.grpControlDepartmentList.Location = new System.Drawing.Point(1007, 12);
            this.grpControlDepartmentList.Name = "grpControlDepartmentList";
            this.grpControlDepartmentList.Size = new System.Drawing.Size(255, 500);
            this.grpControlDepartmentList.TabIndex = 5;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(74, 319);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(150, 40);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDeleted
            // 
            this.BtnDeleted.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleted.ImageOptions.Image")));
            this.BtnDeleted.Location = new System.Drawing.Point(74, 260);
            this.BtnDeleted.Name = "BtnDeleted";
            this.BtnDeleted.Size = new System.Drawing.Size(150, 40);
            this.BtnDeleted.TabIndex = 6;
            this.BtnDeleted.Text = "Sil";
            this.BtnDeleted.Click += new System.EventHandler(this.BtnDeleted_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(74, 201);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(150, 40);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnList
            // 
            this.BtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnList.ImageOptions.Image")));
            this.BtnList.Location = new System.Drawing.Point(74, 146);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(150, 40);
            this.BtnList.TabIndex = 4;
            this.BtnList.Text = "Listele";
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(74, 103);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(150, 20);
            this.TxtAd.TabIndex = 3;
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(74, 55);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(150, 20);
            this.TxtID.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ad:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // FrmDepartmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 511);
            this.Controls.Add(this.grpControlDepartmentList);
            this.Controls.Add(this.grdControlDepartmentList);
            this.Name = "FrmDepartmentList";
            this.Text = "Departman Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.grdControlDepartmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlDepartmentList)).EndInit();
            this.grpControlDepartmentList.ResumeLayout(false);
            this.grpControlDepartmentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlDepartmentList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpControlDepartmentList;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnDeleted;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnList;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}