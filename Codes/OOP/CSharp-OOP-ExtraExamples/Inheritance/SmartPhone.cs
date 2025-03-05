using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    public class SmartPhone:MobilePhone
    {
        public bool FrontCam { get; set; }
        public SmartPhone()
        {
            base.HasCamera = true;
            base._phoneType = "";
        }
        public SmartPhone(string brand ,string connectionType,bool hasCamera,bool isTouched,bool frontCam):base(hasCamera,isTouched,brand,connectionType)
        {
            base._phoneType = "Smart Phone";
            this.FrontCam = frontCam;

        }

        public string DoVideoCall()
        {
            return "Aranıyor ..... ";
        }




    }
}

