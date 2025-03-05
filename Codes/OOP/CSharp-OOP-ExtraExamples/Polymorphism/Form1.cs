using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokBicimlilik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia();
            nokia.Brand = "Nokia";
            nokia.Model = "N720";
            nokia.CallSound();
            MessageBox.Show("Telefon Markası : "+nokia.Brand+"\nTelefon Model : "+ nokia.Model);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.Brand = "Samsung";
            samsung.Model = "s10 ";
            samsung.CallSound();
            MessageBox.Show($"Telefon Marka : {samsung.Brand} \n Telefon Model : {samsung.Model} ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iPhone iphone = new iPhone();
            iphone.Brand = "Apple";
            iphone.Model = "Iphone 7";
            iphone.CallSound();
            MessageBox.Show($"Telefon Marka : {iphone.Brand} \n Telefon Model : {iphone.Model} ");
        }
    }
}
