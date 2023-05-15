using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samanyolu_Cinema_Bilet_Rezerve
{
    public class Seans
    {         
        public Film Film { get; set; }
        public Salon Salon { get; set; }
        public string seansZamanı { get; set; }
        public DateTime tarih { get; set; }

    }
}
