using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Entities
{
    public class Dersler
    {
        [Key]
        public int DersID { get; set; }
        public string DersAd { get; set; }
        public string DersYil { get; set; }
        public string DersYariyil { get; set; }
    }
}
