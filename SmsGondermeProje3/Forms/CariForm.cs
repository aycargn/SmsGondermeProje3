using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using SmsGondermeProje3.Forms;
using SmsGondermeProje3.Model;


namespace SmsGondermeProje3.Forms
{
    public partial class CariForm : Form
    {
        public static int[] index1;
        void Guncelle()
        {
            DataTable dt = new DataTable();
            FbDataAdapter da = new FbDataAdapter("SELECT CARIKODU, TICARI_UNVANI, ADI, SOYADI , TEL1, TEL2,  CEP_TEL,GRUBU, ARA_GRUBU, ALT_GRUBU, ILI_1, ILCESI_1, KAYIT_TARIHI, DOGUM_TARIHI, BLKODU  FROM CARI", Program.baglanti);     
            da.Fill(dt);
            //dt.Columns[0].ColumnName = "Cari Kodu";
            //dt.Columns[1].ColumnName = "Ticari Ünvanı";
            //dt.Columns[2].ColumnName = "Adı";
            //dt.Columns[3].ColumnName = "Soyadı";
            //dt.Columns[4].ColumnName = "Telefon 1";
            //dt.Columns[5].ColumnName = "Telefon 2";
            //dt.Columns[6].ColumnName = "Cep Telefonu";
            //dt.Columns[7].ColumnName = "Grubu";
            //dt.Columns[8].ColumnName = "Ara Grubu";
            //dt.Columns[9].ColumnName = "Alt Grubu";
            //dt.Columns[10].ColumnName = "İli";
            //dt.Columns[11].ColumnName = "İlçesi";
            //dt.Columns[12].ColumnName = "Kayıt Tarihi";
            //dt.Columns[13].ColumnName = "Doğum Tarihi";
            //dt.Columns[14].ColumnName = "Blkodu";    
            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;
            dt.Columns[3].ReadOnly = true;
            dt.Columns[4].ReadOnly = true;
            dt.Columns[5].ReadOnly = true;
            dt.Columns[6].ReadOnly = true;
            dt.Columns[7].ReadOnly = true;
            dt.Columns[8].ReadOnly = true;
            dt.Columns[9].ReadOnly = true;
            dt.Columns[10].ReadOnly = true;
            dt.Columns[11].ReadOnly = true;
            dt.Columns[12].ReadOnly = true;
            dt.Columns[13].ReadOnly = true;
            dt.Columns[14].ReadOnly = true;
            gridControl1.DataSource = dt;


        }
        public CariForm()
        {
            InitializeComponent();
        }

        private void CariForm_Load(object sender, EventArgs e)
        {
            Guncelle();
            FbCommand il = new FbCommand("SELECT DISTINCT ILI_1 FROM CARI", Program.baglanti);
            FbDataReader dr = il.ExecuteReader();
            while (dr.Read())
            {
                ilicombobox.Items.Add(dr[0]);
            }

            grubucombo.Items.Add("Alıcı");
            grubucombo.Items.Add("Satıcı");

            FbCommand ulke = new FbCommand("SELECT DISTINCT ULKESI_1 FROM CARI", Program.baglanti);
            FbDataReader dr2 = ulke.ExecuteReader();
            while (dr2.Read())
            {
                ulkecombo.Items.Add(dr2["ULKESI_1"]);
            }

            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string il = ilicombobox.Text;
            FbCommand ilce = new FbCommand("SELECT DISTINCT ILCESI_1 FROM CARI WHERE ILI_1 = '" + il.ToString() + "'", Program.baglanti);
            FbDataReader dr1 = ilce.ExecuteReader();
            ilcesicombobox.Items.Clear();
            while (dr1.Read())
            {
                ilcesicombobox.Items.Add(dr1[0]);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

            string cari = carikodutext.Text;
            string ticunvan = ticunvantext.Text;
            string adi = aditext.Text;
            string soyadi = soyaditext.Text;
            string telefon = telefonmasked.Text;
            string grubu = grubucombo.Text;
            string aragrubu = aragrubucombo.Text;
            string altgrubu = altgrubucombo.Text;
            string ulke = ulkecombo.Text;
            string il = ilicombobox.Text;
            string ilce = ilcesicombobox.Text;
            string kTarihi = kayitmasked.Text;
            string dTarihi = dogummaskedtext.Text;

            #region sqlsorgu


            string sql = "SELECT * FROM CARI WHERE";
            if (carikodutext.Text.Trim().Length > 0)
            {
                sql += " CARIKODU LIKE '%" + cari + "%' AND";
            }
            if (ticunvantext.Text.Trim().Length > 0)
            {
                sql += " TICARI_UNVANI LIKE '%" + ticunvan + "%' AND";
            }
            if (aditext.Text.Trim().Length > 0)
            {
                sql += " ADI LIKE '%" + adi + "%' AND";
            }
            if (soyaditext.Text.Trim().Length > 0)
            {
                sql += " SOYADI LIKE '%" + soyadi + "%' AND";
            }
            if (telefonmasked.MaskFull)
            {
                sql += " CEP_TEL LIKE '%" + telefon + "%' AND";
            }
            if (grubucombo.Text.Trim().Length > 0)
            {
                sql += " GRUBU LIKE '%" + grubu + "%' AND";
            }
            if (aragrubucombo.Text.Trim().Length > 0)
            {
                sql += " ARA_GRUBU LIKE '%" + aragrubu + "%' AND";
            }
            if (altgrubucombo.Text.Trim().Length > 0)
            {
                sql += " ALT_GRUBU LIKE '%" + altgrubu + "%' AND";
            }
            if (ulkecombo.Text.Trim().Length > 0)
            {
                sql += " ULKESI_1 LIKE '%" + ulke + "%' AND";
            }
            if (ilicombobox.Text.Trim().Length > 0)
            {
                sql += " ILI_1 LIKE '%" + il + "%' AND";
            }
            if (ilcesicombobox.Text.Trim().Length > 0)
            {
                sql += " ILCESI_1 LIKE '%" + ilce + "%' AND";
            }
            if (kayitmasked.MaskFull)
            {
                string[] kTarih = kTarihi.Split('.');
                kTarihi = kTarih[2] + '-' + kTarih[1] + '-' + kTarih[0];
                sql += " KAYIT_TARIHI LIKE '%" + kTarihi + "%' AND";
            }
            if (dogummaskedtext.MaskFull)
            {
                string[] dTarih = dTarihi.Split('.');
                dTarihi = dTarih[2] + '-' + dTarih[1] + '-' + dTarih[0];
                sql += " DOGUM_TARIHI LIKE '%" + dTarihi + "%' AND";
            }


            if (sql.Length > 24)
            {
                sql = sql.Substring(0, sql.Length - 4);
            }
            else
            {
                sql = sql.Substring(0, sql.Length - 6);
            }

            #endregion

            FbDataAdapter da = new FbDataAdapter(sql, Program.baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds, "CARI");   
            gridControl1.DataSource = ds.Tables[0];
            carikodutext.Clear();
            ticunvantext.Clear();
            aditext.Clear();
            soyaditext.Clear();
            telefonmasked.Clear();
            grubucombo.SelectedIndex = -1;
            aragrubucombo.SelectedIndex = -1;
            aragrubucombo.Text = "";
            altgrubucombo.SelectedIndex = -1;
            ulkecombo.SelectedIndex = -1;
            ilicombobox.SelectedIndex = -1;
            ilicombobox.Text = "";
            ilcesicombobox.SelectedIndex = -1;
            ilcesicombobox.Text = "";
            kayitmasked.Clear();
            dogummaskedtext.Clear();

        }



        private void aragrubucombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aragrubu = aragrubucombo.Text;
            FbCommand altgrup = new FbCommand("SELECT DISTINCT ALT_GRUBU FROM CARI WHERE ARA_GRUBU = '" + aragrubu.ToString() + "'", Program.baglanti);
            FbDataReader dr1 = altgrup.ExecuteReader();
            altgrubucombo.Items.Clear();
            while (dr1.Read())
            {
                altgrubucombo.Items.Add(dr1[0]);
            }
        }

        private void grubucombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string grubu = grubucombo.Text;
            FbCommand aragrup = new FbCommand("SELECT DISTINCT ARA_GRUBU FROM CARI WHERE GRUBU = '" + grubu.ToString() + "'", Program.baglanti);
            FbDataReader dr1 = aragrup.ExecuteReader();
            aragrubucombo.Items.Clear();
            while (dr1.Read())
            {
                aragrubucombo.Items.Add(dr1[0]);
            }
        }

        private void carisec_Click(object sender, EventArgs e)
        {

            int[] selectedRowHandles = gridView1.GetSelectedRows();
            SQLiteDbContex db = new SQLiteDbContex();
            Cari_Tbl cari = new Cari_Tbl();
            foreach (int i in selectedRowHandles)
            {
                string tel1 = (gridView1.GetRowCellValue(i, "TEL1").ToString());
                string tel2 = (gridView1.GetRowCellValue(i, "TEL2").ToString());
                string ceptel = (gridView1.GetRowCellValue(i, "CEP_TEL").ToString());
                cari.ADI = (gridView1.GetRowCellValue(i, "ADI").ToString());
                cari.SOYADI = (gridView1.GetRowCellValue(i, "SOYADI").ToString());
                cari.BLKODU = Convert.ToInt32(gridView1.GetRowCellValue(i, "BLKODU").ToString());
                #region Telsec


                if (tel1.Trim().Length > 0 && tel2.Trim().Length == 0 && ceptel.Trim().Length == 0)
                {
                    cari.TEL = tel1;
                }
                else if (tel2.Trim().Length > 0 && tel1.Trim().Length == 0 && ceptel.Trim().Length == 0)
                {
                    cari.TEL = tel2;
                }
                else if (ceptel.Trim().Length > 0 && tel1.Trim().Length == 0 && tel2.Trim().Length == 0)
                {
                    cari.TEL = ceptel;
                }
                else if (tel1.Trim().Length > 0 && tel2.Trim().Length > 0 && ceptel.Trim().Length == 0)
                {
                    cari.TEL = tel1;
                }
                else if (tel2.Trim().Length > 0 && ceptel.Trim().Length > 0 && tel1.Trim().Length == 0)
                {
                    cari.TEL = ceptel;
                }
                else if (tel1.Trim().Length > 0 && tel2.Trim().Length > 0 && ceptel.Trim().Length > 0)
                {
                    cari.TEL = ceptel;
                }
                else
                {
                    cari.TEL = null;
                }
                #endregion
                cari.TICARI_UNVANI = (gridView1.GetRowCellValue(i, "TICARI_UNVANI").ToString());
              
                bool a = db.CARI.Any(x => x.BLKODU == cari.BLKODU);
             
                if(a==false)
                { 
                    db.CARI.Add(cari);
                    db.SaveChanges();
                }
               
            }
            //Program.baglanti.Close();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }

       
}



