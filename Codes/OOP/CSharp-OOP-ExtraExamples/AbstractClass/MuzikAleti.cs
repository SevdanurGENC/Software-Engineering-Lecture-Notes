using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //Abstract class'lar sadece base class olarak davranmasını (yani kalitim edilebilmesi) ve kendi instance çıkartılmasını istediğimiz durumlarda kullanılır.
 public   abstract class MuzikAleti
    {
        //Abstract olarak işaretlenmiş tüm yapılar mutlaka ovveride edilmek zorundadır. 
        //Abstract classların en büyük özelliği, içerisinde abstract olan yada olmayan metotlar barındarabilirler. 
        //Abstract metodlar ,kalıtım aldığı class'ta implemnte edilerek kullanılacak metotlardır. Yani tanımlandığı yerlerde herhangi bir kod bloğu bulundurumazlar .


        public string Markasi { get; set; }
        public string Aciklamasi { get; set; }

        public   abstract string Cal();
    

    }
 


    //1)Ancak Absract metotlarımızı tanımlarken  bazı kurallara dikkat ediniz.. Bunlar aşağıdadır.. 
    //2)Abstract  metotlar ,private olarak tanımlanamazlar Çünkü private metotlar ,miras alınan classlar tarafından implement edilemediklerinden dolayı abstract yapsına ters düşer ...
    //3)Abstract metotlar sadece abstract classların içerisinde  tanımalnır .

    //4)Abstract metotlar ,virtual olarak tanımlanamazlar .Her abstract class bir virtual 'dır.  Abstaract class amacı  miras alındığı class  'da implemente  edilmek durumunda olduğu için virtual yazarsanız hata alırısınız. 
    // 5) Abstract metotlar  ,static olarak tanımlanamazlar .Static kavramı  ,class özelliği yada metod olduğu için instance çıkarmaya gerek yoktur .Halbuki  statik olmyana metotlar  instance metotlarıdır. .
    //6)Abstract metotların gövedi olmaz .çünkü olnar sadece miras alındığı class 'larda implement edilir.

}
