using System;
//classlar bir nesene ve o nesnesinin özellikleri olarak kullanabiliyor demiştik fakar başka özellik ve amaçlaralada kullanılmakta
//Javada da , c# da da bir class yapısıyla karşılaşmaktayız.
namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { ProductName = "Laptop", UnitPrice = 5000, UnitInStock = 5 };
            //P si büyük M si büyük yani bizim oradki ProductManagerimiz int a; dediğimiz deki intimiz gibi aslında
            ProductManager productManager = new ProductManager();//içerideki productManager ise bellekte bir kopyadır instance bir kopyadır.
            productManager.Add(product1);//Böyle bir parantez açama kapama var ise orada metot kullanılmıştır yani bir iş yapılmıştır.
        }
    }
}

