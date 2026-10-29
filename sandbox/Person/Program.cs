class Program
{
    static void Main(string[] args)
    {
        Person myPerson = new Person("John", "Revelator", 50, 180.0);
        Console.WriteLine(myPerson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 45, 279, "Scalpel");
        Console.WriteLine(myDoctor.GetPersonInformation());
        Console.WriteLine(myDoctor.GetDoctorInformation());


        Police myPolice = new Police("Gary", "Godderidge", 61, 181, "Gun");
        Console.WriteLine(myPolice.GetPersonInformation());
        Console.WriteLine(myPolice.GetPoliceInformation());
    }
}