using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ARKADASMI_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtBoxX.Text);

            int toplam_x = 0;
            ListBox_X.Items.Clear();
            Txt_Toplam_X.Text = "";
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    ListBox_X.Items.Add(i.ToString());
                    toplam_x += i;
                }
                Txt_Toplam_X.Text = toplam_x.ToString();
            }


            int y = Convert.ToInt32(TxtBoxY.Text);
            int toplam_y = 0;
            ListBox_Y.Items.Clear();
            Txt_Toplam_Y.Text = "";
            for (int i = 1; i < y; i++)
            {
                if (y % i == 0)
                {
                    ListBox_Y.Items.Add(i.ToString());
                    toplam_y += i;
                }
                Txt_Toplam_Y.Text = toplam_y.ToString();

            }

            label_Toplam.Visible = true;
            label_X.Visible = true;
            label_Y.Visible = true;
            ListBox_X.Visible = true;
            ListBox_Y.Visible = true;
            Txt_Toplam_X.Visible = true;
            Txt_Toplam_Y.Visible = true;

        }

        private void button_Son_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(Txt_Toplam_X.Text);
            int sayi2 = Convert.ToInt32(Txt_Toplam_Y.Text);
            int sayi3 = Convert.ToInt32(TxtBoxY.Text);
            int sayi4 = Convert.ToInt32(TxtBoxX.Text);

            if (sayi1 == sayi3 && sayi2 == sayi4)
            {
                MessageBox.Show("Girdiginiz sayilar Arkadasdir.");
            }

            else
            {
                MessageBox.Show("Girdiniz sayilar Arkadas degildir.");
            }
        }
    }
}
