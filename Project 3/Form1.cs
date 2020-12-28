using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Buzdolab fridge = new Buzdolab("fridge", "Philips", "P-2020", "smart", 3500, 0, 500, "A++");

            Ceptel mobile = new Ceptel("Galaxy", "Samsung", "S8", "edge", 2500, 0, 64, 4, 3400);

            LedTV tv = new LedTV("tv", "Sony", "Z-5", "Smart", 4000, 0, 55, "Full HD");

            Laptop comp = new Laptop("E-5", "Acer", "Aspire", "Nvidia", 5000, 0, 15, "Full HD", 1000, 8, 2500);



            label4.Text = tv.StokAdedi.ToString();
            label6.Text = fridge.StokAdedi.ToString();
            label11.Text = comp.StokAdedi.ToString();
            label16.Text = mobile.StokAdedi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LedTV TV = new LedTV("tv", "Sony", "Z-5", "Smart", 4000, Convert.ToInt32(numericUpDown1.Value), 55, "Full HD");
            TV.StokAdedi = Convert.ToInt32(label4.Text) - TV.Secilenadet;
            double KDV_1 = TV.Hamfiyat * TV.Secilenadet * 1.18;

            if (TV.Secilenadet <= TV.StokAdedi && TV.Secilenadet > 0)
            {
                label4.Text = TV.StokAdedi.ToString();
                listBox1.Items.Add(TV.Secilenadet);
                listBox2.Items.Add(TV.Ad);
                listBox3.Items.Add(KDV_1);
            }


            Buzdolab BZ = new Buzdolab("Buzdolabi", "Philips", "P-2020", "smart", 3500, Convert.ToInt32(numericUpDown2.Value), 500, "A++");
            BZ.StokAdedi = Convert.ToInt32(label6.Text) - BZ.Secilenadet;
            double KDV_2 = BZ.Hamfiyat * BZ.Secilenadet * 1.05;

            if (BZ.Secilenadet <= BZ.StokAdedi && BZ.Secilenadet > 0)
            {
                label6.Text = BZ.StokAdedi.ToString();
                listBox1.Items.Add(BZ.Secilenadet);
                listBox2.Items.Add(BZ.Ad);
                listBox3.Items.Add(KDV_2);
            }


            Laptop LP = new Laptop("Laptop", "Acer", "Aspire", "Nvidia", 5000, Convert.ToInt32(numericUpDown3.Value), 15, "Full HD", 1000, 8, 2500);
            LP.StokAdedi = Convert.ToInt32(label11.Text) - LP.Secilenadet;
            double KDV_3 = LP.Hamfiyat * LP.Secilenadet * 1.15;

            if (LP.Secilenadet <= LP.StokAdedi && LP.Secilenadet > 0)
            {
                label11.Text = LP.StokAdedi.ToString();
                listBox1.Items.Add(LP.Secilenadet);
                listBox2.Items.Add(LP.Ad);
                listBox3.Items.Add(KDV_3);

            }

            Ceptel TL = new Ceptel("Cep-Telefon", "Samsung", "S8", "edge", 2500, Convert.ToInt32(numericUpDown4.Value), 64, 4, 3400);
            TL.StokAdedi = Convert.ToInt32(label16.Text) - TL.Secilenadet;
            double KDV_4 = TL.Hamfiyat * TL.Secilenadet * 1.20;

            if (TL.Secilenadet <= TL.StokAdedi && TL.Secilenadet > 0)
            {
                label16.Text = TL.StokAdedi.ToString();
                listBox1.Items.Add(TL.Secilenadet);
                listBox2.Items.Add(TL.Ad);
                listBox3.Items.Add(KDV_4);
            }

            double Toplam_KDV = KDV_1 + KDV_2 + KDV_3 + KDV_4;
            label25.Text = Toplam_KDV.ToString() + "TL";


            decimal sum = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value;
            if (sum != 0)
                button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            label25.Text = "";

            button1.Enabled = true;

        }
    }
}
