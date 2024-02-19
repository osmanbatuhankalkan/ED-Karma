using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete;

public class Person //Bu person classı maske takipteki kişileri temsil edecek.
{
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public long NationalIdentity { get; set; }
    public int DateOfBirthYear { get; set; }
    
}