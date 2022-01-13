using SmsGondermeProje3.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmsGondermeProje3.ServiceReference1;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;

namespace SmsGondermeProje3.Forms
{
    public partial class MesajIslemForm : Form
    {

        public MesajIslemForm()
        {
            InitializeComponent();
           
        }
              
        void Sil()
        {
            SQLiteDbContex db = new SQLiteDbContex();
            IEnumerable<Cari_Tbl> list = db.CARI.ToList();
            db.CARI.RemoveRange(list);
            db.SaveChanges();
            cmbCariList.Properties.DataSource = list;
            //cmbCariList.Properties.DisplayMember = "";
            //cmbCariList.Properties.ValueMember = "";
            cmbCariList.Refresh();

        }
        private void MesajIslemForm_Load(object sender, EventArgs e)
        {
            layoutControlItem20.ContentVisible = false;
            layoutControlItem21.ContentVisible = false;
            layoutControlItem19.ContentVisible = false;
            layoutControlItem18.ContentVisible = false;    
            label7.Text = "0"; 
            SQLiteDbContex db = new SQLiteDbContex();
            var getir = from i in db.AYARLAR
                        select new
                        {
                           a= i.NetGsmHeader,
                        };

            comboBox1.DataSource = getir.ToList();
            comboBox1.DisplayMember = "a";



            var cari = from i in db.CARI
                       select new
                       {
                           i.CARI_ID,
                           V = i.TICARI_UNVANI + "  - " + i.ADI + " " + i.SOYADI + " - (" + i.TEL + ")"
                       };
            var a = cari.ToList();
            int b = a.Count();
            label5.Text = b.ToString();
            cmbCariList.Properties.DataSource = a;
            cmbCariList.Properties.DisplayMember = "V";
            cmbCariList.Properties.ValueMember = "CARI_ID";
            cmbCariList.CheckAll();
        }


        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            SQLiteDbContex db = new SQLiteDbContex();
            var ayar = db.AYARLAR.Where(u => u.AyarID == 1).FirstOrDefault();
            if (ayar.NetGsmHeader == "" || ayar.NetGsmSifre == "" || ayar.NetGsmUserID == "")
            {
                MessageBox.Show("NetGSM bilgilerinizi girmeniz gerekmektedir.");
            }
            else
            {
                string[] chckedList = cmbCariList.Properties.GetCheckedItems().ToString().Split(',');
                string message = textBox1.Text;
                string gidistarih = gidismaskedtext.Text;
                string bitistarih = bitismaskedtext.Text;
                string normaltarih = (DateTime.Now).ToString();
                List<string> mesajlar = new List<string>();
                List<string> telefonlar = new List<string>();
                List<string> caris = new List<string>();
                MesajDurum_Tbl tbl = new MesajDurum_Tbl();

                #region radiobtn        
                if (ayarradiobtn.Checked == true)
                {
                    foreach (var item in chckedList)
                    {
                        // CARİ ID
                        int a = Convert.ToInt32(item.TrimStart());
                        var cari = (from i in db.CARI
                                    where i.CARI_ID == a
                                    select i).SingleOrDefault();

                        int cID = cari.CARI_ID;
                        string tUnvani = cari.TICARI_UNVANI;
                        string adi = cari.ADI;
                        string soyadi = cari.SOYADI;
                        string tel = cari.TEL;

                        string sonmesaj = message.Replace("{{TICARI_UNVANI}}", tUnvani);
                        sonmesaj = sonmesaj.Replace("{{ADI}}", adi);
                        sonmesaj = sonmesaj.Replace("{{SOYADI}}", soyadi);
                        tel = functions.TelFormat(tel);
                        if (tel != "false")
                        {
                            mesajlar.Add(sonmesaj);
                            telefonlar.Add("90" + tel);
                            caris.Add(cari.CARI_ID.ToString());
                        }
                        tbl.CARI_ID = cID;
                        tbl.TIC_UNVAN = tUnvani;
                        tbl.ADI = adi;
                        tbl.SOYADI = soyadi;
                        tbl.TELEFON = tel;
                        tbl.GIDEN_MESAJ = sonmesaj;
                        tbl.GIDEN_TARIH_SAAT = gidistarih;
                        tbl.DURUM = "İletim durumu bekleniyor.";
                        db.MESAJ_DURUM.Add(tbl);
                        db.SaveChanges();
                    }
                    string[] mesajlardizi1 = mesajlar.ToArray();
                    string[] telefonlardizi1 = telefonlar.ToArray();
                    string gidistarihfrm = gidismaskedtext.Text.Replace(".", "");
                    gidistarihfrm = gidistarihfrm.Replace("-", "");
                    gidistarihfrm = gidistarihfrm.Replace(":", "");
                    gidistarihfrm = gidistarihfrm.Trim();
                    string bitistarihfrm = bitismaskedtext.Text.Replace(".", "");
                    bitistarihfrm = bitistarihfrm.Replace("-", "");
                    bitistarihfrm = bitistarihfrm.Replace(":", "");
                    bitistarihfrm = bitistarihfrm.Trim();
                    smsnnClient sms = new smsnnClient();
                    string gelen_cevap = sms.smsGonderNNV2(ayar.NetGsmUserID, ayar.NetGsmSifre, ayar.NetGsmHeader, mesajlardizi1, telefonlardizi1, "TR", gidistarihfrm, bitistarihfrm, "", 0);
                    var bulkidguncelle = db.MESAJ_DURUM.Where(x => caris.Contains(x.CARI_ID.ToString())).ToList();
                    bulkidguncelle.ForEach(a => a.BULK_ID = gelen_cevap);
                    db.SaveChanges();
                }
                else if (normalradio.Checked == true)
                {
                    
                    foreach (var item in chckedList)
                    {

                        // CARİ ID
                        int a = Convert.ToInt32(item.TrimStart());
                        var cari = (from i in db.CARI
                                    where i.CARI_ID == a
                                    select i).SingleOrDefault();

                        int cID = cari.CARI_ID;
                        string tUnvani = cari.TICARI_UNVANI;
                        string adi = cari.ADI;
                        string soyadi = cari.SOYADI;
                        string tel = cari.TEL;

                        string sonmesaj = message.Replace("{{TICARI_UNVANI}}", tUnvani);
                        sonmesaj = sonmesaj.Replace("{{ADI}}", adi);
                        sonmesaj = sonmesaj.Replace("{{SOYADI}}", soyadi);
                        tel = functions.TelFormat(tel);
                        if (tel != "false")
                        {
                            mesajlar.Add(sonmesaj);
                            telefonlar.Add("90" + tel);
                            caris.Add(cari.CARI_ID.ToString());
                        }
                        tbl.CARI_ID = cID;
                        tbl.TIC_UNVAN = tUnvani;
                        tbl.ADI = adi;
                        tbl.SOYADI = soyadi;
                        tbl.TELEFON = tel;
                        tbl.GIDEN_MESAJ = sonmesaj;
                        tbl.GIDEN_TARIH_SAAT = normaltarih;
                        tbl.DURUM = "İletim durumu bekleniyor.";
                        tbl.HATA_DURUM = "Hata oluşmadı.";
                        db.MESAJ_DURUM.Add(tbl);
                        db.SaveChanges();

                    }

                    string[] mesajlardizi2 = mesajlar.ToArray();
                    string[] telefonlardizi2 = telefonlar.ToArray();
                    smsnnClient sms = new smsnnClient();
                    string gelen_cevap = sms.smsGonderNNV2(ayar.NetGsmUserID, ayar.NetGsmSifre, ayar.NetGsmHeader, mesajlardizi2, telefonlardizi2, "TR", "", "", "", 0);
                    var bulkidguncelle = db.MESAJ_DURUM.Where(x => caris.Contains(x.CARI_ID.ToString())).ToList();
                    bulkidguncelle.ForEach(a => a.BULK_ID = gelen_cevap.ToString());
                    db.SaveChanges();

                }
                else if (normalradio.Checked == false && ayarradiobtn.Checked == false)
                {
                    MessageBox.Show("Gönderim Zamanı Seçiniz.", "Uyarı", MessageBoxButtons.OKCancel);
                }
                #endregion
               
                Sil();

            }
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = functions.Karakter(textBox1.Text);
            label8.Text =a.ToString();
            int b = functions.Boy(a);
            label10.Text = b.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Sablon fr2 = new Sablon(this);
            fr2.ShowDialog();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            Sil();
            for (int i = 0; i < cmbCariList.Properties.Items.Count; i++)
                cmbCariList.Properties.Items[i].CheckState = CheckState.Unchecked;
            cmbCariList.Properties.DataSource = "";
            label5.Text = "0";
          

        }

 

        private void ayarradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if ( ayarradiobtn.Checked== true )
            {
                layoutControlItem20.ContentVisible = true;
                layoutControlItem21.ContentVisible = true;
                layoutControlItem19.ContentVisible = true;
                layoutControlItem18.ContentVisible = true;
            } 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (normalradio.Checked==true)
            { 
            layoutControlItem20.ContentVisible = false;
            layoutControlItem21.ContentVisible = false;
            layoutControlItem19.ContentVisible = false;
            layoutControlItem18.ContentVisible = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

      
    }
}
