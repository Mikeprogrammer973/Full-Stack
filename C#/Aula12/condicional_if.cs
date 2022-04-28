using System;

class Aula12{

    static void Main(){
        
        float n1, n2, n3, n4,media;
        string resultado = "\n\nSituação: REPROVADO";
        Console.Write("\n\nNota 1: ");
        n1 = float.Parse(Console.ReadLine());
        Console.Write("\n\nNota 2: ");
        n2 = float.Parse(Console.ReadLine());
         Console.Write("\n\nNota 3: ");
        n3 = float.Parse(Console.ReadLine());
         Console.Write("\n\nNota 4: ");
        n4 = float.Parse(Console.ReadLine());
        media = (n1 + n2 + n3 + n4) / 4;
        if(media >= 7){
            resultado = "\n\nSituação: APROVADO";
        }
        Console.WriteLine("\n\nMédia: {0} {1}",media, resultado);
         Console.ReadLine();
    }
}