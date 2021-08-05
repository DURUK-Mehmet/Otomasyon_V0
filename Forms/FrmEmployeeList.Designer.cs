
namespace Otomasyon_V0.Forms
{
    partial class FrmEmployeeList
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
            this.grdControlEmployeeList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpControlEmployeeList = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdControlEmployeeList
            // 
            this.grdControlEmployeeList.Location = new System.Drawing.Point(1, 10);
            this.grdControlEmployeeList.MainView = this.gridView1;
            this.grdControlEmployeeList.Name = "grdControlEmployeeList";
            this.grdControlEmployeeList.Size = new System.Drawing.Size(1000, 500);
            this.grdControlEmployeeList.TabIndex = 0;
            this.grdControlEmployeeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdControlEmployeeList;
            this.gridView1.Name = "gridView1";
            // 
            // grpControlEmployeeList
            // 
            this.grpControlEmployeeList.Location = new System.Drawing.Point(1007, 12);
            this.grpControlEmployeeList.Name = "grpControlEmployeeList";
            this.grpControlEmployeeList.Size = new System.Drawing.Size(255, 500);
            this.grpControlEmployeeList.TabIndex = 1;
            // 
            // FrmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 511);
            this.Controls.Add(this.grpControlEmployeeList);
            this.Controls.Add(this.grdControlEmployeeList);
            this.Name = "FrmEmployeeList";
            this.Text = "Personel Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.grdControlEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlEmployeeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpControlEmployeeList;
    }
}