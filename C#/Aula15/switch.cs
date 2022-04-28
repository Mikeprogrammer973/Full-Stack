using System;

class Aula15{
    static void Main(){

        int tempo;
        string escolha;

        Console.WriteLine("\nBelo Horizonte/MG -> Vitória/ES\n");
        Console.Write("\n[a] Avião\n[c] Carro\n[o] Ônibus\n\nEscolha o meio de Transporte: ");
        escolha = Console.ReadLine();
    

        switch(escolha){
            case "a":
            case "avião":
            case "A":
            case "Avião":
            tempo = 1;
            Console.WriteLine("\n\nDe avião, a sua viagem durará {0} hora.", tempo);
            break;
            case "c":
            case "carro":
            case "C":
            case "Carro":
            tempo = 7;
            Console.WriteLine("\n\nDe carro, a sua viagem durará {0} horas.", tempo);
            break;
            case "o":
            case "ônibus":
            case "O":
            case "Ônibus":
            tempo = 10;
            Console.WriteLine("\n\nDe ônibus, a sua viagem durará {0} horas.", tempo);
            break;
            default:
            Console.WriteLine("\n\nMeio de Transporte inválido!");
            break;

        }
        Console.ReadLine();

    }
}