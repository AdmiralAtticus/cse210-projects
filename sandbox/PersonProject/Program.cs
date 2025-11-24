class Program
{
    static void Main(string[] args)
    {
        Person person = new("John", "Smith", 99, 220);
        Console.WriteLine(person.GetPersonInformation());

        Police myPolice = new Police("Taser and Jujitsu", "Barbara", "Gordon", 28, 150);
        Console.WriteLine(myPolice.PoliceInformation());
        Console.WriteLine(myPolice.GetPersonInformation());

        Doctor myDoctor = new Doctor("Knife, Needle", "Bob", "Pain", 45, 189);
        Console.WriteLine(myDoctor.DoctorInformation());
        Console.WriteLine(myDoctor.GetPersonInformation());

        Surgeon mySurgeon = new Surgeon("Surgeon", "Scalpel, Stethoscope", "Jason", "Evereda", 45, 166);
        Console.WriteLine(mySurgeon.SurgeonInformation());
        Console.WriteLine(mySurgeon.GetPersonInformation());
    }

}
