using FirebirdSql.Data.FirebirdClient;
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
    public partial class Sirketpopup : Form
    {
        public Sirketpopup()
        {
            InitializeComponent();
        }

        private void Sirketpopup_Load(object sender, EventArgs e)
        {
            SQLiteDbContex db = new SQLiteDbContex();
            gridControl1.DataSource = db.SIRKETLER.ToList();
        }

        private void sirketdegistir_Click(object sender, EventArgs e)
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
            CariForm cf = new CariForm();
            Form1 form = new Form1();
           
            cf = new CariForm();
            cf.MdiParent = form;
            cf.Show();
            
            this.Close();
            

            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
