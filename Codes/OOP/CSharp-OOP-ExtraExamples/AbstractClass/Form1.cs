using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Gitar_Click(object sender, EventArgs e)
        {
            Gitar gitar = new Gitar();
            gitar.Markasi = "Yamaha";
            gitar.Aciklamasi = "Dikkat et pahalıdır.";
            string ses=gitar.Cal();


            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Test1";
            muzisyen.Soyadi = "Gitarci";
            muzisyen.CaldıgıEnstruman = gitar;


            MessageBox.Show($"Gitarın Adı : { muzisyen.Adi} \n Gitaristin Soyadi : {muzisyen.Soyadi} \n Çaldığı enst sesi : {ses} \n çaldığı aletin markasi : {muzisyen.CaldıgıEnstruman.Markasi}");
        }

        private void btnBateri_Click(object sender, EventArgs e)
        {
            Bateri bateri = new Bateri();
            bateri.Markasi = "Yamaha";
            bateri.Aciklamasi = "Dikkat et pahalıdır.";
            string ses = bateri.Cal();


            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Test2";
            muzisyen.Soyadi = "Baterici";
            muzisyen.CaldıgıEnstruman = bateri;


            MessageBox.Show($"Müzisyen Adı : { muzisyen.Adi} \n  Soyadi : {muzisyen.Soyadi} \n Çaldığı enst sesi : {ses} \n çaldığı aletin markasi : {muzisyen.CaldıgıEnstruman.Markasi}");
        }

        private void btnYanFulut_Click(object sender, EventArgs e)
        {
            YanFulut yanFulut = new YanFulut();
            yanFulut.Markasi = "Yamaha";
            yanFulut.Aciklamasi = "Dikkat et pahalıdır.";
            string ses = yanFulut.Cal();


            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Test1";
            muzisyen.Soyadi = "Gitarci";
            muzisyen.CaldıgıEnstruman = yanFulut;


            MessageBox.Show($"Müzisyen Adı : { muzisyen.Adi} \n  Soyadi : {muzisyen.Soyadi} \n Çaldığı enst sesi : {ses} \n çaldığı aletin markasi : {muzisyen.CaldıgıEnstruman.Markasi}");
        }
    }
}
