using System;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new Vatandas();//Bir adet vatandas nesnesi oluşturdum buna instance deniyor.
            //** Bir classın içinde bir değişken tanımlanılırsa sadece o class içersinde kullanılabilir.(Public diyerek bunu aşabiliriz)
            SelamVer("batuhan");
            SelamVer();//Default Parametre
            //Bir işi yapcak işi bir bloğa koyup sonrasında çağırıyorsun
            int sonuc = Topla(3, 5);  
            
            //diziler / Arrays

            string ogrenci1 = "Osman";
            string ogrenci2 = "Batuhan";
            string ogrenci3 = "Kalkan";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);
            
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Osman";
            ogrenciler[1] = "Batuhan";
            ogrenciler[2] = "Kalkan";
            //ogrenciler[3] ="asd";

            ogrenciler = new string[4];
            ogrenciler[3] = "asd";
            //burada artık yazılabilir oldu fakat sadece bu yazıldı neden ? çünkü referans tipler konusuyla bağlantılı stack ve heap
            //

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            
            //** Şimdi önemli bir noktaya geldik dikkat etmemiz gereken Referans tipte değerlerimiz ve Değer tipte değelerimiz.
            //** Zaten Kağıda detaylı bir şekilde not alıp çalıştın, geri döndüğünde burada hatırlamazsan oraya bak.
            
            //** new ile yarattığımız değerlerimiz referans tipte oluyor stack kısmında sehirler1 ve sehirler2 tutulurken karşılarındaki değerlerimiz heap bölgemizde tutulmakta
            //biz aşşağıda sehirler1 imizin refere ettiği yeri sehirler2 de işaret etsin diyoruz ve artık sehirler2  heapte kendi tuttuğu değerleri işaret etmeyi bırakıp sehirler1 in tuttuğu teri refere ediyor
            //peki eski yere ne oluyor garbage collector onun icabına sonra bakıyor.
            //Önemli ayırdım şimdi değer tiplerede bakacağız sistem böyle işlemiyor orada
            string[] sehirler1 = new[] { "Ankara", "istnabul", "izmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            Console.WriteLine(sehirler2[1]);
            Console.WriteLine(sehirler2[2]);
            
            //Değer tipler: İNT,DOUBLE,BOOL değer tiptir. Burada her şey 'STACK' üzerinden gider.
            //Burada başta stackteki sayi1 heapte 10, sayi 2 ise 20 yi tutmakta.
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1; //sayi2 burada artık 10 u tutuyor
            sayi1 = 30; //sayi1 imiz 30 u
            //sayi2 = ??? // Burada değerimiz hala 10 çünkü sayi2 ye sayi1i atayınca değeri aradık ve iş bitti.Değer tiplerde sayıyı atadın iş bitti mantığı vardır. Artık sayi1, sayi2 yi etkileyemez.

            Person person1 = new Person();
            person1.FirstName = "Osman Batuhan";
            person1.LastName = "Kalkan";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 123;
            
            Person person2 = new Person();
            person2.FirstName = "Murat";
            //String referanstir fakat biz genelde değer tipmiş gibi kullanırız aklımızda bulunsun !!(char arraydir string)

            foreach (string sehir in sehirler1) //Nedir bu foreach? Foreach ile Biz dizi formatındaki değeleri dönüyoruz.Elimizdeki diziyi in den sonra şuradan başlayıp tek tek dolaş demek) 
            {
                Console.WriteLine(sehir);
            }
            //MyList
            //Generic koleksiyon denilen bir yapı var artık arrayleri az kullanmamızı sağlıyor.
            List<string> yeniSehirler1 = new List<string>{"Ankara1", "İstanbul1", "İzmir1" };//Bu aslında 3 elemanlı bir liste. Liste ne demek bir dizi aslında.Arka planda bizim adımıza listeyi yöneten bir yapı var o referansları yöneten List bir refereans tiptir çünkü bir sınfıtır.
            yeniSehirler1.Add("Adana1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            //Bu koleksiyonlar bize çok geniş bir alan sağlıyor.O referans tipin referans probleminden kurtuluyoruz.O bizim yerimize şunu yapıyor "new" lediğiniz zaman, gidiyor eski verileri cebe atıyor. new lediğimiz zaman yeniliyor.O cebe attıklarını yerine koyuyor ve sonrasında eklediğinizi sona ekliyor.
            //şimdi gerçek Projemizle ilişkilendirebiliriz

            PttManager pttManager = new PttManager(new PersonManager());//Yabancılar için
            pttManager.GiveMask(person1);
        }

        static void SelamVer(string isim="isimsiz") //programın herhangi bir yerinde bu mesajı yazdırıcaz, Statik dememizin nedeni: bunu MAİN in içerisnde kullanıcağız o yüzden.
        {
            Console.WriteLine("Merhaba "+isim);
            //Bu blok bir METOT'dur Void metotlar sadece işi yapar. EMİR kipiyle çalışır.
            //Bİr değer oluşturmak istiyorsan değer return eden fonksiyonlardan yararlanırsın.
        }

        static int Topla(int sayi1= 2 , int sayi2 = 5 )// Bunlar yine default değerlerimiz yukarıda sayi1 ve sayi2 degerlerine deger tanımlanmaz ise gelecek değerlerimiz
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
            //biz bunları bir işlem sonucu bir ifade ortaya çıkıyor ve sonrasında oluşan yapıyı farklı yerlerde de kullanacaksam kullanıyoruz.
            //Bankacılık uygulamalarında hesaplamlar felan örnek verilebilir.

            //Bu FARK ÖNEMLİ**
            //*** eğer sadece git bunu yap, yaz, git bunu kaydet, veri tabanına kayıt etti bu "void".
            //*** Ama bana hesap yap, değer ver, ben onu kullanacağım dediğin zaman ozamanda "return" operasyonunda yararlanırsın.
        }
        
        private static void Degiskenler() //Refactor --> Extact --> Extract Method
        {
            string mesaj = "Merhabalar";
            int tutar = 100000;//Bu kısım projelerde db den gelir.
            int sayi = 100;
            bool girisYapmisMi;//2 tiptir true yada false döner

            string ad = "Osman Batuhan";
            string soyad = "Kalkan";
            int dogumYili = 2001;
            long tcNo = 12345678910;//uzun 11 hane tutabilir

            Console.WriteLine(100000*0.18);//Manuel hesaplamadır.
            Console.WriteLine(tutar*0.18);//%18 kdv olduğunu var sayalım bir tık daha clean koda yakındır.
        }
    }

    public class Vatandas
    {
        // public string ad = "Osman Batuhan";
        // public string soyad = "Kalkan";
        // public int dogumYili = 2001;
        // public long tcNo = 12345678910;//uzun 11 hane tutabilir
        
        //Bu değişkenleri PROPERTY dediğimiz yapıyla yönetiriz.
        //Yazıma dikkat ilk harfler büyük buna 'Pascal Casing' deniyor.
        
        //Çok az değişkenin geti seti değiştirilir,özel durumlarda değiştirlilir. Javada property yok get set blokları ayrı ayrı yazılıyor.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}

