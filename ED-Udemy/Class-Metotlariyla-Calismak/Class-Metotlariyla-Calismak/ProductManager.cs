namespace metotlar;
//Ürünler ile yapılacak işlere biz metotlar diyoruz.classlar içerisindekş operasyonlar.
//Methods
//reusability: bir şeyi yapınca tekrar tekrar kullanabilmelisiniz.
public class ProductManager
{
    public void Add(Product product)//Bu parantezin triği de bu içerisine bir paramatre gelecek yani bir ürün gelecek
    {
        Console.WriteLine("Ürün eklendi: "+ product.ProductName);
    }
}