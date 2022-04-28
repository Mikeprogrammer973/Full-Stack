using System;

class Aula19{
    static void Main(){
        int[] num = new int[7];
       for(int i = 0; i < num.Length; i++){
           num[i] = i * 7;
           Console.WriteLine("\nValor de num na psição {0} = {1}",i,num[i]);
       }
       Console.ReadLine();
    }
}