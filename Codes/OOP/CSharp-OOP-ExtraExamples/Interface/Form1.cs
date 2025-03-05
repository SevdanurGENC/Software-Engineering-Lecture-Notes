using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kaleci Volkan = new Kaleci()
        {
            AdiSoyadi = "Volkan Demirel",
            Agresiflik =10 ,
            FormaNumarasi = "01",
            Millimi=true,
            Refleks =60,
            SutGucu =5,
            
        };

        Defans defans = new Defans
        {
            AdiSoyadi = "Sabri sarıoğlu",
            Agresiflik = 98,
            FormaNumarasi = "100",
            Millimi = true,
            Refleks=1,
            SutGucu = 90
        };



        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(Volkan);
            listBox1.Items.Add(defans);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            //if (listBox1.SelectedItem.GetType()==typeof(Kaleci))
            //{
            // Kaleci k =   listBox1.SelectedItem as Kaleci;  
            //    foreach (PropertyInfo item in k.GetType ().GetProperties())
            //    {
            //        Label lbl = new Label();
            //        lbl.Text = string.Format(item.Name + ":" + item.GetValue(k));
            //        lbl.AutoSize = false;
            //        lbl.Width = flowLayoutPanel1.Width;
            //        flowLayoutPanel1.Controls.Add(lbl);

            //    }
            //}


            //else if (listBox1.SelectedItem.GetType()==typeof(Defans))
            //{
            //    Defans d = listBox1.SelectedItem as Defans;
            //    foreach (PropertyInfo item in d.GetType().GetProperties())
            //    {
            //        Label lbl = new Label();
            //        lbl.Text = string.Format(item.Name + ":" + item.GetValue(d));
            //        lbl.AutoSize = false;
            //        lbl.Width = flowLayoutPanel1.Width;
            //        flowLayoutPanel1.Controls.Add(lbl);
            //    }
            //}




            if (listBox1.SelectedItem != null &&listBox1.SelectedItem.GetType().GetInterface("IFutbolcu")!=null)
            {
                IFutbolcu futbolcu =(IFutbolcu)listBox1.SelectedItem;

                foreach (var item in futbolcu.GetType().GetProperties())
                {
                    Label lbl = new Label();
                    lbl.Text = string.Format(item.Name + " : " + item.GetValue(futbolcu));
                    lbl.AutoSize = false;
                    lbl.Width = flowLayoutPanel1.Width;
                    flowLayoutPanel1.Controls.Add(lbl);
                }
            }






        }
    }
}
