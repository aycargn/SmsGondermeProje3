using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmsGondermeProje3.Model
{
    public static class functions
    {
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
            Regex r = new Regex("/[^0-9]/");
            telefon = r.Replace(telefon, "/[^0-9]/");
            telefon = telefon.Replace("(", "");
            telefon = telefon.Replace(")", "");
            telefon = telefon.Replace("+", "");
            telefon = telefon.Replace(" ", string.Empty);

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
        public static DateTime ToDateTime(this string datetime, char dateSpliter = '-', char timeSpliter = ':')
        {
            try
            {
                datetime = datetime.Trim();
                datetime = datetime.Replace("  ", " ");
                string[] body = datetime.Split(' ');
                string[] date = body[0].Split(dateSpliter);
                int year, month, day;
                if (date[0].Length == 4)
                {
                    year = Convert.ToInt32(date[0]);
                    month = Convert.ToInt32(date[1]);
                    day = Convert.ToInt32(date[2]);

                } else {
                    day = Convert.ToInt32(date[0]);
                    month = Convert.ToInt32(date[1]);
                    year = Convert.ToInt32(date[2]);
                }
             
                int hour = 0, minute = 0, second = 0;
                if (body.Length == 2)
                {
                    string[] time = body[1].Split(timeSpliter);
                
                    hour = Convert.ToInt32(time[0]);
                    minute = Convert.ToInt32(time[1]);
               


                    if (time.Length == 3) {
                        var timesp = time[2].Split('.');
                        second = Convert.ToInt32(timesp[0]);

                    } 
                }
                return new DateTime(year, month, day, hour, minute, second);
            }
            catch
            {
                return new DateTime();
            }
        }
        public static int Karakter (string mesaj)
        {
            
            int sayac = 0;
            int mesajuzunluk = 0;


            for (int a = 0; a < mesaj.Length; a++)
            {

                if ((mesaj.Substring(a, 1) == "ç") )
                { sayac++; ; continue; }
                if ((mesaj.Substring(a, 1) == "ğ"))
                { sayac++; ; continue; }
                if ((mesaj.Substring(a, 1) == "ı"))
                { sayac++; continue; }
                if ((mesaj.Substring(a, 1) == "ş"))
                { sayac++; ; continue; }
                if ((mesaj.Substring(a, 1) == "Ğ"))
                { sayac++; ; continue; }
                if ((mesaj.Substring(a, 1) == "İ"))
                { sayac++; ; continue; }
                if ((mesaj.Substring(a, 1) == "Ş"))
                { sayac++; ; continue; }
                if ((mesaj.Substring(a, 1) == "Ç"))
                { sayac++; ; continue; }
            }
            mesajuzunluk = mesaj.Length + sayac;
            return mesajuzunluk;  
        }
        public static int Boy(float mesajuzunluk)
        {
            int msjboy = 0;
            msjboy = (int)Math.Ceiling((mesajuzunluk / 150));
            //if  (mesajuzunluk<150)
            //{
            //    msjboy = 1;
            //}
            //if ( mesajuzunluk>150 && mesajuzunluk<300)
            //{
            //    msjboy = 2;
            //}
            //if ( mesajuzunluk>300 && mesajuzunluk<450)
            //{
            //    msjboy = 3;
            //}
            return msjboy;
        }
    }
}
 
