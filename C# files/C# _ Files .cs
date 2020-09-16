/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI...... ...:   NO: 1
**				ÖĞRENCİ ADI............:   Temur Tsulukidze
**				ÖĞRENCİ NUMARASI.......:   B181210563
**              DERSİN ALINDIĞI GRUP...:   C
****************************************************************************/


using System;
using System.IO;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string loc_w = @"Tsulukidze.txt";     // local_w --  yazacagimiz dosyanin adresi ve ismini tutar.
            StreamWriter yaz = new StreamWriter(loc_w);

            string loc_r = @"C:\Users\TSULUKIDZE\Desktop\Kayitlar.txt";  // local_r -- okuyacagimiz dosyanin adresi ve ismi tutar
            StreamReader read = new StreamReader(loc_r);

            int[] harf_Depo = new int[9];    // harflarin sayisini Depolamak icin kullanilir.

            int kayit_sayi = 22;  //  Var olan Ogrenci Sayisi.

            for (int i=0; i < kayit_sayi;i++)     // dosyaya yazdirma islemleri for dungusu ila  her ogrenci icin yapacaz.
            {

                char[] ayrici = { ',' };  // virgul kullandim yerleri ayrmak icin kullanilir.
                string harf_n = " "; // Notlarin (harfi olarak) tutmak icin kullanilir.


                string oku = read.ReadLine(); 
                string[] line = oku.Split(ayrici);  // okudumuz dosyadan  verileri , ayrici kullanarak line string dizisine atadik


                // ortalama Notu Hesaplamak icin.
                double ortalama = (Convert.ToDouble(line[2]) + Convert.ToDouble(line[3]) + Convert.ToDouble(line[4]) + Convert.ToDouble(line[5]))/4 ;



                // Hesapladimiz Notu  Harf olarak yazmak icin.
                if (ortalama >= 90)
                {
                    harf_n = "AA";
                    harf_Depo[0]++;
                }
                else if (ortalama >=85 && ortalama <90)
                {
                    harf_n = "BA"; 
                    harf_Depo[1]++;
                }
                else if (ortalama >= 80 && ortalama < 85)
                {
                    harf_n = "BB";
                    harf_Depo[2]++;

                }
                else if (ortalama >= 75 && ortalama < 80)
                {
                    harf_n = "CB";
                    harf_Depo[3]++;
                }
                else if (ortalama >= 65 && ortalama < 75)
                {
                    harf_n = "CC";
                    harf_Depo[4]++;
                }
                else if (ortalama >= 58 && ortalama < 65)
                {
                    harf_n = "DC";
                    harf_Depo[5]++;
                }
                else if (ortalama >= 50 && ortalama < 58)
                {
                    harf_n = "DD";
                    harf_Depo[6]++;
                }
                else if (ortalama >= 40 && ortalama < 50)
                {
                    harf_n = "FD";
                    harf_Depo[7]++;
                }
                else
                {
                    harf_n = "FF";
                    harf_Depo[8]++;
                }


                // Isim soysim ,   Ogr NO , ortalama Not  ve not harfini  yazmak icin .
                yaz.WriteLine(line[0] + "     "+line[1]+"     "+ortalama +"     " +harf_n);

            }
            yaz.WriteLine("");
            yaz.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            yaz.WriteLine("");

            //•	Sınıfın istatistiğini yani hangi harf notu grubundan kaç öğrenci aldi ve yüzdesini.

            yaz.WriteLine("AA sayisi = " + harf_Depo[0 ]+ "      "+  "Yuzde = %" + (harf_Depo[0] * 100) /kayit_sayi);
            yaz.WriteLine("BA sayisi = " + harf_Depo[1] + "      " + "Yuzde = %" + (harf_Depo[1] * 100) / kayit_sayi);
            yaz.WriteLine("BB sayisi = " + harf_Depo[2] + "      " + "Yuzde = %" + (harf_Depo[2] * 100) / kayit_sayi);
            yaz.WriteLine("CB sayisi = " + harf_Depo[3] + "      " + "Yuzde = %" + (harf_Depo[3] * 100) / kayit_sayi);
            yaz.WriteLine("CC sayisi = " + harf_Depo[4] + "      " + "Yuzde = %" + (harf_Depo[4] * 100) / kayit_sayi);
            yaz.WriteLine("DC sayisi = " + harf_Depo[5] + "      " + "Yuzde = %" + (harf_Depo[5] * 100) / kayit_sayi);
            yaz.WriteLine("DD sayisi = " + harf_Depo[6] + "      " + "Yuzde = %" + (harf_Depo[6] * 100) / kayit_sayi);
            yaz.WriteLine("FD sayisi = " + harf_Depo[7] + "      " + "Yuzde = %" + (harf_Depo[7] * 100) / kayit_sayi);
            yaz.WriteLine("FF sayisi = " + harf_Depo[8] + "      " + "Yuzde = %" + (harf_Depo[8] * 100) / kayit_sayi);

            yaz.WriteLine("");
            yaz.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");


            yaz.Close();

        }
    }
}