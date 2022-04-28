using System;

class Aula52{
    static void Main(){

        int n1, n2, res;

        res = n1 = n2 = 0;

        Console.Write("\nValor 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("\nValor 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Clear();

        try{
            res = n1 / n2;
            Console.WriteLine("\n{0} / {1} = {2}\n", n1, n2, res);            
        }catch(Exception ex){
            Console.Write("\nERRO: {0}", ex.Message);
            Console.Write("\nExeção: {0}", ex.GetType());
        }

        Console.ReadLine();

    }
}