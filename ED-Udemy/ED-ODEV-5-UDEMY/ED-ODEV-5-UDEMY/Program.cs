using System;

namespace Odev_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sayıları 220 ve 284 olarak verdiğimizde arkadaş sayı çıkıyor mu ? //** EVET ARAKDAŞ SAYI ÇIKIYOR
            //Sayıları 17296 ve 18416 olarak verdiğimizde arkadaş sayı çıkıyor mu ? //** EVET ARKADAŞ SAYI ÇIKIYOR
            //Sayıları 200 ve 284 olarak verdiğimizde arakdaş sayı olmadığı çıkıyor mu ? //** HAYIR ARAKADŞ SAYI DEĞİLLERDİR
            
            Console.WriteLine("*************************** SAYİ ************************");
            int sayi1, sayi2;
            Console.WriteLine("Lütfen arkadaş olacak sayıları sırasıyla giriniz.");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());

            int poizitifTambölenler = 0;
            for (int i = 1; i <= sayi1; i++)
            {
                if(sayi1%i==0)
                {
                    Console.WriteLine(i);
                    poizitifTambölenler += i;

                }
            }
            int totalSayi = poizitifTambölenler - sayi1;
            Console.WriteLine("Pozitif Tam bölenleri Toplamı : "+totalSayi);
            
            Console.WriteLine("*************************** SAYİ2 ************************");
            int poizitifTambölenler2 = 0;
            for (int i = 1; i <= sayi2; i++)
            {
                if(sayi2%i==0)
                {
                    Console.WriteLine(i);
                    poizitifTambölenler2 += i;

                }
            }
            int totalSayi2 = poizitifTambölenler2 - sayi2;
            Console.WriteLine("Pozitif Tam bölenleri Toplamı : "+totalSayi2);
            
            Console.WriteLine("*************************** Doğrulama Kısmı ************************");
            if (sayi1 == totalSayi2)
            {
                Console.WriteLine("Sayılarımız Arkadaş Sayılardır");
            }
            else
            {
                Console.WriteLine("Sayılarımız Arkadaş Sayı Değildir.");
            }

        }
    }
    
}

