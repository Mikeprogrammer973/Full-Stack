using System;

class Aula22{
    static void Main(){
        int[] num = new int[5]{11,22,33,44,55};

        for(int c = 0; c < num.Length; c++){
            num[c] = 7;
        }

        foreach(int n in num){//Melhor opção p/ ler valores de uma coleção, mas não inicializa coleções
            Console.WriteLine(n);
        }

    }
}
