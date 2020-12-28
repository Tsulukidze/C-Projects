using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_3
{

    // ------------------------------  Urun Sinifi -----------------------------------------------

    class Urun
    {
        public string Ad;
        public string Marka;
        public string Model;
        public string Ozellik;
        public int StokAdedi;
        public int Hamfiyat;
        public int Secilenadet;

        public Urun(string ad, string marka, string model, string ozellik, int hamfiyat, int sec_adet)
        {

            Ad = ad;
            Marka = marka;
            Model = model;
            Ozellik = ozellik;
            Hamfiyat = hamfiyat;
            Secilenadet = sec_adet;

        }
    }

    //------------------------------------------------------------------------------------------------------------------

    //--------------------------------  Buzdolab Sinifi    -------------------------------------------------------------
    class Buzdolab : Urun
    {
        public int IcHacim;
        public string EnerjiSinifi;

        public Buzdolab(string ad, string marka, string model, string ozellik, int hamfiyat, int sec_adet, int hacim, string enerji) : base(ad, marka, model, ozellik, hamfiyat, sec_adet)
        {
            Random R1 = new Random(DateTime.Now.GetHashCode());
            StokAdedi = R1.Next(1, 100);
            IcHacim = hacim;
            EnerjiSinifi = enerji;
        }
    }



    //------------------------------------------------------------------------------------------------------------------

    //---------------------------------   Ceptel Sinifi -------------------------------------------------------------------
    class Ceptel : Urun
    {
        public int Hafiza;
        public int Ram;
        public int Pilgucu;

        public Ceptel(string ad, string marka, string model, string ozellik, int hamfiyat, int sec_adet, int hafiza, int ram, int pil) : base(ad, marka, model, ozellik, hamfiyat, sec_adet)
        {
            Random R2 = new Random(DateTime.Now.Second);
            StokAdedi = R2.Next(1, 100);
            Hafiza = hafiza;
            Ram = ram;
            Pilgucu = pil;
        }
    }


    //------------------------------------------------------------------------------------------------------------------

    //-------------------------------   Ledtv Sinifi -------------------------------------------------------------------

    class LedTV : Urun
    {
        public int EkranBoyutu;
        public string EkranCozunurlugu;

        public LedTV(string ad, string marka, string model, string ozellik, int hamfiyat, int sec_adet, int e_boy, string e_coz) : base(ad, marka, model, ozellik, hamfiyat, sec_adet)
        {
            Random R3 = new Random(DateTime.Now.Millisecond);
            StokAdedi = R3.Next(1, 100);
            EkranBoyutu = e_boy;
            EkranCozunurlugu = e_coz;
        }
    }


    //------------------------------------------------------------------------------------------------------------------

    //------------------------------   Laptop Sinifi -------------------------------------------------------------------
    class Laptop : Urun
    {
        public int ekran_boyutu;
        public string ekran_cozunurluk;
        public int dahili_hafiza;
        public int ram_kapasitesi;
        public int pil_gucu;

        public Laptop(string ad, string marka, string model, string ozellik, int hamfiyat, int sec_adet, int e_boy, string e_coz, int hafiza, int ram, int pil) : base(ad, marka, model, ozellik, hamfiyat, sec_adet)
        {
            Random R4 = new Random(DateTime.Now.Minute);
            StokAdedi = R4.Next(1, 100);
            ekran_boyutu = e_boy;
            ekran_cozunurluk = e_coz;
            dahili_hafiza = hafiza;
            ram_kapasitesi = ram;
            pil_gucu = pil;
        }

    }



    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
