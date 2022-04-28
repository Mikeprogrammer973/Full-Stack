using System;


public class Galinha
{
    private string nomeG;
    private int numO;
    static int totalO = 0;

    public Galinha(string nomeG)
    {
        this.nomeG = nomeG;
        numO = 0;
    }

    public Ovo botar()
    {
        numO++;
        totalO++;
        return new Ovo(numO, nomeG);
    }

    public void info()
    {
        Console.WriteLine("Nome: {0}\n", this.nomeG);
        Console.WriteLine("Ovos: {0}\n", this.numO);
        Console.WriteLine("-------------------------------");
    }

    public void getTotalO()
    {
        Console.WriteLine("Total de ovos criados: {0}\n", totalO);
    }

}

public class Ovo
{
    private int numO;
    private string miGa;

    public Ovo(int numO, string miGa)
    {
        this.numO = numO;
        this.miGa = miGa;
        Console.WriteLine("{0} criou um ovo!", this.miGa);
    }
}

public class Aula46
{
    static void Main()
    {
        Galinha g1 = new Galinha("Pena de Ouro");
        Galinha g2 = new Galinha("Loudly Voice");
        Galinha g3 = new Galinha("Golden Egg");

        for(int c = 0; c < 7; c++)
        {
            g1.botar();
        }
        Console.WriteLine("_______________________________________________");
        for (int c = 0; c < 10; c++)
        {
            g2.botar();
        }
        Console.WriteLine("_______________________________________________");
        for (int c = 0; c < 13; c++)
        {
            g3.botar();
        }
        Console.WriteLine("_______________________________________________");
        Console.ReadLine();
        g1.info();
        g2.info();
        g3.info();
        g1.getTotalO();
    }
}