using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Otomasyon_V0.DBEntity;
using Otomasyon_V0.Forms;

namespace Otomasyon_V0.Forms.FrmTasks
{
    public partial class FrmTaskAdd : Form
    {
        public FrmTaskAdd()
        {
            InitializeComponent();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();
        
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TblGorev tblGorev = new TblGorev();
            tblGorev.Aciklama = TxtTaskDetails.Text; 
            tblGorev.GorevAlan = int.Parse(LkUpTakeTask.EditValue.ToString());
            tblGorev.Durum = true;
            tblGorev.Tarih = DateTime.Parse(DateFinish.Text);
            tblGorev.GorevVeren = int.Parse(TxtGiveTask.Text);
            isTakipOtomasyonEntities.TblGorev.Add(tblGorev);
            isTakipOtomasyonEntities.SaveChanges();
            XtraMessageBox.Show("Görev Başarıyla Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FrmTaskAdd_Load(object sender, EventArgs e)
        {
            var value = (from x in isTakipOtomasyonEntities.TblPersonel
                         select new
                         {
                             x.ID,
                             x.Ad,
                             x.Soyad
                         }).ToList();
            LkUpTakeTask.Properties.ValueMember = "ID";
            LkUpTakeTask.Properties.DisplayMember = "Ad";
            LkUpTakeTask.Properties.DataSource = value;
        }
    }
}
