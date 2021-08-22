
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
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlCompaniesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlCompainesList)).BeginInit();
            this.grpControlCompainesList.SuspendLayout();
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
            // 
            // grpControlCompainesList
            // 
            this.grpControlCompainesList.Controls.Add(this.simpleButton4);
            this.grpControlCompainesList.Controls.Add(this.simpleButton3);
            this.grpControlCompainesList.Controls.Add(this.simpleButton2);
            this.grpControlCompainesList.Controls.Add(this.simpleButton1);
            this.grpControlCompainesList.Controls.Add(this.labelControl1);
            this.grpControlCompainesList.Location = new System.Drawing.Point(1, 400);
            this.grpControlCompainesList.Name = "grpControlCompainesList";
            this.grpControlCompainesList.Size = new System.Drawing.Size(1260, 110);
            this.grpControlCompainesList.TabIndex = 1;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(700, 43);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(160, 45);
            this.simpleButton4.TabIndex = 4;
            this.simpleButton4.Text = "Seçili Firmayı Güncelle";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(1000, 43);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(160, 45);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Firmaları Listele";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(400, 43);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(160, 45);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Seçili Firmayı Sil";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(100, 43);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(160, 45);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Yeni Firma Ekle";
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
            this.Load += new System.EventHandler(this.FrmCompaniesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdControlCompaniesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlCompainesList)).EndInit();
            this.grpControlCompainesList.ResumeLayout(false);
            this.grpControlCompainesList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlCompaniesList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpControlCompainesList;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}