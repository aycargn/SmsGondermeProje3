
using SmsGondermeProje3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsGondermeProje3.Forms
{
    public partial class AyarFrm : Form
    {
        
        public AyarFrm()
        {
            InitializeComponent();
        }



        private void AyarFrm_Load(object sender, EventArgs e)
        {
            using (var db = new SQLiteDbContex())
            {
                gridControl21.DataSource = db.GIRIS.ToList();
                gridControl2.DataSource = db.AYARLAR.ToList();
            }
            kaydetbtn.Visible = true;

        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            if (kullanicitxt.Text.Length > 0 && sifretxt.Text.Length > 0)
            {
                SQLiteDbContex db = new SQLiteDbContex();

                KullaniciGiris_Tbl giris = new KullaniciGiris_Tbl();

                string ad = kullanicitxt.Text;
                var varmi4 = db.GIRIS.Any(x => x.Kullanici_Adi == ad);
                if (varmi4 == false)
                {
                    giris.Kullanici_Adi = kullanicitxt.Text.ToString();
                    giris.Sifre = sifretxt.Text;
                    db.GIRIS.Add(giris);
                    db.SaveChanges();
                    gridControl21.DataSource = db.GIRIS.ToList();
                    if(String.IsNullOrEmpty(GlobalClass.UserID))
                    {
                        GlobalClass.UserID = db.GIRIS.Max(a => a.ID).ToString();
                     
                    }
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı mevcut", "Hata");
                }
            }

            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            foreach (Control i in Controls)
            {
                if (i is TextBox) i.Text = "";
            }
        }

    


        private void duzenlebtn_Click(object sender, EventArgs e)
        {
            if (kullanicitxt.Text.Length > 0 && sifretxt.Text.Length > 0)
            {
                using (var db = new SQLiteDbContex())
            {
                string ad = kullanicitxt.Text;
                var duzenle = db.GIRIS.Where(x => x.Kullanici_Adi == ad).FirstOrDefault();
                duzenle.Kullanici_Adi = kullanicitxt.Text;
                duzenle.Sifre = sifretxt.Text;
                db.SaveChanges();
                gridControl21.DataSource = db.GIRIS.ToList();
            } 
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void sec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            kullanicitxt.Text = gridView21.GetFocusedRowCellValue("Kullanici_Adi").ToString();
            sifretxt.Text = gridView21.GetFocusedRowCellValue("Sifre").ToString();
            //kaydetbtn.Visible = true;
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            if (kullanicitxt.Text.Length > 0 && sifretxt.Text.Length > 0)
            { 
            using (var db = new SQLiteDbContex())
            {
            DialogResult dr = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                    int a = Convert.ToInt32(gridView21.GetFocusedRowCellValue("ID"));
                    var giris = (from i in db.GIRIS
                                  where i.ID == a
                                  select i).SingleOrDefault();
                    db.GIRIS.Remove(giris);
                    db.SaveChanges();
                MessageBox.Show("Kayıt başarı ile silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl21.DataSource = db.GIRIS.ToList();
            }

            else
            {
                MessageBox.Show("Kayıt silme işlemini iptal ettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kaydetNgsm_Click(object sender, EventArgs e)
        {
            if (ngsmidtext.Text.Length>0 && ngsmsifretext.Text.Length>0 && ngsmbasliktxt.Text.Length>0)
            { 
            SQLiteDbContex db = new SQLiteDbContex();      

            try
            {
                var ayar = db.AYARLAR.Where(u => u.AyarID == 1).FirstOrDefault();
                ayar.NetGsmUserID = ngsmidtext.Text;
                ayar.NetGsmSifre = ngsmsifretext.Text;
                ayar.NetGsmHeader = ngsmbasliktxt.Text;

                db.SaveChanges();
                gridControl2.DataSource = db.AYARLAR.ToList();

            }
            catch (DbEntityValidationException ayca)
            {
                foreach (var eve in ayca.EntityValidationErrors)
                {
                    MessageBox.Show("Entity of type " + eve.Entry.Entity.GetType().Name +" in state " + eve.Entry.State + " has the following validation errors:");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show(" Property: "+ ve.PropertyName + " Error: " + ve.ErrorMessage);
                    }
                }
                throw;
            }
            }
            else
            {
                MessageBox.Show("NetGsm müşteri ID, şifre ve başlık boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //                //db.AYARLAR.Add(ayar);
            
            //gridControl2.DataSource = db.AYARLAR.ToList();
            //var ayar = db.AYARLAR.Where(u => u.AyarID == 1);
            //db.AYARLAR.Update(NetGsmUserID, u => new ayar1 { NetGsmUserID = ngsmidtext });
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ngsmidtext.Text = gridView2.GetFocusedRowCellValue("NetGsmUserID").ToString();
            ngsmsifretext.Text = gridView2.GetFocusedRowCellValue("NetGsmSifre").ToString();
            ngsmbasliktxt.Text = gridView2.GetFocusedRowCellValue("NetGsmHeader").ToString();
        }

        private void guncellebtn1_Click(object sender, EventArgs e)
        {
            if (ngsmidtext.Text.Length > 0 && ngsmsifretext.Text.Length > 0 && ngsmbasliktxt.Text.Length > 0)
            { 
                using (var db = new SQLiteDbContex())
            {
                string ad = ngsmidtext.Text;
                var guncelle = db.AYARLAR.Where(x => x.NetGsmUserID == ad).FirstOrDefault();
                guncelle.NetGsmUserID = ngsmidtext.Text;
                guncelle.NetGsmSifre = ngsmsifretext.Text;
                guncelle.NetGsmSifre = ngsmbasliktxt.Text;
                db.SaveChanges();
                gridControl2.DataSource = db.AYARLAR.ToList();
            }
            }
            else
            {
                MessageBox.Show("NetGsm kullanıcı adı, şifre ve başlık boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
