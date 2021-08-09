
namespace Otomasyon_V0.Forms
{
    partial class FrmTasksList
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
            this.grdControlTasksList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpControlTasksList = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlTasksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlTasksList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdControlTasksList
            // 
            this.grdControlTasksList.Location = new System.Drawing.Point(1, 10);
            this.grdControlTasksList.MainView = this.gridView1;
            this.grdControlTasksList.Name = "grdControlTasksList";
            this.grdControlTasksList.Size = new System.Drawing.Size(1000, 500);
            this.grdControlTasksList.TabIndex = 0;
            this.grdControlTasksList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdControlTasksList;
            this.gridView1.Name = "gridView1";
            // 
            // grpControlTasksList
            // 
            this.grpControlTasksList.Location = new System.Drawing.Point(1007, 12);
            this.grpControlTasksList.Name = "grpControlTasksList";
            this.grpControlTasksList.Size = new System.Drawing.Size(255, 500);
            this.grpControlTasksList.TabIndex = 1;
            // 
            // FrmTasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 511);
            this.Controls.Add(this.grpControlTasksList);
            this.Controls.Add(this.grdControlTasksList);
            this.Name = "FrmTasksList";
            this.Text = "Görev Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.grdControlTasksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlTasksList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlTasksList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpControlTasksList;
    }
}