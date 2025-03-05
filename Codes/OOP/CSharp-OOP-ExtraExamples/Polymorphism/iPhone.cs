using System.Media;
namespace CokBicimlilik
 
{
    public class iPhone:BasePhone
    {
        public override void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(@"C:\Users\sakiv\Desktop\Hafta Sonu .net\OOP\OOP_ileri\CokBicimlilik\src\iphone.wav"))
            {
                player.PlaySync();
            }

        }
    }
}
