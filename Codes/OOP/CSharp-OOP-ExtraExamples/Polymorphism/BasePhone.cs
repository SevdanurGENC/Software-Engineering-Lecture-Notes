using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik
{
    public class BasePhone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }


        public string Call()
        {
            return "Çağrı atılıyor..";
        }
        //using sysytem içerisinde kullanılan nesnenin Garbage Collector tarafından temizlenmesini beklemez. .Kullanım bittikten sonra ram'dan silinir.

        //Environment.CurrentDirectory =>> Bin içerisindeki Debug klaösrünün altını ana dizin olarak baz alacaktır. 

        public virtual void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer( @"C:\Users\sakiv\Desktop\Hafta Sonu .net\OOP\OOP_ileri\CokBicimlilik\src\default.wav"))
            {
                player.PlaySync();
            }
         
        }


    }
}
