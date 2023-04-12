class Program {
    static void Main(string[] args) {
        Adaptee adaptee = new Adaptee();
        Target target = new Adapter(adaptee);

        Console.WriteLine("Adapter interface can call it's method with adapter client");

        Console.WriteLine(target.GetRequest());
    }
}