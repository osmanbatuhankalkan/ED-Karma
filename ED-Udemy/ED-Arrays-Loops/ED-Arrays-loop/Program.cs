namespace ArraysLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //şimdi sabit yazıyoruz fakat ilerleten zamanlarad bir DB den gelecek o şekilde dinamik versiyonunuda oluşturacağız.
            //Bu bu şekilde olmaz
            string kredi1 = "Hızlı Kredi";
            string kredi2 = "Maaşını Bankadan Alanlar....";
            Console.WriteLine(kredi1);
            Console.WriteLine(kredi2);
            //Bu şekil yapmalıyız yoksa değişikliklre kapalı bir yapı inşa etmiş oluruz.

            string[] krediler = new string[7];
            krediler[0] = "Hızlı Kredi";
            krediler[1] = "kredi2";
            krediler[2] = "kredi3";
            krediler[3] = "kredi4";
            krediler[4] = "kredi5";
            krediler[5] = "kredi6";
            krediler[6] = "kredi7";
            
            //DÖNGÜLER
            for (int i=1;i<krediler.Length;i++)
            {
                Console.WriteLine(krediler[i]);
                //Bunu fronted kısmında select penceresine kredi seçeneklerini alt alta sıralamışsın gibi hayal edebilirsin.
            }
            Console.WriteLine("For Döngüsü Bitti.");
            
            //Diziler için yapılmış bir döngü türü foreach
            foreach (string secenekKredi in krediler)
            {
                Console.WriteLine(secenekKredi);//Burada fark ettiysek indeks operatörü vermedik. Foreach döngümüzü oluştururken veridğimiz TAKMA İSİM'i kullandık.
                
            }            
            Console.WriteLine("Foreach Döngüsü Bitti.");
            
            //While döngüsü: şartımız geçerli olduğu sürece sen onu döndür demektir.
             while (true)//Bu döngüyü durdurmazsan sonsuz dömgüye girer
             {
                 Console.WriteLine("OBK");
                 break;
             } 
            
            
            //Bu blok aynı yukarıdaki for döngüsünün karşlığıdır.
            int sayac = 0;
            while (sayac<7)
            {
                Console.WriteLine(krediler[sayac]);
                sayac++;
            }
            Console.WriteLine("While Döngüsü Bitti.");
            
            //Do-While döngüsü
            //Bunun whiledan farkı nedir bir kere bile olsa do kesinlikle çalışır sonra while geçer.Eski zamanlardan kalma bir döngüdür.
            //illa şart geçerli olmaasada bit kere dönsün diyorsan kullanırsın.
            int sayac2 = 0;
            do
            {
                Console.WriteLine(krediler[sayac2]);
                sayac2++;
            } while (sayac2 < 7);
        }
    }
}