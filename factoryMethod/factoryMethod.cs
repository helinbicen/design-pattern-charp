using System;


abstract class Creator
{
    public abstract Product FactoryMethod();

    public string MyOperation()
    {
        var product = FactoryMethod();
        var result = "Creator: The same creator's code has just worked with"
            + " " + product.OperationNumber();

        return result;
    }
}
public interface Product
{
    string OperationNumber();
}
class ConcreteCreator1 : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}

class ConcreteCreator2 : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProduct2();
    }
}

class ConcreteProduct1 : Product
{
    public string OperationNumber()
    {
        return "CPNO1";
    }
}

class ConcreteProduct2 : Product
{
    public string OperationNumber()
    {
        return "CPNO2";
    }
}

class Client
{
    public void Main()
    {
        ClientCode(new ConcreteCreator1());
        Console.WriteLine("");
        ClientCode(new ConcreteCreator2());
    }

    public void ClientCode(Creator creator)
    {
        Console.WriteLine(creator.MyOperation());
    }
}

