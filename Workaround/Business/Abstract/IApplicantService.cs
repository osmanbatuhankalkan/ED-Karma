using Entities.Concrete;

namespace Business.Abstract;

public interface IApplicantService //iş sınıflarının interfaceleri bu şekilde isimlendirirlir
{
    // normalde bir classı yazmaya başlayınca alışkanlık haline gelsin. bir classı oluşturuğunuz zaman,
    // onun interfaceini oluşturmuş olduğunuzdan emin olun.
    
    // Sen interface'in içinde sadece metot imzası barındırabilirsin.
    //mesela aşşağıdaki şekildeki gibi
    void ApplyForMask(Person person); //fonksiyon metot adı verilir. Sıklıkla kullanılacak şeyleri böyle metotların fonksiyonların içerisine yazıyoruz.
    List<Person> GetList();//maske alan kişilerin listesini dökmek için
    bool CheckPerson(Person person); //kontrol edilecek alan kişiler bu adam doğru adammı
    
    // aşşağıdaki kod bloğunun metot imza şekli yukarıdaki gibidir.
    // public void ApplyForMask(Person person) //fonksiyon metot adı verilir. Sıklıkla kullanılacak şeyleri böyle metotların fonksiyonların içerisine yazıyoruz.
    // {
    //     
    // }
    //
    // public List<Person> GetList()//maske alan kişilerin listesini dökmek için
    // {
    //     return null;
    // }
    //
    // public bool CheckPerson(Person person)//kontrol edilecek alan kişiler bu adam doğru adammı
    // {
    //     return true;
    // }

}