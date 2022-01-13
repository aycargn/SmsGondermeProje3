using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsGondermeProje3.Model
{
    public class Cari_Tbl
    {
        [Key]
        public int CARI_ID { get; set; }
        public int BLKODU { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public string TICARI_UNVANI { get; set; }
        public string TEL { get; set; }
        //public string TEL_2 { get; set; }
        //public string CEP_TEL { get; set; }

    }
}
