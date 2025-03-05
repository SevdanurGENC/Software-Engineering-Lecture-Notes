using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Araba araba2 = new Araba();
            //araba2.Marka = "Seat";
            //araba2.Model = "Leon";
            //araba2.Motor = 2000;

            Araba araba1 = new Araba("MERCEDES","C180",2000);
            MessageBox.Show(araba1.Marka+" "+araba1.Model);
        }
    }
}
