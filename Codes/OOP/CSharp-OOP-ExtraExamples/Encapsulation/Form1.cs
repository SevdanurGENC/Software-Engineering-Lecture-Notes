using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.OOP_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            Urun urn1 = new Urun();
            urn1.Id = Convert.ToInt32(txtUrunId.Text);
            urn1.Ad = txt_Aciklama.Text;
            urn1.Fiyat = Convert.ToDouble(txt_Fiyat.Text);


            MessageBox.Show($"Ürün Id: {urn1.Id} \n Ürün Adı : {urn1.Ad} \n Ürün Fiyat : {urn1.Fiyat}");
        }
    }
}
