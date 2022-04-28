using System;

class Aula24
{
    static void Main()
    {
        for(int c = 0; c < 1; c++)
        {
            //ciao();
            int v1, v2, r;
            Console.Write("\nDigite o valor 1: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor 2: ");
            v2 = int.Parse(Console.ReadLine());
            Console.Clear();
            //soma(v1, v2);
            r = soma(v1, v2);
            Console.WriteLine("\n{0} + {1} = {2}\n", v1, v2, r);
        }
    }

    /*
     //Sem retorno
     static void ciao()
    {
        Console.WriteLine("\nTe amo Principessa!\n");
        Console.WriteLine("\nYeah! Like I had say, I always will be with u!\n");
        Console.WriteLine("\nIf it isn´t be presencial, then it will be in my heart!\n");
    }

    //Com argumentos de entrada
    static void soma(int n1, int n2)
    {
        int s = n1 + n2;
        Console.WriteLine("\n{0} + {1} = {2}\n",n1,n2,s);
    }*/

    //Com retorno
    static int soma(int n1, int n2)
    {
        int s = n1 + n2;
        return s;
    }
}