using System;
class Aula27{
    static void Main(){
        int v1, v2, v3;
        Console.Write("\nDigite o valor 1: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("\nDigite o valor 2: ");
        v2 = int.Parse(Console.ReadLine());
        Console.Write("\nDigite o valor 3: ");
        v3 = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("\n{0} + {1} + {2} = ", v1, v2, v3);
        somme(v1, v2, v3);
    }
    static void somme(params int[]n){
        int soma = 0;
        if(n.Length == 0){
            Console.WriteLine("\nImpossível realizar a soma!\n"); 
        }else if(n.Length == 1){
             Console.WriteLine("\nValores insuficientes: '{0}'\n", n[0]);
        }else if(n.Length > 1){
            for(int c = 0; c < n.Length; c++){
                soma += n[c];
                //Console.Write(n[c]);
            }
            Console.WriteLine("{0}\n", soma);
        }
        
    }
}