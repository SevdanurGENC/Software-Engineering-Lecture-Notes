using System.Media;
namespace CokBicimlilik
 
{
    public class Samsung:BasePhone
    {
        public override void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(@"C:\Users\sakiv\Desktop\Hafta Sonu .net\OOP\OOP_ileri\CokBicimlilik\src\samsung.wav"))
            {
                player.PlaySync();
            }

        }
    }
}
