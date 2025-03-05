using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_interface
{
  public  interface IFutbolcu
    {
         string AdiSoyadi { get; set; }
         string FormaNumarasi { get; set; }
         byte SutGucu { get; set; }
        byte Refleks { get; set; }
        byte Dayanıklılık { get; set; }
        byte Agresiflik { get; set; }
         byte AtilanGol { get; set; }
        bool Millimi { get; set; }

        void SutCek();
        void TopTutar();


    }
}
