using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Entities
{
    public class Bolumler
    {
        [Key]
        public int BolumID { get; set; }
        public string BolumAd { get; set; }
       
        public int fakulteID { get; set; }
    }
}
