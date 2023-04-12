class Program
{
    static void Main(string[] args)
    {
        // The client code.
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        if (s1 == s2)
        {
            Console.WriteLine("Variables contain same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed. Variables contain different instances.");
        }
    }
}
