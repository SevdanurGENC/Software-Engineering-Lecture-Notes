using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_interface
{
    public class Defans : IFutbolcu
    {
        public string AdiSoyadi { get; set; }
        public string FormaNumarasi { get; set; }
    
        public byte Refleks { get; set; }
        public byte Dayanıklılık { get; set; }
        public byte Agresiflik { get; set; }
        public byte AtilanGol { get; set; }
        public bool Millimi { get; set; }
        private byte _sutGucu;
        public byte SutGucu 
        {
            get
            {
                return _sutGucu;
            }

            set
            {
                if (value >70 )
                {
                    System.Windows.Forms.MessageBox.Show("Defasn oyuncusunun şut gücü 70'den yukarı olmamalıdır. ");
                }
                else
                {
                    _sutGucu = value;
                }
            }
                
        }


        public void SutCek()
        {
            throw new NotImplementedException();
        }

        public void TopTutar()
        {
            throw new NotImplementedException();
        }
    }
}
