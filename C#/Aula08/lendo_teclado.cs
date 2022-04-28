using System;

class Aula08{

    static void Main(){
        int v1, v2, soma;
        string nome;


        Console.Write("\n\nDigite o n° 1:  ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("\nDigite o n° 2: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine("\n\n{0} + {1} = {2}\n\n", v1, v2, soma);

       
    }
}