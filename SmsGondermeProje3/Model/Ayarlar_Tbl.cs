using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsGondermeProje3.Model
{
    [Table("AYARLAR")]
    public class Ayarlar_Tbl
    {
        [Key]    
        public int AyarID { get; set; }
        
        [MaxLength(100)]
        public string ProgramAdi { get; set; }
        [MaxLength(25)]
        public string NetGsmUserID { get; set; }
        [MaxLength(25)]
        public string NetGsmSifre { get; set; }  
        [MaxLength(11)]
        public string NetGsmHeader { get; set; }


        //public virtual Ayarlar_Tbl AYARLAR { get; set; }


    }
}
