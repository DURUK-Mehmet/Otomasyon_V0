using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otomasyon_V0.DBEntity;
using Otomasyon_V0.Forms;

namespace Otomasyon_V0.Forms.FrmEmployee
{
    public partial class FrmEmployeeStatistic : Form
    {
        public FrmEmployeeStatistic()
        {
            InitializeComponent();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        DateTime today = DateTime.Today;

        private void FrmEmployeeStatistic_Load(object sender, EventArgs e)
        {
            LblTotalDepartment.Text = isTakipOtomasyonEntities.TblDepartman.Count().ToString();
            LblTotalCompanie.Text = isTakipOtomasyonEntities.TblFirma.Count().ToString();
            LblTotalEmployee.Text = isTakipOtomasyonEntities.TblPersonel.Count().ToString();
            LblActiveJob.Text = isTakipOtomasyonEntities.TblGorev.Count(x => x.Durum == "1").ToString();
            LblPassiveJob.Text = isTakipOtomasyonEntities.TblGorev.Count(x => x.Durum == "0").ToString();
            LblLastTask.Text = isTakipOtomasyonEntities.TblGorev.OrderByDescending(x=>x.ID).Select(x=>x.Aciklama).FirstOrDefault();
            LblCityJob.Text = isTakipOtomasyonEntities.TblFirma.Select(x => x.İl).Distinct().Count().ToString();
            LblTotalSector.Text = isTakipOtomasyonEntities.TblFirma.Select(x => x.Alan).Distinct().Count().ToString();
            LblNowJob.Text = isTakipOtomasyonEntities.TblGorev.Count(x => x.Tarih == today).ToString();
            var MonthEmployeeId= isTakipOtomasyonEntities.TblGorev.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            LblMonthEmployee.Text = isTakipOtomasyonEntities.TblPersonel.Where(x => x.ID == MonthEmployeeId).Select(y => y.Ad+" "+y.Soyad).FirstOrDefault().ToString();

        }
    }
}
