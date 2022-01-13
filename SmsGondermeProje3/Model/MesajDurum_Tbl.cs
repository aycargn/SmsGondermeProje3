using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsGondermeProje3.Model
{
    public class MesajDurum_Tbl
    {
        public string TIC_UNVAN { get; set; }

        public string ADI { get; set; }

        public string SOYADI { get; set; }

        public string TELEFON { get; set; }

        [Key]
        public int MESAJ_ID { get; set; }

        public int CARI_ID { get; set; }

        public string GIDEN_TARIH_SAAT { get; set; }

        public string GIDEN_MESAJ { get; set; }
        
        public string DURUM { get; set; }    
        public string HATA_DURUM { get; set; }
        
        public string BULK_ID { get; set; }
        

    }
}
