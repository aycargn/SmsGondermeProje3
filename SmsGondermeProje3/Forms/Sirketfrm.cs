using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using SmsGondermeProje3.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SQLite;

namespace SmsGondermeProje3.Forms
{
    public partial class Sirketfrm : Form
    {
        public Sirketfrm()
        {
            InitializeComponent();
        }
        private void Guncelle()
        {
            SQLiteDbContex db = new SQLiteDbContex();
            gridControl1.DataSource = db.SIRKETLER.ToList();
        }

        private void Sirketfrm_Load(object sender, EventArgs e)
        {
            //gridView1.OptionsBehavior.Editable = false;
            Guncelle();
            kaydetbtn.Visible = false;


        }

        private void dbsec_Click(object sender, EventArgs e)
        {
            XtraOpenFileDialog openFileDialog = new XtraOpenFileDialog();
            {

                openFileDialog.Filter = "Firebird Dosyasi(*.FDB)|*.FDB";
                openFileDialog.Title = "Veritabanı Dosyası Seçiniz";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    databasetext.Text = openFileDialog.FileName;

                }
            }
        }

        private void sirketeklebtn_Click(object sender, EventArgs e)
        {
            if (sirkettext.Text.Length>0 && sunucutext.Text.Length>0 && kullanicitext.Text.Length>0 && kullanicisifretext.Text.Length>0 && databasetext.Text.Length>0)
            {        
                SQLiteDbContex dbm = new SQLiteDbContex();
            Sirketler_Tbl sirketler = new Sirketler_Tbl();
            var sirketvarmi = dbm.SIRKETLER.Any(x => x.Sirket_Adi == sirketler.Sirket_Adi);
            if (sirketvarmi == false)
            {
                sirketler.Sirket_Adi = sirkettext.Text.ToString();
                sirketler.Sunucu_Adi = sunucutext.Text.ToString();
                sirketler.Db_Kullanici = kullanicitext.Text.ToString();
                sirketler.Db_Sifre = kullanicisifretext.Text.ToString();
                sirketler.Database_Yolu = databasetext.Text.ToString();  
                dbm.SIRKETLER.Add(sirketler);
                dbm.SaveChanges();
                gridControl1.DataSource = dbm.SIRKETLER.ToList();

            }
            else 
            {
                MessageBox.Show("Bu kayıt daha önceden eklenmiş", "Hata");
            }
            Guncelle();
            }
            else
            {
                MessageBox.Show("Şirket adı, Kullanıcı adı, Şifre, Sunucu adı, Dosya boş geçilemez.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void baglan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            
            var connectionstringbuilder = new FbConnectionStringBuilder()
            {
                UserID = gridView1.GetFocusedRowCellValue("Db_Kullanici").ToString(),
                Password = gridView1.GetFocusedRowCellValue("Db_Sifre").ToString(),
                DataSource = gridView1.GetFocusedRowCellValue("Sunucu_Adi").ToString(),
                Database = gridView1.GetFocusedRowCellValue("Database_Yolu").ToString(),  
            
            };
            Program.baglanti = new FbConnection(connectionstringbuilder.ToString());
            Program.baglanti.Open();
            MessageBox.Show("Bağlantı Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
            //CariForm frm = new CariForm();
            //frm.MdiParent = Program.owner;
            //frm.Show();


        }
        private void duzenle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            sirkettext.Text = gridView1.GetFocusedRowCellValue("Sirket_Adi").ToString();
            kullanicitext.Text = gridView1.GetFocusedRowCellValue("Db_Kullanici").ToString();
            kullanicisifretext.Text = gridView1.GetFocusedRowCellValue("Db_Sifre").ToString();
            sunucutext.Text = gridView1.GetFocusedRowCellValue("Sunucu_Adi").ToString();
            databasetext.Text = gridView1.GetFocusedRowCellValue("Database_Yolu").ToString();
            kaydetbtn.Visible = true;

        }

        private void sil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (var db = new SQLiteDbContex())
                {
                    int a = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                    var sirket = (from i in db.SIRKETLER
                                  where i.ID == a
                                  select i).SingleOrDefault();
                    db.SIRKETLER.Remove(sirket);
                    db.SaveChanges();

                }
                MessageBox.Show("Kayıt başarı ile silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Guncelle();
            }

            else
            {
                MessageBox.Show("Kayıt silme işlemini iptal ettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            SQLiteDbContex db = new SQLiteDbContex();
            int b = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            var guncelle1 = (from i in db.SIRKETLER where i.ID == b select i).FirstOrDefault();
            guncelle1.Sirket_Adi = sirkettext.Text;
            guncelle1.Sunucu_Adi = sunucutext.Text;
            guncelle1.Db_Kullanici = kullanicitext.Text;
            guncelle1.Db_Sifre = kullanicisifretext.Text;
            guncelle1.Database_Yolu = databasetext.Text;
            db.SaveChanges();
            Guncelle();
            MessageBox.Show("Şirket bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK);
        }

      
    }
   
}
