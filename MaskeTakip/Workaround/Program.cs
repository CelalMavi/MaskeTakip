using Business.Concrete;
using Entities.Concrete;

class Program()
{

    static void Main(String[] args)
    {
        Person person1 = new Person();
        person1.FirstName = "Celal";
        person1.LastName = "Mavi";
        person1.DateOfBirthYear = 1999;
        person1.NationalId = 123;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

    }


}
