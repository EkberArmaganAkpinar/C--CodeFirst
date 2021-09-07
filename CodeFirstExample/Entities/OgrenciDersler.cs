using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Entities
{
    public class OgrenciDersler
    {
        [Key]
        public int OgrenciDersID { get; set; }
        public int OgrenciID { get; set; }
        public int DersID { get; set; }
        public string Yil { get; set; }
        public string YariYil { get; set; }
        public string Vize { get; set; }
        public string Final { get; set; }


    }
}
