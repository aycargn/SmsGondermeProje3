using SmsGondermeProje3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsGondermeProje3.Forms
{
    public partial class RaporFrm : Form
    {
        public RaporFrm()
        {
            InitializeComponent();
        }
        SQLiteDbContex db = new SQLiteDbContex();       
        private void aramabtn_Click(object sender, EventArgs e)
        {
            

            string ticunvan = ticunvantext.Text;
            string adi = aditext.Text;
            string soyadi = soyaditext.Text;
            string telefon = telefonmasked.Text;
            string trh = dateTimePicker1.Value.ToString();
            string[] trh1 = trh.Split(' ');
            trh = trh1[0] + " 00:00:00";
            string trh2 = dateTimePicker2.Value.ToString();
            trh1 = trh2.Split(' ');
            trh2 = trh1[0] + " 00:00:00";
            var aramaSonucu = (from kayit in db.MESAJ_DURUM
                               select kayit).ToList();

            if (!String.IsNullOrEmpty(adi))
            {
                aramaSonucu = aramaSonucu.Where(a => a.ADI.Contains(adi)).ToList();

            }
            if (!String.IsNullOrEmpty(soyadi))
            {
                aramaSonucu = aramaSonucu.Where(a => a.SOYADI.Contains(soyadi)).ToList();
            }
            if (!String.IsNullOrEmpty(ticunvan))
            {
                aramaSonucu = aramaSonucu.Where(a => a.TIC_UNVAN.Contains(ticunvan)).ToList();
            }
            if (!String.IsNullOrEmpty(telefon))
            {
                aramaSonucu = aramaSonucu.Where(a => a.TELEFON.Contains(telefon)).ToList();
            }
            if (dateTimePicker1.Checked==true)
            {
                aramaSonucu = aramaSonucu.Where(a=> functions.ToDateTime(a.GIDEN_TARIH_SAAT, '-', ':') >= functions.ToDateTime(trh, '.', ':')).ToList();
              
            }

            if (dateTimePicker2.Checked == true)
            {
                aramaSonucu = aramaSonucu.Where(a => functions.ToDateTime(a.GIDEN_TARIH_SAAT, '-', ':') <= functions.ToDateTime(trh2, '.', ':')).ToList();
            }

            gridControl1.DataSource = aramaSonucu;

        }

        private void RaporFrm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.MESAJ_DURUM.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ticunvantext.Clear();
            aditext.Clear();
            soyaditext.Clear();
            telefonmasked.Clear();
            gridControl1.DataSource = db.MESAJ_DURUM.ToList();
        }
    }
}

