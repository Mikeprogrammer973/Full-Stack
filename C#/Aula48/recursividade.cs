using System;

class Calculo
{
    public int soma(int n1, int n2)
    {
        return n1 + n2;
    }

    public double soma(double n1, double n2)
    {
        return n1 + n2;
    }

    public int soma(params int[] num)
    {
        int res = 0;
        for (int c = 0; c < num.Length; c++)
        {
            res += num[c];
        }
        return res;
    }

    public double soma(params double[] num)
    {
        double res = 0;
        for (int c = 0; c < num.Length; c++)
        {
            res += num[c];
        }
        return res;
    }

    public int fatorial(int n)
    {
        int result;

        if(n <= 1)
        {
            result = 1;
        }
        else
        {
            result = n * fatorial(n - 1);
        }

        return result;
    }
}

class Aula48
{
    static void Main()
    {
        Calculo fat = new Calculo();

        int f, res;

        Console.Write("\nN°: ");
        f = int.Parse(Console.ReadLine());

        res = fat.fatorial(f);

        Console.WriteLine("\n\n{0}! = {1}\n", f, res);

        Console.ReadLine();
    }
}