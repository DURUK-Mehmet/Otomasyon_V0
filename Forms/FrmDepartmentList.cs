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

namespace Otomasyon_V0.Forms
{
    public partial class FrmDepartmentList : Form
    {
        public FrmDepartmentList()
        {
            InitializeComponent();
            List();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();
        
        void List()
        {
            var veriables = (from x in isTakipOtomasyonEntities.TblDepartman
                             select new
                             {
                                 x.ID,
                                 x.Ad
                             }).ToList();
            grdControlDepartmentList.DataSource = veriables;
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List();
        }
    }
}
