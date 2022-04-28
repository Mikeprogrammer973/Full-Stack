using System;

class Aula26{
    static void Main(){
        int dd, ds, q, r;
        Console.Write("\n--------Configuração-------------------\n\nDividendo: ");
        dd = int.Parse(Console.ReadLine());
        Console.Write("\nDivisor: ");
        ds = int.Parse(Console.ReadLine());
        q = division(dd, ds, out r);
        Console.WriteLine("\n\n\n-------Resultado-------------------\n\nquociente: {0}\n\nResto: {1}\n", q, r);
        
    }

    static int division(int dividendo, int divisor, out int resto){
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}