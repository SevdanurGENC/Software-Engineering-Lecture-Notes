using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    
   public class BasePhone
    {
        protected string _phoneType;
        protected string _connectionType;
        private string _brand;

        public BasePhone()
        {
            _phoneType = "Ahizeli Telefon";
        }

        public BasePhone(string brand ,string connectionType)
        {
            _brand = brand;
          _connectionType = connectionType;
            _phoneType = "Ahizeli Telefon..";
        }


        protected string Brand
                   
        {
            get { return this._brand; }
            set { this._brand = value; }

        }

        protected string PhoneType
        {
            get { return this._phoneType; }
            //set { _phoneType =value}

        }

        protected string ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        public virtual string Cal()
        {
            return "";
        }

        public virtual string ConnectionStatus()
        {
            return "Kablolu bağlantı var"; 
        }

        //Virtual metot (sanal metotlar), base class (temel sınıf) içinde bildirilmiş ve derrived class (türemiş sınıf) içinde  de tekrar bildirilebilen metotlardır. Böylece sanal metotlar kullanılarak  nesne yönelimli programlamada çok sık başvurlan çok biçimlilik kullanılmış olur. (Polimorphizm) alt sınıflardaki metotlar ilgili sınıflar içerisine ovveride edilerek base sınıftaki möetot devre dışı bıraklır. 

    }
}
