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
        for(int c = 0; c < num.Length; c++)
        {
            res += num[c];
        }
        return res;
    }
}

class Aula47
{
    static void Main()
    {
        Calculo ad = new Calculo();
        double[] num = new double[100];
        int n;
        Console.Write("\nQuantos valores deseja somar?: ");
        n = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine();
        for (int c = 0; c < n; c++)
        {
            int v = c + 1;
            Console.Write("\nDigite o valor {0}: ", v);
            num[c] = double.Parse(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine();
        for (int c = 0; c < n-1; c++)
        {
            Console.Write(num[c] + " + ");
        }
        for(int c = n-1; c < n; c++)
        {
            Console.Write(num[c] + " = ");
        }
        
        Console.WriteLine(ad.soma(num));
        Console.ReadLine();
    }
}