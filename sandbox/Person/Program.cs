class Program
{
    static void Main(string[] args)
    {
        Person myPerson = new Person("John", "Revelator", 50, 180.0);

        Console.WriteLine(myPerson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 45, 279, "Knife");
        Console.WriteLine(myDoctor.GetPersonInformation());

        Console.WriteLine(myDoctor.GetDoctorInformation());

    }
}