using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using SmsGondermeProje3.Model;
using SmsGondermeProje3.ServiceReference1;

namespace SmsGondermeProje3.Forms
{
    public partial class Anasayfa2 : Form
    {
        public Anasayfa2()
        {
            InitializeComponent();
        }
       
        void Guncelle()
        {
            SQLiteDbContex db = new SQLiteDbContex();
            gridControl1.DataSource = db.MESAJ_DURUM.ToList();

        }
        public void DatabaseDurum()
        {
            if (Program.baglanti != null)
            {
                SQLiteDbContex db = new SQLiteDbContex();
                var guncelle = (from i in db.SIRKETLER where i.Database_Yolu == Program.baglanti.Database.ToString() select i).FirstOrDefault();
                label21.Text = guncelle.Sirket_Adi;
                label41.Text = "Açık";
            } else
            {
                label21.Text = "--";
                label41.Text = "Kapalı";
            }
        }
       
        private void Anasayfa2_Load(object sender, EventArgs e)
        {
            Guncelle();
            DatabaseDurum();
            SQLiteDbContex db = new SQLiteDbContex();
            var getir = from i in db.AYARLAR
                        select new
                        {
                            a = i.NetGsmHeader,
                        };
            baslikcmb.DataSource = getir.ToList();
            baslikcmb.DisplayMember = "a";
            var ayar = db.AYARLAR.Where(u => u.AyarID == 1).FirstOrDefault();
            smsnnClient kredi_sorgula = new smsnnClient();
            string gelen_cevap = kredi_sorgula.paketkampanya(ayar.NetGsmUserID, ayar.NetGsmSifre);
            string a = gelen_cevap.Substring(0,15);
            a = a.Replace("|", "  ");
            label4.Text = a;
            label2.Text = ayar.NetGsmUserID;

            if(!String.IsNullOrEmpty(GlobalClass.UserID))
            {
                var userid = Convert.ToInt32(GlobalClass.UserID);

                var user = db.GIRIS.Where(u => u.ID == userid).First();
                label22.Text = user.Kullanici_Adi;
            } else
            {
                label22.Text = "Admin kullanıcısı ile giriş yapılmıştır Lütfen kullanıcı kaydı yapınız.";
                label22.ForeColor = Color.Red;

            }
           
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SQLiteDbContex db = new SQLiteDbContex();
            var ayar = db.AYARLAR.Where(u => u.AyarID == 1).FirstOrDefault();
            if (ayar.NetGsmHeader == "" || ayar.NetGsmSifre == "" || ayar.NetGsmUserID == "")
            {
                MessageBox.Show("NetGSM bilgilerinizi girmeniz gerekmektedir.");
            } 
            else
            {
                MesajDurum_Tbl tbl = new MesajDurum_Tbl();
                List<string> telefonno = new List<string>();
                string gsm = teltext.Text;
                gsm = gsm.Replace("(", "");
                gsm = gsm.Replace(")", "");
                gsm = gsm.Replace("+", "");
                gsm = gsm.Replace("-", "");
                //gsm = gsm.Replace("", string.Empty);
                gsm = gsm.Trim();
                //bool a = telefon.Substring(0, 2) == "90";
                //bool b = telefon.Substring(0, 1) == "0";
                if (gsm.Substring(0, 2) == "90")
                {
                    gsm = gsm.Substring(2, gsm.Length - 2);
                }
                else if (gsm.Substring(0, 1) == "0")
                {
                    gsm = gsm.Substring(1, gsm.Length - 1);
                }

                telefonno.Add("90" + gsm);
                string[] telefonnodizi = telefonno.ToArray();

                string ad = adtxt.Text;
                string soyad = saydtxt.Text;
                string msg = msjtxt.Text;
                smsnnClient cl = new smsnnClient();
                string gelen_cevap = cl.smsGonder1NV2(ayar.NetGsmUserID, ayar.NetGsmSifre, ayar.NetGsmHeader, msg, telefonnodizi, "TR", "", "", "", 0);
                tbl.ADI = ad;
                tbl.SOYADI = soyad;
                tbl.TELEFON = gsm;
                tbl.GIDEN_MESAJ = msg;
                tbl.BULK_ID = gelen_cevap;
                tbl.DURUM = "İletim durumu bekleniyor.";
                tbl.HATA_DURUM = "Hata oluşmadı.";
                tbl.TIC_UNVAN = "---";

                db.MESAJ_DURUM.Add(tbl);
                db.SaveChanges();
                //richTextBox2.Text = gelen_cevap;
                Guncelle();
            }
            
        }
        private void sirkettimer_Tick(object sender, EventArgs e)
        {
            DatabaseDurum();
        }
    }
}
