using SmsGondermeProje3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsGondermeProje3.Forms
{
    public partial class GirisForm : Form
    {        
        public GirisForm()
        {
            InitializeComponent();
           
        }
        public bool status;
        
        private void GirisForm_Load(object sender, EventArgs e)
        {

            if (varlik.kullanicivarmi == true)
            {
                bilgilabel.Visible = false;
                status = true;

                this.Update();


            }
            else
            {
                bilgilabel.Visible = true;
                this.Update();
            }
        }


        private void girisbtn_Click(object sender, EventArgs e)
        {
            if(status == true)
            {
                SQLiteDbContex db = new SQLiteDbContex();
                var m = db.GIRIS.Where(a => a.Kullanici_Adi == kullaniciaditext.Text && a.Sifre == sifretext.Text).SingleOrDefault();
                if (m != null && m.Kullanici_Adi != "Admin")
                {
                    Form1 af = new Form1();
                   
                    af.status = true;
                    GlobalClass.UserID = m.ID.ToString();
                    this.Hide();
                    af.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya Sifre Yanlış", "", MessageBoxButtons.OK);

                }
            } 
            else
            {
                if (kullaniciaditext.Text == "Admin" && sifretext.Text == "admin")
                {
                    Form1 af = new Form1();
                    af.status = false;
                    GlobalClass.UserID = "";
                    this.Hide();
                    af.Show();
                 
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya Sifre Yanlış", "", MessageBoxButtons.OK);

                }

            }
            
       
        }


        private void cikisbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void sifretext_TextChanged(object sender, EventArgs e)
        {
            sifretext.PasswordChar = '*';
        }

        private void hatirlacheck_CheckedChanged(object sender, EventArgs e)
        {
            if (hatirlacheck.Checked == true)
            {
                SQLiteDbContex db = new SQLiteDbContex();
                int intID = db.GIRIS.Max(d => d.ID);
                var hatirla = db.GIRIS.SingleOrDefault(d => d.ID == intID);


                kullaniciaditext.Text = hatirla.Kullanici_Adi;
                sifretext.Text = hatirla.Sifre;


            }
            else
            {
                kullaniciaditext.Text = "";
                sifretext.Text = "";

            }
        }
    }
}
