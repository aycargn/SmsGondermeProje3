using SmsGondermeProje3.Forms;
using SmsGondermeProje3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace SmsGondermeProje3
{
    public static class varlik
    {

        public static bool kullanicivarmi;
        public static bool varmi2;
        

    }
    static class Program
    {
        public static Form owner;
        static public  FbConnection baglanti;

        public static string TelFormat(string telefon)
        {
            if (string.IsNullOrEmpty(telefon))
            {
                return "false";
            }
            telefon.Trim();
            if (telefon.Length < 10)
            {
                return "false";
            }
            telefon = telefon.Replace("(", "");
            telefon = telefon.Replace(")", "");
            telefon = telefon.Replace("+", "");
            telefon = telefon.Replace("-", "");
            bool a = telefon.Substring(0, 2) == "90";
            bool b = telefon.Substring(0, 1) == "0";
            if (telefon.Substring(0, 2) == "90")
            {
                telefon = telefon.Substring(2, telefon.Length - 2);
            }
            else if (telefon.Substring(0, 1) == "0")
            {
                telefon = telefon.Substring(1, telefon.Length - 1);
            }
            return telefon;
        }
            //if (a == false)
            //{
            //    telefon = "90" + telefon;
            //}
            //else if (b == true)
            //{
            //    telefon = "9" + telefon;
            //}
            //return telefon;

        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            SQLiteDbContex db = new SQLiteDbContex();
            {
                //var list = new List<Sirketler_Tbl>();
                //foreach (var item in collection)
                //{ 
                //int a = Convert.ToInt32(item.TrimStart());
                //var cari = (from i in db.CARI
                //            where i.CARI_ID == a
                //            select i).SingleOrDefault();

                //}
               
                //şirketler tablosundaki şirket ıdlerini listeye çekip ordan count değerini alcm. 
                //eğer count ==0sa hiç şirket girişi yapılmamış oluyor, o yüzden şirket kayıt ekranına yönlendircek.
                //kullanıcı girişi için de kontrol edilecek. Daha önceden kullanıcı girişi yapılmış mı yapılmamış mı. Şu anda yapıyor ama sadece gösterilecek label için yapıyor.
                //Eğer daha önceden girdiği kullanıcı adı varsa uygulamayı kullanmaya başlayabilecek, ama yoksa default kullanıcı adı ve şifreyle giriş yaptıgında 
                //kullanıcı kayıt ekranına gidecek kullanıcı olarak kendini eklediğinde uygulamanın özellikleri açılacak.sonra şirket vs.
                //kullancıyla şirket tablosu ilişkilendirilecek mi?

                varlik.kullanicivarmi = db.GIRIS.Any(x => x.ID != 1);
               
                int? intIdt = db.SIRKETLER.Max(u => (int?)u.ID);
                varlik.varmi2 = db.SIRKETLER.Any(x => x.ID == intIdt);  

            }
          


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run( new GirisForm());
        }
    }
}
