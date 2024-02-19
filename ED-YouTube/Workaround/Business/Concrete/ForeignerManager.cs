using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

//yani yabancının kuralını buraya türkün kuralını diğer tarafa yap
public class ForeignerManager : IApplicantService //yardımcıdan implamantemizi hızlıca yapıyoruz
{
    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public List<Person> GetList()
    {
        throw new NotImplementedException();
    }

    public bool CheckPerson(Person person)
    {
        throw new NotImplementedException();
    }
}