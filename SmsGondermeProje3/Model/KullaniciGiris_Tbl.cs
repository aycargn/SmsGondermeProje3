using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsGondermeProje3.Model
{

    [Table("Kullanicilar")]
    public class KullaniciGiris_Tbl
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(10)]
        public string Kullanici_Adi { get; set; }
        [Required]
        [MaxLength(10)]
        public string Sifre { get; set; }
    }
}
