using Microsoft.VisualBasic;

class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        // if (person is Doctor d) 
        //     {
        //         Console.WriteLine(d.GetDoctorInformation());
        //     }
        // else if (person is Police p)
        //     {
        //         Console.WriteLine(p.GetPoliceInformation());
        //     }
        // else
        Console.Write($"Salary: {person.GetSalary()} - ");
        Console.WriteLine(person.GetPersonInformation());
        //     }
    }
    static void Main(string[] args)
    {
        // Person myPerson = new Person("John", "Revelator", 50, 180.0);
        // Console.WriteLine(myPerson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 45, 279, "Scalpel");
        // Console.WriteLine(myDoctor.GetDoctorInformation());


        Police myPolice = new Police("Gary", "Godderidge", 61, 181, "Gun");
        // Console.WriteLine(myPolice.GetPoliceInformation());


        List<Person> myPeople = new List<Person>();

        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach(Person person in myPeople)
        {
        //     if (person is Doctor doctor) 
        //     {
        //         Console.WriteLine(doctor.GetDoctorInformation());
        //     }
        //     else
        //     {
        //         Console.WriteLine(person.GetPersonInformation());
        //     }
            DisplayPersonInformation(person);
        }
    }
}