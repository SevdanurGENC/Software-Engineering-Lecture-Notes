using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
   public class MobilePhone:BasePhone
    {
    
       public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }

        public MobilePhone()
        {
            _phoneType = "Mobile Phone";     
        }

        public MobilePhone(bool hasCamera,bool isTouched,string brand,string connectionType) :base (brand,connectionType)
        {
            this.HasCamera=hasCamera;
            this.IsTouched = isTouched;
            base._phoneType = "Mobile Phone";

            ///this.brand=Brand
             
        }

        public string TakePhoto()
        {
            if (this.HasCamera)
            {
                return "You can take a photo";
            }
            else
            {
                return "There is no Camera ";
            }
            
        }
        public override string ConnectionStatus()
        {
            return base.ConnectionStatus();
        }




    }
}
