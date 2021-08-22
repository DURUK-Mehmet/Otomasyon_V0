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

namespace Otomasyon_V0.Forms.FrmHome
{
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        DateTime Today = DateTime.Parse(DateTime.Today.ToShortDateString());

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            //Continue Task Always
            grdControlHome1.DataSource = (from x in isTakipOtomasyonEntities.TblGorev
                                          select new
                                          {
                                              x.Aciklama,
                                              Personel=x.TblPersonel.Ad+" "+x.TblPersonel.Soyad,
                                              x.Durum
                                          }).Where(x=>x.Durum==true).ToList();
            gridView1.Columns["Durum"].Visible = false;

            //Continue Task Today

            grdControlHome2.DataSource = (from x in isTakipOtomasyonEntities.TblGorevDetay select new
                                            {
                                                Görev=x.TblGorev.Aciklama,
                                                x.Aciklama,
                                                x.Tarih
                                             }).Where(x => x.Tarih == Today).ToList();

                                       
        }

        
    }
}
