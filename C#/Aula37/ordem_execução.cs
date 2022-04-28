using System;

public class Base
{
    public Base()
    {
        Console.WriteLine("\nConstrutor da classe Base!\n");
    }
}
public class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("\nConstrutor da classe Derivada 1!\n");
    }
}
public class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("\nConstrutor da classe Derivada 2!\n");
    }
}
public class Aula37
{
    static void Main()
    {
        Derivada2 objeto = new Derivada2();

        Console.ReadLine();
    }
}