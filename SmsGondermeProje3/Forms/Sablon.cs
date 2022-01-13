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
    public partial class Sablon : Form
    {
        private MesajIslemForm x;
        public Sablon(MesajIslemForm x)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.form_closing);
            this.x = x;
            
        }
        //MesajIslemForm fr = new MesajIslemForm();
        private void form_closing(object sender, FormClosingEventArgs e)
        {

            x.textBox1.Text = gridView1.GetFocusedRowCellValue("MESAJ_ICERIK").ToString();
            //fr.textBox1.Text = "abcd";
            //fr.Refresh();

        }

        public string mesaj;

        private void Sablon_Load(object sender, EventArgs e)
        {
          
            SQLiteDbContex db = new SQLiteDbContex();
            gridControl1.DataSource = db.MESAJ.ToList();
        }

        private void eklebtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            x.textBox1.Text = gridView1.GetFocusedRowCellValue("MESAJ_ICERIK").ToString();  
            this.Close();

        }
    }
}
