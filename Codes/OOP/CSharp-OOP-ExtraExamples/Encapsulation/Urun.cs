using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.OOP_Encapsulation
{
    public class Urun
    {
        //Encapsulation : Nesnelerin üyelerine yapılan erişimin kontrol altına alınmasını ve bu kontrolün nesnenin kendisi tarafından yapılmasını sağlamaktadır. Amaç field 'ları privete  yaparak  bu alanlara dışarıdan eirişimi önlemek ve get ve set metotları ile kontrol etmekç
        //Arka planda kodların gizlenmesi : oluşturulan class içerisinde kullanıcın işlemleri daha  kolay gerçekleşitirebilmesi ve bazı işlemleri Kapsülleyerek  tek işlemmiş gibi göstermek .Örneğin veri tabanı bağlantısına   işleminde  biz sadece bağlantı çerisinde open () metodunu kullanırırz. Fakat class içerisinde  kullanıcın aldığı parametreleri kullanarak  bağlantıyı gerçekleştirmek için bir çok haliz hazırda metot bulunur. bU işlemin amacı kullanıclar hızlıca open metotdunu bulabilsin ve kullanabilsin diyedir. .



        int _id;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;

            }
        }


        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }


        private double _fiyat;

        public double Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (value>0)
                {
                    _fiyat = value;
                }

                else
                {
                    System.Windows.Forms.MessageBox.Show("Olmaz ,Fiyat negatif olmaz");
                }
            }
        }




    }
}
