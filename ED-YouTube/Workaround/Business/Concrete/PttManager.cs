using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

//Bu yapı mikro servislerin mimarilerinin alt yapısıdır.
//İNTERFACEler 'new'lenemezler
//Referans tutucudurlar.

public class PttManager:ISupplierService //Burayı cıplak bırakmak demek inheritance yada implemantasyon zaafiyeti demektir.O yüzden şimdi Abstract dosyamıza interface ekleyeceğiz 'ISupplierService'
{//pttmanagerin bağımlu oldupu sınıf yerine o sınıfın interfacelerii yazıyorum.
    
    private IApplicantService _applicantService;//Bunu field olarak kullanıyoruz.

    public PttManager(IApplicantService applicantService)//Constructor new yapıldığında çalışır.
    {
        _applicantService = applicantService; //Bunu sırf her yerde rahatça kullanabilmek için yukarıda global değişken olark tanımladık
        //sonrasında parametre değerimize eşitleyerek her yerde kullanabileceğimiz şekle getirdik.
    }
    
    public void GiveMask(Person person)//Maske veriyoruz.
    {
        PersonManager personManager = new PersonManager();
        if (_applicantService.CheckPerson(person) == true)//Bu adam doğru kişi ise bir maske vereceğiz.
        {
            Console.WriteLine(person.FirstName+" İçin Maske Verildi....");
        }
        else
        {
            Console.WriteLine(person.FirstName + " İçin Maske Verilemedi.....");
        }
    } 
}