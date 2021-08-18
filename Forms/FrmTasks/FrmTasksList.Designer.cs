
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
            this.pnlControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pnlControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pnlControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlTasksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // grdControlTasksList
            // 
            this.grdControlTasksList.Location = new System.Drawing.Point(1, 10);
            this.grdControlTasksList.MainView = this.gridView1;
            this.grdControlTasksList.Name = "grdControlTasksList";
            this.grdControlTasksList.Size = new System.Drawing.Size(496, 490);
            this.grdControlTasksList.TabIndex = 0;
            this.grdControlTasksList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdControlTasksList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // pnlControl1
            // 
            this.pnlControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.pnlControl1.Appearance.Options.UseBackColor = true;
            this.pnlControl1.Location = new System.Drawing.Point(505, 15);
            this.pnlControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlControl1.Name = "pnlControl1";
            this.pnlControl1.Size = new System.Drawing.Size(230, 150);
            this.pnlControl1.TabIndex = 1;
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(505, 180);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(750, 320);
            this.chartControl1.TabIndex = 2;
            // 
            // pnlControl2
            // 
            this.pnlControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(102)))), ((int)(((byte)(69)))));
            this.pnlControl2.Appearance.Options.UseBackColor = true;
            this.pnlControl2.Location = new System.Drawing.Point(765, 15);
            this.pnlControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlControl2.Name = "pnlControl2";
            this.pnlControl2.Size = new System.Drawing.Size(230, 150);
            this.pnlControl2.TabIndex = 3;
            // 
            // pnlControl3
            // 
            this.pnlControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(74)))), ((int)(((byte)(89)))));
            this.pnlControl3.Appearance.Options.UseBackColor = true;
            this.pnlControl3.Location = new System.Drawing.Point(1025, 15);
            this.pnlControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlControl3.Name = "pnlControl3";
            this.pnlControl3.Size = new System.Drawing.Size(230, 150);
            this.pnlControl3.TabIndex = 2;
            // 
            // FrmTasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 511);
            this.Controls.Add(this.pnlControl3);
            this.Controls.Add(this.pnlControl2);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.pnlControl1);
            this.Controls.Add(this.grdControlTasksList);
            this.Name = "FrmTasksList";
            this.Text = "Görev Listesi";
            this.Load += new System.EventHandler(this.FrmTasksList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdControlTasksList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlTasksList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pnlControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.PanelControl pnlControl2;
        private DevExpress.XtraEditors.PanelControl pnlControl3;
    }
}