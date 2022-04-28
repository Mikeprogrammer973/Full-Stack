using System;

class Aula19{
    static void Main(){
        int[] num = new int[11];

        int n = num.Length-1;

        while(n > 0){
            num[n] = 9 * n;
            Console.WriteLine("\nnum na posição {0}  ->  {1}\n",n,num[n]);
            n--;
        }

    } 
}