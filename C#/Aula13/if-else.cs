using System;

class Aula13{

    static void Main(){
        
        float n1, n2, n3, n4, media;
        string resultado, erro;
        Console.Write("\n\nNota 1: ");
        n1 = float.Parse(Console.ReadLine());
        Console.Write("\n\nNota 2: ");
        n2 = float.Parse(Console.ReadLine());
         Console.Write("\n\nNota 3: ");
        n3 = float.Parse(Console.ReadLine());
         Console.Write("\n\nNota 4: ");
        n4 = float.Parse(Console.ReadLine());
        media = (n1 + n2 + n3 + n4) / 4;
        if(media > 10 || media < 0){//Tratamento de erro
            erro = "\n\n\nMédia inválida! A média é de 0 até 10!";
            resultado = "\n\nSituação: Undefined";
            Console.WriteLine(erro);
        }else if(media >= 7){//situação -> aprovado
            resultado = "\n\nSituação: APROVADO";
        }else if(media >= 6){//situação -> recuperação
            resultado = "\n\nSituação: RECUPERAÇÃO";
        }else{//situação -> reprovado
            resultado = "\n\nSituação: REPROVADO";
        }
        Console.WriteLine("\n\nMédia: {0} {1}",media, resultado);
         Console.ReadLine();
    }
}