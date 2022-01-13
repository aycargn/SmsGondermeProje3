using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsGondermeProje3.Model
{
    public class Sirketler_Tbl
    {


        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Sirket_Adi { get; set; }
        [Required]
        public string Sunucu_Adi { get; set; }
        [Required]
        public string Db_Kullanici { get; set; }
        [Required]
        public string Db_Sifre { get; set; }
        [Required]

        public string Database_Yolu { get; set; }

        //List<Sirketler_Tbl> Sirketler = new List<Sirketler_Tbl>();
    }
}
