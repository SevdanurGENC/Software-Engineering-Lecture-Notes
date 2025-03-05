using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class.Models
{  
    //Object nedir :  Özellikleri ve eylemleri olan class ile türetilen yapılara denir. 
     //Class nedir : Sınıf neslerinin şablonudur .Class içerisinde nesnelerin durumları ile ilgili işlemleri barındırır.
    class Person
    {
    //Field nedir : Class yada sturct içerisinde tanımlanan dışarıya kapalı değişkenler . 
    //  privete int sayi ; 

    //Property nedir : Prop fielda değer atamak ve fieldaki değeri okumak çin kullanılan aracı bir yapdır .. Prop bir değer ataması gerçekleşirken set metotdu , prop içinde okuma gerçekleşirgekn get metot kullanılır. 

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int  Weight { get; set; }
        public int Height { get; set; }
    }
}
