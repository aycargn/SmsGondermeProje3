using FirebirdSql.Data.FirebirdClient;
using SmsGondermeProje3.Model;
using SmsGondermeProje3.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SmsGondermeProje3.Forms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public bool status;
   
        
             
        public static string durum(int durum)
        {
            string msg = null;
            switch (durum)
            {

                case 0:  //İletilmeyi bekleyenler
                    msg = "İletim durumu bekleniyor.";
                    break;
                case 1: //İletilmiş olanlar
                    msg = "İletildi.";
                    break;
                case 2: //Zaman aşımına uğramış olanlar
                    msg = "Mesaj zaman aşımına uğradı.";
                    break;
                case 3: //    Hatalı veya kısıtlı numara
                    msg = "Hatalı veya kısıtlı telefon numarası.";
                    break;
                case 4://    Operatöre gönderilemedi
                    msg = "Operatöre gönderilemedi.";
                    break;
                case 11:// Operatör tarafından kabul edilmemiş olanlar
                    msg = "Mesaj operatör tarafından kabul edilmedi.";
                    break;
                case 12: //    Gönderim hatası olanlar
                    msg = "Mesaj gönderiminde hata oluştu.";
                    break;
                case 13: //    Mükerrer olanlar
                    msg = "Tekrarlanan mesaj.";
                    break;
                case 100: //    Tüm mesaj durumları
                    msg = "Tüm mesaj durumları.";
                    break;
            }
            return msg;
        }
        public static string hatadurumu(int hatadurum)
        {
            string msg1 = null;
            switch (hatadurum)
            {

                case 0:  //Hata yok
                    msg1 = "Hata oluşmadı.";
                    break;
                case 101: //Mesaj kutusu dolu
                    msg1 = "Mesaj kutusu dolu.";
                    break;
                case 102: //Kapalı yada kapsama alanı dısında
                    msg1 = "Kapalı ya da kapsama alınınde değil.";
                    break;
                case 103: //   meşgul
                    msg1 = "Hat meşgul.";
                    break;
                case 104:// hat aktif değil 
                    msg1 = "Hat aktif değil.";
                    break;
                case 105:// Hatalı numara
                    msg1 = "Eksik ya da hatalı telefon numarası";
                    break;
                case 106: // sms red/karaliste
                    msg1 = "Sms reddedildi ya da Kara listede";
                    break;
                case 111: //  Zaman aşımı
                    msg1 = "Mesaj zaman aşımına uğradı.";
                    break;
                case 112: //  Mobil cihaz sms gönderimine kapalı
                    msg1 = "Mobil cihaz mesaj gönderimine kapalı.";
                    break;
                case 113: //  mobil cihaz desteklemiyor
                    msg1 = "Mobil cihaz mesajı desteklemiyor.";
                    break;
                case 114: //  yönlendirme başarısız
                    msg1 = "Mesaj yönlendirimi başarısız oldu.";
                    break;
                case 115: //  çağrı yasaklandı
                    msg1 = "Çağrı yasaklandı.";
                    break;
                case 116: //  tanımlanamayan abone
                    msg1 = "Abone tanımlanamadı.";
                    break;
                case 117: //  yasadışı abone
                    msg1 = "Yasadışı abone";
                    break;
                case 119: //  sistemsel hata
                    msg1 = "Sistemsel hata oluştu.";
                    break;   
            }
            return msg1;
        }
 
       
        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteDbContex db = new SQLiteDbContex();
            var ayar = (from i in db.AYARLAR where i.AyarID == 1 select i).SingleOrDefault();
            this.Text = ayar.ProgramAdi;
           

            Program.owner = this;

            if (Program.baglanti == null)
            {
                caribtn.Enabled = false;
                mesajislembtn.Enabled = false;
                raporbtn.Enabled = false;
                ayarlarbtn.Enabled = false;
                Sirketfrm frm = new Sirketfrm();
                frm.ShowDialog();
            }
            if(status == true)
            {
                if (anasayfa == null || anasayfa.IsDisposed)
                {
                    anasayfa = new Anasayfa2();
                    anasayfa.MdiParent = this;
                    anasayfa.Show();
                    
                }
            } else
            {
                if (AyarFrm == null || AyarFrm.IsDisposed)
                {
                   
                    AyarFrm = new AyarFrm();
                    AyarFrm.MdiParent = this;
                    AyarFrm.Show();
                }
            }


            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Programı kapatmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            else
            {

                Application.Exit();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Program.baglanti != null)
            {

                caribtn.Enabled = true;
                mesajislembtn.Enabled = true;
                raporbtn.Enabled = true;
                ayarlarbtn.Enabled = true;

            }
            else
            {
                caribtn.Enabled = false;
                mesajislembtn.Enabled = false;
                raporbtn.Enabled = false;
                ayarlarbtn.Enabled = false;
            }
            if (!String.IsNullOrEmpty(GlobalClass.UserID))
            {
                anasfbtn.Enabled = true;
                caribtn.Enabled = true;
                mesajislembtn.Enabled = true;
                raporbtn.Enabled = true;

            }
            else
            {
                anasfbtn.Enabled = false;
                caribtn.Enabled = false;
                mesajislembtn.Enabled = false;
                raporbtn.Enabled = false;
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

            Sirketpopup pp = new Sirketpopup();
            pp.ShowDialog();
        }
        
        Sirketfrm sirketfrm;
        private void sirketanasfbtn_Click_1(object sender, EventArgs e)
        {
            if (sirketfrm == null || sirketfrm.IsDisposed)
            {
                sirketfrm = new Sirketfrm();
                sirketfrm.MdiParent = this;
                sirketfrm.Show();
            }
        }
        
        CariForm cariform;
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (cariform == null || cariform.IsDisposed)
            {
                cariform = new CariForm();
                cariform.MdiParent = this;
                cariform.Show();
            }
        }
        
        MesajIslemForm mesajForm;

        private void mesajislembtn_Click(object sender, EventArgs e)
        {
            if (mesajForm == null || mesajForm.IsDisposed)
            {
                mesajForm = new MesajIslemForm();
                mesajForm.MdiParent = this;
                mesajForm.Show();
            }
        }
        
        AyarFrm AyarFrm;
        private void ayarlarbtn_Click(object sender, EventArgs e)
        {
            if (AyarFrm == null || AyarFrm.IsDisposed)
            {
                AyarFrm = new AyarFrm();
                AyarFrm.MdiParent = this;
                AyarFrm.Show();
            }

        } 
        RaporFrm RaporFrm;
        private void raporbtn_Click(object sender, EventArgs e)
        {
            if (RaporFrm == null || RaporFrm.IsDisposed)
            {
                RaporFrm = new RaporFrm();
                RaporFrm.MdiParent = this;
                RaporFrm.Show();
            }
        }
        Anasayfa2 anasayfa;
        private void anasfbtn_Click(object sender, EventArgs e)
        {
            if (anasayfa == null || anasayfa.IsDisposed)
            {
                anasayfa = new Anasayfa2();
                anasayfa.MdiParent = this;
                anasayfa.Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SQLiteDbContex db = new SQLiteDbContex();

            var ayar = (from i in db.AYARLAR where i.AyarID == 1 select i).SingleOrDefault();

            if((from i in db.MESAJ_DURUM where i.DURUM == "İletim durumu bekleniyor." select i.BULK_ID).Count() > 0)
            {

                var bulkid = (from i in db.MESAJ_DURUM where i.DURUM == "İletim durumu bekleniyor." select i.BULK_ID).First();
                var telsorgu = (from i in db.MESAJ_DURUM where i.BULK_ID == bulkid select i.TELEFON).ToList();
                var msj = (from i in db.MESAJ_DURUM where i.BULK_ID == bulkid select i.MESAJ_ID).ToList();
                string[] teldizi = telsorgu.ToArray();
                int[] msgdizi = msj.ToArray();
                int b = teldizi.Length;

                smsnnClient sms = new smsnnClient();
                string response = sms.raporV3(ayar.NetGsmUserID, ayar.NetGsmSifre, bulkid, teldizi, "", "", "", 0, 100, 1);
                var xmltel = XElement.Parse(response).Descendants("telno").ToList();
                for (int i = 0; i < b; i++)
                {

                    var durumdeger = xmltel[i].Attribute("durum").Value;
                    var iletimtrh = xmltel[i].Attribute("iletim_tarihi").Value;
                    var hatadurum = xmltel[i].Attribute("failreason").Value;
                    int id = msgdizi[i];
                    var guncelle = (from a in db.MESAJ_DURUM
                                    where a.MESAJ_ID == id
                                    select a).FirstOrDefault();
                    guncelle.GIDEN_TARIH_SAAT = iletimtrh.ToString();
                    guncelle.DURUM = durum(Convert.ToInt32(durumdeger));
                    guncelle.HATA_DURUM = hatadurumu(Convert.ToInt32(hatadurum));
                    db.SaveChanges();
                }
            }
        }




        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (!worker.CancellationPending)
            {
                SQLiteDbContex db = new SQLiteDbContex();
                var ayar = db.AYARLAR.Where(u => u.AyarID == 1).FirstOrDefault();
                Cari_Tbl cari = new Cari_Tbl();
                List<string> tel = new List<string>();
                List<string> mesajlar = new List<string>();
                string dt = DateTime.Today.ToShortDateString();
                string[] dTarih = dt.Split('.');
                FbCommand da = new FbCommand("SELECT ADI, SOYADI, TICARI_UNVANI, CEP_TEL, DOGUM_TARIHI FROM CARI WHERE EXTRACT(DAY FROM DOGUM_TARIHI) = " + 
                    Convert.ToInt32(dTarih[0]) + " AND EXTRACT(MONTH FROM DOGUM_TARIHI) = " + Convert.ToInt32(dTarih[1]), Program.baglanti);
                FbDataReader dr = da.ExecuteReader();
                while (dr.Read())
                {
                    string AD = dr["ADI"].ToString();
                    string SOYADI = dr["SOYADI"].ToString();
                    string TICARI_UNVANI = dr["TICARI_UNVANI"].ToString();
                    string CEP_TEL = dr["CEP_TEL"].ToString();
                    var DOGUM_TARIHI = dr["DOGUM_TARIHI"];
                    string tel1 = functions.TelFormat(CEP_TEL);
                    string message = " Sayın {{TICARI_UNVANI}},{{ADI}} {{SOYADI}}. Nice mutlu senelere!";
                    string sonmesaj = message.Replace("{{TICARI_UNVANI}}", TICARI_UNVANI);
                    sonmesaj = sonmesaj.Replace("{{ADI}}", AD);
                    sonmesaj = sonmesaj.Replace("{{SOYADI}}", SOYADI);
                    mesajlar.Add(sonmesaj);
                    tel.Add(tel1);
                }

                string[] mesajlardizi1 = mesajlar.ToArray();
                string[] telefonlardizi1 = tel.ToArray();
                //smsnnClient sc = new smsnnClient();
                //string gelen_cevap = sc.smsGonderNNV2(ayar.NetGsmUserID, ayar.NetGsmSifre, ayar.NetGsmHeader, mesajlardizi1, telefonlardizi1, "TR", "", "", "", 0);
                Thread.Sleep(1000);
            }
            e.Cancel = true;
        }
    }
}
