using System;

namespace class_Yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu konu aslında basit fakat gerçek hayat ile bağdaştırılmakta genelde sorun yaşandığı için öğrenmek ve kafaya oturtmak biraz zor oluyor
            //Şimdi tanımlayacağımız yapıda bir sürü öğrenci olabileceği için list of olarak tanımladık OOP olmadan değişiklikleri tanımlamak zor, sonradan gelen değişikliklere esneklik göstermekte zorlanmasınlar diye
            
            //Zor olacak Örnek
            List<string> isimler = new List<string>() { "Engin", "Derin", "Salih" };
            List<int> yaslar = new List<int>() { 35, 6, 9 };
            List<string> mailler = new List<string>() { "asd@hotmail", "dfg@gmail.com", "sdadf@yandex.com" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(isimler[i]+" "+yaslar[i]+ " "+mailler[i]);
            }
            //Burada bir zaafiyet var her şey 3 lü sisteme bağlı çalışıyor dışarıdan gelecek herhangi bir sadece isime,yaslara yada maillere veri girişi
            //bu düzenli yapıyı bozacak ve herkesin bilgileri yanlış veriliecektir.

            Console.WriteLine("************************************************ CLASSLARIN KULLANILDIĞI KISIM *********************************************************");
            //String dediğimiz ifadede aslında arka planda classtır.
            Student ogrenci1 = new Student();
            ogrenci1.FirstName = "Osman Batuhan";
            ogrenci1.Age = 23;
            ogrenci1.Mail = "abc@hotmail.com";
            
            Student ogrenci2 = new Student();
            ogrenci2.FirstName = "Batuhan";
            ogrenci2.Age = 24;
            ogrenci2.Mail = "sadfg@gmail.com";
            
            Student ogrenci3 = new Student();
            ogrenci3.FirstName = "Kuzey";
            ogrenci3.Age = 30;
            ogrenci3.Mail = "qwerty@yandex.com";
            
            List<Student> students = new List<Student>() { ogrenci1, ogrenci2, ogrenci3 };
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName+" "+student.Age+" "+student.Mail);
            }
        }
    }
}

