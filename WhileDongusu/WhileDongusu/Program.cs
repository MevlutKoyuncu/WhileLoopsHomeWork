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


            #region Tanımlama

            //Bir işlemi birden çok kez yaptırmak istediğimiz döngü kullanırız
            //Döngü oluşturmak için
            //Kırılabilecek bir koşul(false'a düşmesi gereken)

            //Başlangıç değişkeni, koşul, iterasyon



            #endregion

            #region Nasıl Çalışır

            //if koşul parantezi true ise çalışır.
            //if (true)
            //{
            //    Console.WriteLine("Çalıştı");
            //}

            //while koşul parantezi true olduğu sürece çalışır
            //while (true)
            //{
            //    Console.WriteLine("Çalıştı");
            //}
            #endregion

            #region 0 - 100 arası sayıları yazdırınız.

            //int sayac = 0;

            //while (sayac<= 10)
            //{
            //    Console.WriteLine(sayac);
            //    //sayac = sayac +1;
            //    //sayac += 1;
            //    sayac++;

            //}

            #endregion

            #region  0 - 100 arası çift sayıları yazdırınız

            //int sayi = 0;
            //while (sayi <= 100)
            //{
            //    Console.WriteLine(sayi);
            //    sayi = sayi + 2;

            //}

            #endregion

            #region konsoldan alınan başlangıç değerinden 100'e kadar olan çift sayıları yazdırınız

            //Console.WriteLine("Sayınızı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //while (sayi <= 100)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    sayi++;

            //}

            #endregion

            #region 0 - 100 arasındaki pozitif sayıları yazdırınız

            //int sayi = 0;

            //while (sayi <= 100)
            //{
            //    Console.WriteLine(sayi);
            //    sayi ++;
            //}

            #endregion

            #region kullanıcıdan alınan sayı ile 100 arasındaki pozitif sayıları yazdırınız

            //int sayi = 0;

            //while (sayi <= 100)
            //{
            //    if (sayi >= 0)
            //        Console.WriteLine(sayi);
            //    sayi++;
            //}

            #endregion

            #region  İçi Dolu Çeyrek Baklava

            //*
            //**
            //***
            //****
            //*****
            //******

            //string nokta = "*";

            //while (nokta != "*******")
            //{
            //    Console.WriteLine(nokta);
            //    nokta = nokta + "*";

            //}



            #endregion

            #region İçi Dolu Çeyrek Baklava 2

            //int sayac = 0;
            //string satir = "";

            //while (sayac < 5)
            //{
            //    satir += "*";
            //    Console.WriteLine(satir);
            //    sayac++;
            //}

            #endregion

            #region 0 - 1000 arasında 4e bölünebilen kaç sayı var?

            //int sayi = 0;
            //int adet = 0;

            //while (sayi <= 1000)
            //{
            //    if (sayi % 4 == 0)
            //    {
            //        adet++;
            //    }
            //    sayi++;
            //}
            //Console.WriteLine("0 ile 100 arasında "+ adet + " adet sayı vardır.");


            #endregion

            #region ÖDEV------ 0 - 1000 arasında 4e bölünebilen kaç sayı var? toplamları ne? ------ÖDEV -------TAMAM

            //int sayi = 0;
            //int satir = 0;
            //int toplam = 0;
            //while (sayi <= 1000)
            //{


            //    sayi = sayi + 4;
            //    satir++;

            //    toplam = sayi + toplam; 

            //}

            //Console.WriteLine(toplam);






            #endregion

            #region ÖDEV----- Konsoldan alınan 5 sayının ortalama -----ÖDEV


            //double sayac = 1;
            //double toplam = 0;


            //while (sayac < 6)
            //{
            //    Console.WriteLine(sayac + ". Sayıyı giriniz = ");
            //    double sayi = Convert.ToDouble(Console.ReadLine());

            //    sayac++;
            //    toplam = toplam + sayi;

            //}
            //toplam = toplam / 5;
            //Console.WriteLine("5 Sayınızın Ortalaması= " + toplam);


            #endregion

            #region Konsoldan alınan sayıların ortalaması 

            //string secenek = "e";
            //int sayac = 0;
            //double toplam = 0;

            //while (secenek == "e")
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    toplam += Convert.ToDouble(Console.ReadLine());
            //    sayac++;
            //    Console.WriteLine("Sayi girilmeye devam edilsin mi e/h");
            //    secenek = Console.ReadLine();
            //    Console.Clear();
            //}

            //double ortalama = toplam / sayac;
            //Console.WriteLine("ortalamanız = " + ortalama);

            #endregion

            #region Kullanıcı giriş max 3 deneme -------ÖDEV -------TAMAM

            //Kullanıcı adı admin şifre 1234 ise hoşgeldin


            //Console.WriteLine(@"///////// SİSTEME HOŞGELDİNİZ \\\\\\\\\\");


            //int denemeHakki = 2;

            //while (denemeHakki >= 0)
            //{

            //    Console.Write("Kullanıcı adı giriniz =  ");
            //    string kullaniciAdi = Console.ReadLine();

            //    if (kullaniciAdi == "admin")
            //    {
            //        Console.Write("Şifrenizi giriniz = ");
            //        string sifre = Console.ReadLine();
            //        if (sifre == "1234")
            //        {
            //            Console.WriteLine("Sisteme Hoşgeldiniz. " + kullaniciAdi);
            //            denemeHakki = denemeHakki - 2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kullanıcı adınızı ve Şifrenizi kontrol edip tekrar deneyiniz. Kalan deneme hakkınız " + denemeHakki);
            //            if (denemeHakki == 0)
            //            {
            //                Console.WriteLine("Deneme hakkınız kalmamıştır. Sistem bloke edilecektir.");
            //            }
            //        }
            //    }
            //    else
            //    {

            //        Console.WriteLine("Kullanıcı adınızı ve şifrenizi kontrol edip tekrar deneyiniz. Kalan deneme hakkınız " + denemeHakki);
            //        if (denemeHakki == 0)
            //        {
            //            Console.WriteLine("Deneme hakkınız kalmamıştır. Sistem bloke edilecektir.");
            //        }
            //    }

            //    denemeHakki--;

            //}



            #endregion

            #region Kullanıcı Giriş Validation -------ÖDEV

            //Kullanıcı adı admin şifre 1234 ise hoşgeldin
            //Kullanıcı adı boş olamaz
            //şifre boş olamaz

            //Console.WriteLine(@"///////// SİSTEME HOŞGELDİNİZ \\\\\\\\\\");


            //int sayac = 0;
            //while (sayac < 5)
            //{
            //    if (sayac < 5)
            //    {
            //        Console.Write("Kullanıcı adınızı giriniz = ");
            //        string kullaniciAdi = Console.ReadLine();
            //        Console.Write("Şifrenizi giriniz = ");
            //        string sifre = Console.ReadLine();
            //        if (sifre == "1234" && kullaniciAdi == "admin")
            //        {
            //            sayac = sayac + 5;
            //            Console.WriteLine("Sisteme Hoşgeldiniz. " + kullaniciAdi);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Şifreniz veya kullanıcı adınız hatalıdır lütfen tekrar deneyiniz.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Şifreniz veya kullanıcı adınız hatalıdır lütfen tekrar deneyiniz.");

            //    }
            //    sayac++;
            //    if (sayac == 5)
            //    {
            //        Console.WriteLine("Çok fazla deneme yaptınız. Lütfen daha sonra tekrar deneyiniz.");
            //    }
            //}

            #endregion

            #region Kullanıcı Giriş Validation 2 ------ÖDEV---------------------------

            //Kullanıcı adı admin şifre 1234 ise hoşgeldin
            //Kullanıcı adı boş olamaz
            //şifre boş olamaz
            //Eğer bunlar boş ise tekrar kullanıcı adi istesin

            //Console.WriteLine(@"///////// SİSTEME HOŞGELDİNİZ \\\\\\\\\\");
            //Console.Write("Kullanıcı Adı Giriniz = ");
            //string kullaniciAdi = Console.ReadLine();
            //int sayac = 0;

            //while (sayac <= 3)
            //{
            //    if (kullaniciAdi == "admin")
            //    {
            //        Console.Write("Kullanıcı adınızda boşluk olamaz.");
            //        Console.Write("Şifrenizi giriniz = ");
            //        string sifre = Console.ReadLine();
            //        if (sifre == "1234")
            //        {
            //            Console.WriteLine("Hoşgeldiniz " + kullaniciAdi);
            //            sayac = sayac + 4;
            //        }

            //        else
            //        {
            //            Console.WriteLine("Şifreniz yanlıştır. Tekrar deneyiniz.");

            //        }

            //    }
            //    else

            //    {
            //        Console.WriteLine("Kullanıcı adınız ya da şifreniz yanlıştır. Tekrar deneyiniz.");
            //        sayac++;
            //    }

            //}


            #endregion

            #region Asalları da yazdıralım --------ÖDEV

            int sayi = 0;
            int kalan = 1;
            while (sayi < 100)
            {
              
                

            }


            #endregion

            #region Sayı tahmin oyunu yapalım 2 oyunculu --------ÖDEV

            //Console.WriteLine(@"///////////// SAYI TAHMİN OYUNUNA HOŞGELDİNİZ \\\\\\\\\\\\\\");
            //Console.WriteLine("               KURALLAR\n- 1. Oyuncu sayıyı belirleyecektir.\n- 2. Oyuncu tahmin eden kişi olacaktır.\n- Oyuncunun toplam 5 deneme hakkı vardır. \n- Sayı 1-100 arasında olacaktır. \n- Oyuncu yanlış bir sayı tahmin ederse yakınlık derecesi aşağı-yukarı şeklinde belirtilecektir.");
            //Console.WriteLine("Oyun Türünü Seçiniz. \n1* Zor 5 deneme hakkı \n2* Orta 10 deneme hakkı\n3* Kolay 20 deneme hakkı");
            //int denemeHakki = 0;

            //int secim = Convert.ToInt32(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("1. Oyuncu belirlediğiniz sayıyı giriniz = ");

            //int oyuncu1 = Convert.ToInt32(Console.ReadLine());
            //int Zor = denemeHakki = denemeHakki + 4;
            //while (secim == 1 && oyuncu1 <= 100 && oyuncu1 > 0 && denemeHakki > -1)
            //{



            //    Console.WriteLine("2. Oyuncu Tahmin ettiğiniz sayıyı giriniz = ");
            //    int oyuncu2 = Convert.ToInt32(Console.ReadLine());

            //    if (oyuncu2 == oyuncu1)
            //    {
            //        Console.WriteLine("SAYIYI DOĞRU TAHMİN ETTİNİZ TEBRİKLER!!!");
            //        denemeHakki = denemeHakki - 4;
            //    }
            //    else
            //        if (oyuncu1 < oyuncu2)
            //    {
            //        Console.WriteLine("Tahminini yanlıştır daha düşük bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
            //    }
            //    if (oyuncu1 > oyuncu2)
            //    {
            //        Console.WriteLine("Tahminini yanlıştır daha yüksek bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
            //    }




            //    denemeHakki--;
            //    if (denemeHakki <= -1)
            //    {
            //        Console.WriteLine("                     OYUN BİTTİ");
            //    }


            //}
            //int Orta = denemeHakki = denemeHakki + 14;
            //while (secim == 2 && oyuncu1 <= 100 && oyuncu1 > 0 && denemeHakki > -1)
            //{



            //    Console.WriteLine("2. Oyuncu Tahmin ettiğiniz sayıyı giriniz = ");
            //    int oyuncu2 = Convert.ToInt32(Console.ReadLine());

            //    if (oyuncu2 == oyuncu1)
            //    {
            //        Console.WriteLine("SAYIYI DOĞRU TAHMİN ETTİNİZ TEBRİKLER!!!");
            //        denemeHakki = denemeHakki - 14;
            //    }
            //    else
            //        if (oyuncu1 < oyuncu2)
            //    {
            //        Console.WriteLine("Tahminini yanlıştır daha düşük bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
            //    }
            //    if (oyuncu1 > oyuncu2)
            //    {
            //        Console.WriteLine("Tahminini yanlıştır daha yüksek bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
            //    }




            //    denemeHakki--;
            //    if (denemeHakki <= -1)
            //    {
            //        Console.WriteLine("                     OYUN BİTTİ");
            //    }


            //}
            //int Kolay = denemeHakki = denemeHakki + 19;
            //while (secim == 3 && oyuncu1 <= 100 && oyuncu1 > 0 && denemeHakki > -1)
            //{



            //    Console.WriteLine("2. Oyuncu Tahmin ettiğiniz sayıyı giriniz = ");
            //    int oyuncu2 = Convert.ToInt32(Console.ReadLine());

            //    if (oyuncu2 == oyuncu1)
            //    {
            //        Console.WriteLine("SAYIYI DOĞRU TAHMİN ETTİNİZ TEBRİKLER!!!");
            //        denemeHakki = denemeHakki - 19;
            //    }
            //    else
            //        if (oyuncu1 < oyuncu2)
            //    {
            //        Console.WriteLine("Tahminini yanlıştır daha düşük bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
            //    }
            //    if (oyuncu1 > oyuncu2)
            //    {
            //        Console.WriteLine("Tahminini yanlıştır daha yüksek bir tahmin yapmalısınız. Kalan deneme hakkınız " + denemeHakki);
            //    }




            //    denemeHakki--;
            //    if (denemeHakki <= -1)
            //    {
            //        Console.WriteLine("                     OYUN BİTTİ");
            //    }


            //}
            //if (oyuncu1 > 100 || oyuncu1 < 0)
            //{
            //    Console.WriteLine("Sayınız 1-100 arasında olmak zorundadır!");
            //}

            #endregion


        }
    }
}
