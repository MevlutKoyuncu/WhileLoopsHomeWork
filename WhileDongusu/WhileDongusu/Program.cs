using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)

        {


            #region Sayı tahmin oyunu yapalım 2 oyunculu --------ÖDEV

            Console.WriteLine(@"///////////// SAYI TAHMİN OYUNUNA HOŞGELDİNİZ \\\\\\\\\\\\\\");
            Console.WriteLine("               KURALLAR\n- 1. Oyuncu sayıyı belirleyecektir.\n- 2. Oyuncu tahmin eden kişi olacaktır.\n- Oyuncunun toplam 5 deneme hakkı vardır. \n- Sayı 1-100 arasında olacaktır. \n- Oyuncu yanlış bir sayı tahmin ederse yakınlık derecesi aşağı-yukarı şeklinde belirtilecektir.");
            Console.WriteLine("Oyun Türünü Seçiniz. \n1* Zor 5 deneme hakkı \n2* Orta 10 deneme hakkı\n3* Kolay 20 deneme hakkı");
            int denemeHakki = 0;

            int secim = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("1. Oyuncu belirlediğiniz sayıyı giriniz = ");

            int oyuncu1 = Convert.ToInt32(Console.ReadLine());
            int Zor = denemeHakki = denemeHakki + 4;
            while (secim == 1 && oyuncu1 <= 100 && oyuncu1 > 0 && denemeHakki > -1)
            {



                Console.WriteLine("2. Oyuncu Tahmin ettiğiniz sayıyı giriniz = ");
                int oyuncu2 = Convert.ToInt32(Console.ReadLine());

                if (oyuncu2 == oyuncu1)
                {
                    Console.WriteLine("SAYIYI DOĞRU TAHMİN ETTİNİZ TEBRİKLER!!!");
                    denemeHakki = denemeHakki - 4;
                }
                else
                    if (oyuncu1 < oyuncu2)
                {
                    Console.WriteLine("Tahminini yanlıştır daha düşük bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
                }
                if (oyuncu1 > oyuncu2)
                {
                    Console.WriteLine("Tahminini yanlıştır daha yüksek bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
                }




                denemeHakki--;
                if (denemeHakki <= -1)
                {
                    Console.WriteLine("                     OYUN BİTTİ");
                }


            }
            int Orta = denemeHakki = denemeHakki + 14;
            while (secim == 2 && oyuncu1 <= 100 && oyuncu1 > 0 && denemeHakki > -1)
            {



                Console.WriteLine("2. Oyuncu Tahmin ettiğiniz sayıyı giriniz = ");
                int oyuncu2 = Convert.ToInt32(Console.ReadLine());

                if (oyuncu2 == oyuncu1)
                {
                    Console.WriteLine("SAYIYI DOĞRU TAHMİN ETTİNİZ TEBRİKLER!!!");
                    denemeHakki = denemeHakki - 14;
                }
                else
                    if (oyuncu1 < oyuncu2)
                {
                    Console.WriteLine("Tahminini yanlıştır daha düşük bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
                }
                if (oyuncu1 > oyuncu2)
                {
                    Console.WriteLine("Tahminini yanlıştır daha yüksek bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
                }




                denemeHakki--;
                if (denemeHakki <= -1)
                {
                    Console.WriteLine("                     OYUN BİTTİ");
                }


            }
            int Kolay = denemeHakki = denemeHakki + 19;
            while (secim == 3 && oyuncu1 <= 100 && oyuncu1 > 0 && denemeHakki > -1)
            {



                Console.WriteLine("2. Oyuncu Tahmin ettiğiniz sayıyı giriniz = ");
                int oyuncu2 = Convert.ToInt32(Console.ReadLine());

                if (oyuncu2 == oyuncu1)
                {
                    Console.WriteLine("SAYIYI DOĞRU TAHMİN ETTİNİZ TEBRİKLER!!!");
                    denemeHakki = denemeHakki - 19;
                }
                else
                    if (oyuncu1 < oyuncu2)
                {
                    Console.WriteLine("Tahminini yanlıştır daha düşük bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
                }
                if (oyuncu1 > oyuncu2)
                {
                    Console.WriteLine("Tahminini yanlıştır daha yüksek bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
                }




                denemeHakki--;
                if (denemeHakki <= -1)
                {
                    Console.WriteLine("                     OYUN BİTTİ");
                }


            }
            if (oyuncu1 > 100 || oyuncu1 < 0)
            {
                Console.WriteLine("Sayınız 1-100 arasında olmak zorundadır!");
            }

            #endregion


        }
    }
}
