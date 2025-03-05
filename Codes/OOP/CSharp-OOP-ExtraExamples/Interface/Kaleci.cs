using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_interface
{
    public class Kaleci : IFutbolcu
    {
        
        public string AdiSoyadi { get; set; }
        public string FormaNumarasi { get; set; }
        public byte SutGucu { get; set; }
        public byte Refleks { get; set; }
        public byte Dayanıklılık { get; set; }
        public byte Agresiflik { get; set; }
        public byte AtilanGol { get; set; }
        public bool Millimi { get; set ; }
        public int ElleTopKontrollu { get; set; }

        public void SutCek()
        {
            throw new NotImplementedException();
        }

        public void TopTutar()
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            return AdiSoyadi;
        }
    }
}
