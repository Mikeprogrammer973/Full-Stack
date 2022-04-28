using System;

public class Base
{
    public Base()
    {
        Console.WriteLine("\nConstrutor da classe Base!\n");
    }
    virtual public void info()
    {

    }
    
}
public class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("\nConstrutor da classe Derivada 1!\n");
    }
    override public void info()
    {
        Console.WriteLine("\nDerivada 1\n");
    }
}
public class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("\nConstrutor da classe Derivada 2!\n");
    }
    override public void info()
    {
        Console.WriteLine("\nDerivada 2\n");
    }
}
public class Aula38
{
    static void Main()
    {
        Base Ref;
        Derivada1 objeto1 = new Derivada1();
        Derivada2 objeto2 = new Derivada2();
        
        Ref = objeto1;

        Ref.info();
        

        Console.ReadLine();
    }
}