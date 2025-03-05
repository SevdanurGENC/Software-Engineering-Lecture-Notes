using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Constructor
{
    public class Araba
    {
        //Consturctor Tanımlama : 
        //Property 'lere bu şekilde daha önceki konularda değer vermeyi gördük 
        //Ctor metotların parametreleri ,içerisinde bulunduğu sınıfın hangi prop'lerine değer atamk istiyor isek dümdüz o şeklide yazılılr ve varsayılan  olarak sınıfımzıdaki bütün prop'lere yapıcı metodumuz üzerinmden değer verilir.
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Motor { get; set; }

        public Araba(string marka ,string model ,int motor )
        {
            Marka = marka;
            Model = model;
            Motor = motor;
        }
  



    }
}
