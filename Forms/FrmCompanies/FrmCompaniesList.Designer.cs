
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
            this.grdControlCompaniesList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpControlCompainesList = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlCompaniesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlCompainesList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdControlCompaniesList
            // 
            this.grdControlCompaniesList.Location = new System.Drawing.Point(1, 10);
            this.grdControlCompaniesList.MainView = this.gridView1;
            this.grdControlCompaniesList.Name = "grdControlCompaniesList";
            this.grdControlCompaniesList.Size = new System.Drawing.Size(1000, 500);
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
            this.grpControlCompainesList.Location = new System.Drawing.Point(1007, 12);
            this.grpControlCompainesList.Name = "grpControlCompainesList";
            this.grpControlCompainesList.Size = new System.Drawing.Size(255, 500);
            this.grpControlCompainesList.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlCompaniesList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpControlCompainesList;
    }
}