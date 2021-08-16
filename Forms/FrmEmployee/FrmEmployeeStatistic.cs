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

namespace Otomasyon_V0.Forms.FrmEmployee
{
    public partial class FrmEmployeeStatistic : Form
    {
        public FrmEmployeeStatistic()
        {
            InitializeComponent();
        }

        isTakipOtomasyonEntities isTakipOtomasyonEntities = new isTakipOtomasyonEntities();

        private void FrmEmployeeStatistic_Load(object sender, EventArgs e)
        {
            LblTotalDepartment.Text = isTakipOtomasyonEntities.TblDepartman.Count().ToString();
            LblTotalCompanie.Text = isTakipOtomasyonEntities.TblFirma.Count().ToString();
            LblTotalEmployee.Text = isTakipOtomasyonEntities.TblPersonel.Count().ToString();
            
        }
    }
}
