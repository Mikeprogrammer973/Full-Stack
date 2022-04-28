using System;

class Auala25{
    static void Main(){
        int n;

        Console.Write("\nDigite um valor: ");
        n = int.Parse(Console.ReadLine());
        dobrar1(ref n);
        Console.WriteLine("\np.r: {0}\n",n);

        Console.Write("\nDigite um valor: ");
        n = int.Parse(Console.ReadLine());
        dobrar2(n);
        Console.WriteLine("\np.v: {0}\n",n);
    }

    //Passagem por referência
    static void dobrar1(ref int valor){
        valor *= 2;
    }

    //Passagem por valor
    static void dobrar2(int valor){
        valor *= 2;
    }
}