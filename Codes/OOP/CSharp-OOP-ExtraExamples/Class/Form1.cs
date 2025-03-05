using OOP_Class.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersonelBilgileri_Click(object sender, EventArgs e)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Ahmet";
            firstPerson.Surname = "Tas";
            firstPerson.Age = 30;
            firstPerson.Id = 1;
            firstPerson.Height = 60;
            firstPerson.Height = 180;
            MessageBox.Show($"{firstPerson.Name} {firstPerson.Surname} isimli kişinin özellikleri : \n  Id 'si : {firstPerson.Id},Kilo  : {firstPerson.Weight},Boyu:  {firstPerson.Height},Yasi  : {firstPerson.Age}");

        }

        private void btnisimGetir_Click(object sender, EventArgs e)
        {
            //Instance Alma : Tanımlı olan bir sınıfın tipini nesne oluşturma işlemine (Örnekleme) denir
            Person firstPerson = new Person();
            firstPerson.Name = "Ahmet";
            firstPerson.Surname = "Tas";

            MessageBox.Show($"{firstPerson.Name} {firstPerson.Surname}");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Person FirstPerson = new Person();
            FirstPerson.Id = 1;
            FirstPerson.Name = "Ali";
            FirstPerson.Surname = "Kaya";
            FirstPerson.Age = 50;
            FirstPerson.Weight = 60;
            FirstPerson.Height = 170;

            Person SecondPerson = new Person();
            SecondPerson.Id = 2;
            SecondPerson.Name = "Buse";
            SecondPerson.Surname = "Tas";
            SecondPerson.Age = 35;
            SecondPerson.Weight = 70;
            SecondPerson.Height = 190;


            Person thirdPerson = new Person();
            thirdPerson.Id = 3;
            thirdPerson.Name = "Veli";
            thirdPerson.Surname = "Adam";
            thirdPerson.Age = 40;
            thirdPerson.Weight = 90;
            thirdPerson.Height = 160;


            List<Person> persons  = new List<Person>();
            persons.Add(FirstPerson);
            persons.Add(SecondPerson);
            persons.Add(thirdPerson);

            foreach (var item in persons)
            {
                if (item.Age==Convert.ToInt32( txt_Age.Text))
                {
                    MessageBox.Show($"{item.Name}");
                }
            }

        }
    }
}
