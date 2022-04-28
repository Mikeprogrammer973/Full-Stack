using System;

public class Calculos
{
    public int v1;
    public int v2;

    public Calculos()
    {
        v1 = 7;
        v2 = 7;
    }
    public Calculos(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }
    public int Somar()
    {
        int soma;
        soma = v1 + v2;
        return soma;
    }
}
class Aula32
{
    static void Main()
    {
        int v1, v2;
        Console.Write("\nDigite o valor 1: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("\nDigite o valor 2: ");
        v2 = int.Parse(Console.ReadLine());
        Console.Clear();
        Calculos c = new Calculos(v1, v2);

        int res;

        res = c.Somar();

        Console.WriteLine("\n{0} + {1} = {2}\n", c.v1, c.v2, res);

        Console.ReadLine();
    }
}