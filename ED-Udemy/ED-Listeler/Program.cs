using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[] { "Ankara", "İstanbul", "Antalya" };
            Console.WriteLine(sehirler.Length);

            //sehirler[3] = "İzmir";//index sınırlarının dışında kaldı 
            
            sehirler = new string[4];
            sehirler[3] = "izmir";
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
                //Peki neden hepsi gelmedi?
                //Cünkü new dediğimizde baştan oluşturuyoruz ilk new de 3 adet index aldık fakat sonrasında yeni newimiz 4 indexlik yeri baştan yarattı ve izmiri ekledik
                //yaratılan indeksler sıfırlanıp 4 blok yer ayrılıp onun 1 tanesine sadece izmir yerleştiği için
                //Kısaca bir şey newlenirse her şey baştan oluşur.
            }

            List<string> sehirler2 = new List<string>() { "Ankara", "İstanbul", "İzmir" };//Biz burada array değilde list olarak tanımladık.String diyerek sadece metinsel bir şey ekleyebileceğimizi belirttik.
            Console.WriteLine(sehirler2.Count);//0 verdi listelerde biz eleman sayısı vermiyoruz.
            //liseteler aslında arka planda yine dizilere çıkıyor.
            
            sehirler2.Add("Yozgat");
            sehirler2.Add("Çorum");
            sehirler2.Add("Kastamonu");
            foreach (var sehir in sehirler2)
            {
                Console.WriteLine(sehir);
            }
            sehirler2.Remove("İzmir");
            bool sonuc = sehirler2.Contains("Antalya");//Bir elemanın lisetede olup olmadığını döndürür bir sürü görevi vardır. kendinde incele öğren.
            //Bizim bu bölümde amacımız arrayların bir sonraki kullanımı olan ve daha çok kullanılan listlerdir.
        }
    }
}

