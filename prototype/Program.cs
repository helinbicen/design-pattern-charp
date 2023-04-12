class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Age = 20;
        p1.Name = "Dave Mustaine";
        p1.IdInfo = new IdInfo(99);

        Person p2 = p1.ShallowCopy();

        Person p3 = p1.DeepCopy();

        Console.WriteLine("Default values:");
        Console.WriteLine("   p1: ");
        DisplayValues(p1);
        Console.WriteLine("   p2:");
        DisplayValues(p2);
        Console.WriteLine("   p3:");
        DisplayValues(p3);

        p1.Age = 61;
        p1.Name = "David Mustaine";
        p1.IdInfo.IdNumber = 666;
        Console.WriteLine("\nValues changes to p1:");
        Console.WriteLine("   p1: ");
        DisplayValues(p1);
        Console.WriteLine("   p2:");
        DisplayValues(p2);
        Console.WriteLine("   p3 :");
        DisplayValues(p3);
    }

    public static void DisplayValues(Person p)
    {
        Console.WriteLine("      Name: {0:s}, Age: {1:d}",
            p.Name, p.Age);
        Console.WriteLine("      Id: {0:d}", p.IdInfo.IdNumber);
    }
}
