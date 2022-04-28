using System;

class Mat
{
    public static double pi = 3.1416;

    public static int dobro(int n)
    {
        return n * 2;
    }
}

class Aula49
{
    static void Main()
    {
        double pi = Mat.pi;
        int n;

        Console.Write("\nDigite um número: ");
        n = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("\nPI = {0}\n\nDobro de {2}: {1}\n", pi, Mat.dobro(n), n);
    }
}