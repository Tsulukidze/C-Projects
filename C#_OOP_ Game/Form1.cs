/***********************************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				
**				Stundent Name:............:   Temur Tsulukidze
**		
*************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_Proje
{
    public partial class Form1 : Form
    {
      
        //AtikKutusu  sınıfından  farklı atıklar için kutuları tanımlamak.
        AtikKutusu Kutu_Organik;
        AtikKutusu Kutu_Cam;
        AtikKutusu Kutu_Kagit;     
        AtikKutusu Kutu_Metal;

        // Atik sınıfından nesneleri tanımlamak.
        Atik egg;
        Atik apple;
        Atik glass;
        Atik cup;
        Atik paper;
        Atik book;
        Atik ssd;
        Atik cola;

       
        Random random;    // Random sınıfından bir değişken .

        int puan = 0;    
        int zaman = 60;   // 60 saniye 


        public Form1()
        {
            InitializeComponent();


            //  AtıkKutusu sınıfından yukarıda tanımladığımız  kutuları oluşturmak.

            Kutu_Organik = new AtikKutusu(0); Kutu_Organik.Kapasite = 700;
            Kutu_Cam = new AtikKutusu(600); Kutu_Cam.Kapasite = 2200;
            Kutu_Kagit = new AtikKutusu(1000); Kutu_Kagit.Kapasite = 1200;
            Kutu_Metal = new AtikKutusu(800); Kutu_Metal.Kapasite = 2300;


            // Atık sınıfından yukarıda  tanımladığımız  nesneleri oluşturmak  ve PictureBox penceresine uyumluluk sağlamak.


            // Organil Atıklar
            egg = new Atik(150, "photo/egg.jpg");          pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;    
            apple = new Atik(120, "photo/apple.jpg");      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            // Cam Atıklar
            glass = new Atik(600, "photo/glass.jpg");      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            cup = new Atik(250, "photo/cup.jpg");          pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Kağıt Atıklar
            paper = new Atik(200, "photo/paper.jpg");      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            book = new Atik(250, "photo/book.jpg");        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Metal Atıklar
            ssd = new Atik(550, "photo/ssd.jpg");          pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            cola = new Atik(350, "photo/cola.jpg");        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


           
        }


        // PictureBox penceresine  farklı resimler getirir.
        private void  ResimGetir()
        {
            random = new Random();
            Image[] resimler = { egg.Image, apple.Image, glass.Image, cup.Image, paper.Image, book.Image, ssd.Image, cola.Image };
            pictureBox1.Image = resimler[random.Next(0, resimler.Length)]; 
        }



        // Timer çalışımı     NOT:  timer1in  intervali  form1.cs design kısmından  1000 olarak değistirdim.
        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;    // 1 saniye geri sayımak için.

            if (zaman == 0)   // Süre bitince
            {

                timer1.Stop();
                zaman = 60;


                btnBasla.Enabled = true;    // yeni oyun başlamak için.



                // Butun ayarların  temizlenip yeniden başlaması

                listBox_O.Items.Clear();
                Kutu_Organik.DoluHacim = 0;
                progressBar_O.Value = Kutu_Organik.DolulukOrani;

                listBox_C.Items.Clear();
                Kutu_Cam.DoluHacim = 0;
                progressBar_C.Value = Kutu_Cam.DolulukOrani;

                listBox_K.Items.Clear();
                Kutu_Kagit.DoluHacim = 0;
                progressBar_K.Value = Kutu_Kagit.DolulukOrani;


                listBox_M.Items.Clear();
                Kutu_Metal.DoluHacim = 0;
                progressBar_M.Value = Kutu_Metal.DolulukOrani;

                MessageBox.Show(" Tebrikler Toplam puanınız .:" + puan);

                puan = 0;
                lblPuan.Text = puan.ToString();

            }

            lblSure.Text = zaman.ToString();
        }



        // Yeni Oyun basdığımız zaman gerçekleşmesi gereken olaylar.
        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ResimGetir();

            btnOrganik.Enabled = true;
            btnCam.Enabled = true;
            btnKagit.Enabled = true;
            btnMetal.Enabled = true;
            btnKagit.Enabled = true;

            btnBasla.Enabled = false;       
        }


        //  Gelen resim Organik ise Organik butonun çalışma mantğı.
        private void btnOrganik_Click(object sender, EventArgs e)
        {

            // gelen resim yumurta olduğu durum.
            if (pictureBox1.Image == egg.Image)   
            {
                if (Kutu_Organik.Ekle(egg) == false )
                {
                    listBox_O.Items.Add(" Yumurta -" + egg.Hacim);
                    progressBar_O.Value = Kutu_Organik.DolulukOrani;
                    Kutu_Organik.DoluHacim = Kutu_Organik.DoluHacim + egg.Hacim;                    
                    ResimGetir();

                }
                
            }

            // gelen resim elma olduğu durum.
            if (pictureBox1.Image == apple.Image) 
            {
                if (Kutu_Organik.Ekle(apple) == false)
                {
                    listBox_O.Items.Add(" Elma -" + apple.Hacim);
                    progressBar_O.Value = Kutu_Organik.DolulukOrani;                    
                    Kutu_Organik.DoluHacim = Kutu_Organik.DoluHacim + apple.Hacim;
                    ResimGetir();


                }
            }

            // Organik Atık için Boşalt butonun  çalıştırabilecek hale getirmek
            if (Kutu_Organik.Bosalt() == true)  
                btnBosalt_O.Enabled = true;

        }


        private void btnBosalt_O_Click(object sender, EventArgs e)
        {
            listBox_O.Items.Clear();
            zaman += 3;
            Kutu_Organik.DoluHacim = 0;
            progressBar_O.Value = Kutu_Organik.DolulukOrani;
            puan = puan + Kutu_Organik.BosaltmaPuani;
            lblPuan.Text = puan.ToString();
            btnBosalt_O.Enabled = false;
            
        }

        private void btnKagit_Click(object sender, EventArgs e)
        {
            // gelen resim kağıt olduğu durum.
            if (pictureBox1.Image == paper.Image)
            {
                if (Kutu_Kagit.Ekle(paper) == false)
                {
                    listBox_K.Items.Add(" Kağıt -" + paper.Hacim);
                    progressBar_K.Value = Kutu_Kagit.DolulukOrani;
                    Kutu_Kagit.DoluHacim = Kutu_Kagit.DoluHacim + paper.Hacim;                    
                    ResimGetir();

                }
            }

            // gelen resim kitap olduğu durum.
            if (pictureBox1.Image == book.Image)
            {
                if (Kutu_Kagit.Ekle(book) == false)
                {
                    listBox_K.Items.Add(" Kitap -" + book.Hacim);
                    progressBar_K.Value = Kutu_Kagit.DolulukOrani;
                    Kutu_Kagit.DoluHacim = Kutu_Kagit.DoluHacim + book.Hacim;                   
                    ResimGetir(); 

                }
            }


            // Kağıt Atık için Boşalt butonun  çalıştırabilecek hale getirmek
            if (Kutu_Kagit.Bosalt() == true)
                btnBosalt_K.Enabled = true;

        }

        private void btnBosalt_K_Click(object sender, EventArgs e)
        {
            listBox_K.Items.Clear();
            zaman += 3;
            Kutu_Kagit.DoluHacim = 0;
            progressBar_K.Value = Kutu_Kagit.DoluHacim;
            puan = puan + Kutu_Kagit.BosaltmaPuani;
            lblPuan.Text = puan.ToString();
            btnBosalt_K.Enabled = false;
            

        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            // gelen resim CamBox olduğu durum.
            if (pictureBox1.Image == glass.Image)
            {
                if (Kutu_Cam.Ekle(glass) == false)
                {
                    listBox_C.Items.Add(" Cam Box -" + glass.Hacim);
                    progressBar_C.Value = Kutu_Cam.DolulukOrani;
                    Kutu_Cam.DoluHacim = Kutu_Cam.DoluHacim + glass.Hacim;                    
                    ResimGetir();

                }
            }

            // gelen resim Bardak olduğu durum.
            if (pictureBox1.Image == cup.Image)
            {
                if (Kutu_Cam.Ekle(cup) == false)
                {
                    listBox_C.Items.Add(" Bardak -" + cup.Hacim);
                    progressBar_C.Value = Kutu_Cam.DolulukOrani;
                    Kutu_Cam.DoluHacim = Kutu_Cam.DoluHacim + cup.Hacim;                    
                    ResimGetir();

                }
            }


            // Cam Atık için Boşalt butonun  çalıştırabilecek hale getirmek
            if (Kutu_Cam.Bosalt() == true)
                btnBosalt_C.Enabled = true;
        }

        private void btnBosalt_C_Click(object sender, EventArgs e)
        {
            listBox_C.Items.Clear();
            zaman += 3;
            Kutu_Cam.DoluHacim = 0;
            progressBar_C.Value = Kutu_Cam.DoluHacim;
            puan = puan + Kutu_Cam.BosaltmaPuani;
            lblPuan.Text = puan.ToString();
            btnBosalt_C.Enabled = false;
            

        }

        private void btnMetal_Click(object sender, EventArgs e)
        {
            // gelen resim SSD olduğu durum.
            if (pictureBox1.Image == ssd.Image)
            {
                if (Kutu_Metal.Ekle(ssd) == false)
                {
                    listBox_M.Items.Add(" SSD -" + ssd.Hacim);
                    progressBar_M.Value = Kutu_Metal.DolulukOrani;
                    Kutu_Metal.DoluHacim = Kutu_Metal.DoluHacim + ssd.Hacim;                    
                    ResimGetir();

                }
            }

            // gelen resim Kola olduğu durum.
            if (pictureBox1.Image == cola.Image)
            {
                if (Kutu_Metal.Ekle(cola) == false)
                {
                    listBox_M.Items.Add(" Kola -" + cola.Hacim);
                    progressBar_M.Value = Kutu_Metal.DolulukOrani;
                    Kutu_Metal.DoluHacim = Kutu_Metal.DoluHacim + cola.Hacim;                    
                    ResimGetir();
                }
            }


            // Metal Atık için Boşalt butonun  çalıştırabilecek hale getirmek
            if (Kutu_Metal.Bosalt() == true)
                btnBosalt_M.Enabled = true;
        }

        private void btnBosalt_M_Click(object sender, EventArgs e)
        {
            listBox_M.Items.Clear();
            zaman += 3;
            Kutu_Metal.DoluHacim = 0;
            progressBar_M.Value = Kutu_Metal.DoluHacim;
            puan = puan + Kutu_Metal.BosaltmaPuani;
            lblPuan.Text = puan.ToString();
            btnBosalt_M.Enabled = false;
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar_O.Value = Kutu_Organik.DolulukOrani;
            progressBar_C.Value = Kutu_Cam.DolulukOrani;
            progressBar_K.Value = Kutu_Kagit.DolulukOrani;
            progressBar_M.Value = Kutu_Metal.DolulukOrani;
            lblPuan.Text = puan.ToString();
            lblSure.Text = zaman.ToString();
        }


        // Çıkış Butonun çalışması 
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
