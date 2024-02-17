using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PersonManager: IApplicantService 
//Vatandaşa bir maske verdiğimiz kısım burada olacak.
{
    //encapsulation
    public void ApplyForMask(Person person) //fonksiyon metot adı verilir. Sıklıkla kullanılacak şeyleri böyle metotların fonksiyonların içerisine yazıyoruz.
    {
        
    }

    public List<Person> GetList()//maske alan kişilerin listesini dökmek için
    {
        return null;
    }

    public bool CheckPerson(Person person)//kontrol edilecek alan kişiler bu adam doğru adammı
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikDogrulaAsync(
                new TCKimlikDogrulaRequest
                (new TCKimlikDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName,
                    person.DateOfBirthYear)))
            .Result.Body.TCKimlikDogrulaResult;
    }
}