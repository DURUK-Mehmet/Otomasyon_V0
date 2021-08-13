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
    public partial class FrmEmployeeList : Form
    {
        public FrmEmployeeList()
        {
            InitializeComponent();
            List();

            var value = (from x in isTakipOtomasyonEntities.TblDepartman
                         select new
                         {
                             x.ID,
                             x.Ad
                         }).ToList();
            LkUpEmployee.Properties.ValueMember = "ID";
            LkUpEmployee.Properties.DisplayMember = "Ad";
            LkUpEmployee.Properties.DataSource =value;
        }
        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        TblPersonel tblPersonel = new TblPersonel();

        void List()
        {
            var values = from x in isTakipOtomasyonEntities.TblPersonel
                         select new
                         {
                             x.ID,
                             x.Ad,
                             x.Soyad,
                             x.Mail,
                             x.Departman,
                         };
            grdControlEmployeeList.DataSource = values.ToList();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List();
        }
    }
}
