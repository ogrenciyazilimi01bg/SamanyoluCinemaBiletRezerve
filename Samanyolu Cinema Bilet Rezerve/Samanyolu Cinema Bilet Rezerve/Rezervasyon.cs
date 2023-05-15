using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samanyolu_Cinema_Bilet_Rezerve
{
    public class Rezervasyon
    {
        public Seans Seans { get; set; }
        public string musteriAdiSoyadi { get; set; }
        public int biletAdeti { get; set; }
        public string koltukNo { get; set; }
        public double musteriCepTelefonu { get; set; }
    }
}
