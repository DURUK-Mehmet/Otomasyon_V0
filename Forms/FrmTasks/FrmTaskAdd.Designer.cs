
namespace Otomasyon_V0.Forms.FrmTasks
{
    partial class FrmTaskAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaskAdd));
            this.PnlControlTaskAdd = new DevExpress.XtraEditors.PanelControl();
            this.CheckActive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTaskDetails = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LkUpTakeTask = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.DateFinish = new DevExpress.XtraEditors.DateEdit();
            this.TxtGiveTask = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlControlTaskAdd)).BeginInit();
            this.PnlControlTaskAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaskDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkUpTakeTask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFinish.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFinish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGiveTask.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlControlTaskAdd
            // 
            this.PnlControlTaskAdd.Controls.Add(this.CheckActive);
            this.PnlControlTaskAdd.Controls.Add(this.labelControl4);
            this.PnlControlTaskAdd.Controls.Add(this.TxtTaskDetails);
            this.PnlControlTaskAdd.Controls.Add(this.labelControl6);
            this.PnlControlTaskAdd.Controls.Add(this.BtnDelete);
            this.PnlControlTaskAdd.Controls.Add(this.BtnAdd);
            this.PnlControlTaskAdd.Controls.Add(this.labelControl3);
            this.PnlControlTaskAdd.Controls.Add(this.LkUpTakeTask);
            this.PnlControlTaskAdd.Controls.Add(this.labelControl2);
            this.PnlControlTaskAdd.Controls.Add(this.pictureEdit2);
            this.PnlControlTaskAdd.Controls.Add(this.labelControl1);
            this.PnlControlTaskAdd.Controls.Add(this.pictureEdit1);
            this.PnlControlTaskAdd.Controls.Add(this.DateFinish);
            this.PnlControlTaskAdd.Controls.Add(this.TxtGiveTask);
            this.PnlControlTaskAdd.Location = new System.Drawing.Point(1, 1);
            this.PnlControlTaskAdd.Name = "PnlControlTaskAdd";
            this.PnlControlTaskAdd.Size = new System.Drawing.Size(481, 461);
            this.PnlControlTaskAdd.TabIndex = 0;
            // 
            // CheckActive
            // 
            this.CheckActive.Location = new System.Drawing.Point(66, 407);
            this.CheckActive.Name = "CheckActive";
            this.CheckActive.Properties.Caption = "Aktif";
            this.CheckActive.Size = new System.Drawing.Size(75, 20);
            this.CheckActive.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(30, 240);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 19);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Görev Detay:";
            // 
            // TxtTaskDetails
            // 
            this.TxtTaskDetails.Location = new System.Drawing.Point(155, 239);
            this.TxtTaskDetails.Name = "TxtTaskDetails";
            this.TxtTaskDetails.Size = new System.Drawing.Size(296, 118);
            this.TxtTaskDetails.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 408);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 19);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Durum:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(325, 400);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(150, 40);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Vazgeç";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(155, 400);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(150, 40);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Görev Ver";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(205, 150);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 19);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Bitiş Tarihi";
            // 
            // LkUpTakeTask
            // 
            this.LkUpTakeTask.Location = new System.Drawing.Point(310, 110);
            this.LkUpTakeTask.Name = "LkUpTakeTask";
            this.LkUpTakeTask.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LkUpTakeTask.Properties.NullText = "Personeller";
            this.LkUpTakeTask.Properties.ThrowExceptionOnInvalidLookUpEditValueType = true;
            this.LkUpTakeTask.Size = new System.Drawing.Size(120, 20);
            this.LkUpTakeTask.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(330, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 19);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Görev Alan";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(345, 35);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit2.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(65, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Görev Veren";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(85, 35);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit1.TabIndex = 3;
            // 
            // DateFinish
            // 
            this.DateFinish.EditValue = new System.DateTime(2021, 8, 21, 3, 23, 1, 0);
            this.DateFinish.Location = new System.Drawing.Point(183, 175);
            this.DateFinish.Name = "DateFinish";
            this.DateFinish.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DateFinish.Properties.Appearance.Options.UseFont = true;
            this.DateFinish.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateFinish.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateFinish.Size = new System.Drawing.Size(120, 22);
            this.DateFinish.TabIndex = 2;
            // 
            // TxtGiveTask
            // 
            this.TxtGiveTask.Location = new System.Drawing.Point(50, 110);
            this.TxtGiveTask.Name = "TxtGiveTask";
            this.TxtGiveTask.Size = new System.Drawing.Size(120, 20);
            this.TxtGiveTask.TabIndex = 1;
            // 
            // FrmTaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.PnlControlTaskAdd);
            this.Name = "FrmTaskAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Ekleme";
            this.Load += new System.EventHandler(this.FrmTaskAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PnlControlTaskAdd)).EndInit();
            this.PnlControlTaskAdd.ResumeLayout(false);
            this.PnlControlTaskAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaskDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkUpTakeTask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFinish.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateFinish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGiveTask.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PnlControlTaskAdd;
        private DevExpress.XtraEditors.TextEdit TxtGiveTask;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.DateEdit DateFinish;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit LkUpTakeTask;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit TxtTaskDetails;
        private DevExpress.XtraEditors.CheckEdit CheckActive;
    }
}