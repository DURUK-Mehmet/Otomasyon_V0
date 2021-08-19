
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            this.grdControlTasksList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pnlControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pnlControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LblTotalDepartment = new DevExpress.XtraEditors.LabelControl();
            this.LblActiveTask = new DevExpress.XtraEditors.LabelControl();
            this.LblPasiveTask = new DevExpress.XtraEditors.LabelControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlTasksList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl1)).BeginInit();
            this.pnlControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl2)).BeginInit();
            this.pnlControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl3)).BeginInit();
            this.pnlControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
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
            this.pnlControl1.Controls.Add(this.LblTotalDepartment);
            this.pnlControl1.Controls.Add(this.labelControl1);
            this.pnlControl1.Location = new System.Drawing.Point(505, 15);
            this.pnlControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlControl1.Name = "pnlControl1";
            this.pnlControl1.Size = new System.Drawing.Size(230, 150);
            this.pnlControl1.TabIndex = 1;
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Light";
            this.chartControl1.AutoLayout = false;
            this.chartControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            simpleDiagram3D1.RotationMatrixSerializable = "-0.483887861560723;-0.625385784919877;0.612164322265155;0;0.875123272014025;-0.34" +
    "8538815974184;0.335678346842339;0;0.00343456164333268;0.698149922136702;0.715943" +
    "356702791;0;0;0;0;1";
            simpleDiagram3D1.RuntimeRotation = true;
            this.chartControl1.Diagram = simpleDiagram3D1;
            this.chartControl1.Legend.MarkerSize = new System.Drawing.Size(20, 20);
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(505, 180);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "PieDepartment";
            series1.View = pie3DSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(441, 320);
            this.chartControl1.TabIndex = 2;
            // 
            // pnlControl2
            // 
            this.pnlControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(102)))), ((int)(((byte)(69)))));
            this.pnlControl2.Appearance.Options.UseBackColor = true;
            this.pnlControl2.Controls.Add(this.LblActiveTask);
            this.pnlControl2.Controls.Add(this.labelControl2);
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
            this.pnlControl3.Controls.Add(this.LblPasiveTask);
            this.pnlControl3.Controls.Add(this.labelControl3);
            this.pnlControl3.Location = new System.Drawing.Point(1025, 15);
            this.pnlControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pnlControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlControl3.Name = "pnlControl3";
            this.pnlControl3.Size = new System.Drawing.Size(230, 150);
            this.pnlControl3.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Toplam Departman";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(56, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Aktif Görev Sayısı";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(51, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(125, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Pasif Görev Sayısı";
            // 
            // LblTotalDepartment
            // 
            this.LblTotalDepartment.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalDepartment.Appearance.Options.UseFont = true;
            this.LblTotalDepartment.Location = new System.Drawing.Point(110, 65);
            this.LblTotalDepartment.Name = "LblTotalDepartment";
            this.LblTotalDepartment.Size = new System.Drawing.Size(15, 33);
            this.LblTotalDepartment.TabIndex = 1;
            this.LblTotalDepartment.Text = "0";
            // 
            // LblActiveTask
            // 
            this.LblActiveTask.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblActiveTask.Appearance.Options.UseFont = true;
            this.LblActiveTask.Location = new System.Drawing.Point(110, 65);
            this.LblActiveTask.Name = "LblActiveTask";
            this.LblActiveTask.Size = new System.Drawing.Size(15, 33);
            this.LblActiveTask.TabIndex = 2;
            this.LblActiveTask.Text = "0";
            // 
            // LblPasiveTask
            // 
            this.LblPasiveTask.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPasiveTask.Appearance.Options.UseFont = true;
            this.LblPasiveTask.Location = new System.Drawing.Point(110, 65);
            this.LblPasiveTask.Name = "LblPasiveTask";
            this.LblPasiveTask.Size = new System.Drawing.Size(15, 33);
            this.LblPasiveTask.TabIndex = 2;
            this.LblPasiveTask.Text = "0";
            // 
            // chartControl2
            // 
            this.chartControl2.AppearanceNameSerializable = "Light";
            this.chartControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.chartControl2.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            simpleDiagram1.Dimension = 2;
            this.chartControl2.Diagram = simpleDiagram1;
            this.chartControl2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl2.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.chartControl2.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.None;
            this.chartControl2.Legend.MarkerSize = new System.Drawing.Size(19, 4);
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Legend.Title.Text = "Görev İstatistik";
            this.chartControl2.Legend.Title.Visible = true;
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl2.Location = new System.Drawing.Point(952, 180);
            this.chartControl2.Name = "chartControl2";
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.LegendTextPattern = "{V}";
            series2.Name = "ChartTasks";
            doughnutSeriesView1.HoleRadiusPercent = 45;
            series2.View = doughnutSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl2.Size = new System.Drawing.Size(307, 320);
            this.chartControl2.TabIndex = 4;
            // 
            // FrmTasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 511);
            this.Controls.Add(this.chartControl2);
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
            this.pnlControl1.ResumeLayout(false);
            this.pnlControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl2)).EndInit();
            this.pnlControl2.ResumeLayout(false);
            this.pnlControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl3)).EndInit();
            this.pnlControl3.ResumeLayout(false);
            this.pnlControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdControlTasksList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pnlControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.PanelControl pnlControl2;
        private DevExpress.XtraEditors.PanelControl pnlControl3;
        private DevExpress.XtraEditors.LabelControl LblTotalDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl LblActiveTask;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl LblPasiveTask;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraCharts.ChartControl chartControl2;
    }
}