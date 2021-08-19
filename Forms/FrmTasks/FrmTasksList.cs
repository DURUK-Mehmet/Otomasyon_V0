using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otomasyon_V0.DBEntity;
using Otomasyon_V0.Forms;

namespace Otomasyon_V0.Forms
{
    public partial class FrmTasksList : Form
    {
        public FrmTasksList()
        {
            InitializeComponent();
            List();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        TblGorev tblGorev = new TblGorev();
        TblGorevDetay tblGorevDetay = new TblGorevDetay();

        void List()
        {
            grdControlTasksList.DataSource = (from x in isTakipOtomasyonEntities.TblGorev
                                              select new
                                              {
                                                  x.Aciklama
                                              }).ToList();
            chartControl1.Series["PieDepartment"].Points.AddPoint("Muhasebe",20);
            chartControl1.Series["PieDepartment"].Points.AddPoint("Danışman", 10);
            chartControl1.Series["PieDepartment"].Points.AddPoint("Mutfak", 20);
            chartControl1.Series["PieDepartment"].Points.AddPoint("Staj", 30);
            chartControl1.Series["PieDepartment"].Points.AddPoint("Bilgi İşlem", 80);
            chartControl1.Series["PieDepartment"].Points.AddPoint("İnsan Kaynakları", 2);
            chartControl1.Series["PieDepartment"].Points.AddPoint("Yönetim", 10);
            chartControl1.Series["PieDepartment"].Points.AddPoint("Ulaşım", 50);
            chartControl1.Series["PieDepartment"].Points.AddPoint("Depo", 5);
            chartControl1.Series["PieDepartment"].Points.AddPoint("Proje", 1);
            chartControl1.Series["PieDepartment"].Points.AddPoint("Güvenlik", 25);

            chartControl2.Series["ChartTasks"].Points.AddPoint("Aktif İş Sayısı", int.Parse(LblActiveTask.Text));
            chartControl2.Series["ChartTasks"].Points.AddPoint("Pasif İş Sayısı", int.Parse(LblPasiveTask.Text));

            LblTotalDepartment.Text = isTakipOtomasyonEntities.TblDepartman.Count().ToString();
            LblActiveTask.Text = isTakipOtomasyonEntities.TblGorev.Count(x => x.Durum == true).ToString();
            LblPasiveTask.Text = isTakipOtomasyonEntities.TblGorev.Count(x=>x.Durum==false).ToString();

        }

        private void FrmTasksList_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
