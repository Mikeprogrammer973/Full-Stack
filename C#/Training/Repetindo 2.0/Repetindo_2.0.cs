using System;

class Training{
    static void Main(){
        string[] rep = new string[10000000];
        string nome, choose, texto, novo;
        int r;
        Console.Write("\n\nDigite o seu nome: ");
        nome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("\n\n\t\tBem-vindo ao Repetindo 2.0 {0}!",nome);
        inicio:
        Console.Clear();
        Console.Write("\n\nDeseja realizar uma repetição {0}?: ",nome);
        choose = Console.ReadLine();
        Console.Clear();
        if(choose == "s" || choose == "S" || choose == "sim" || choose == "SIM" || choose == "Sim"){
        Console.Write("\n\nTexto: ");
        texto = Console.ReadLine();
        Console.Write("\n\nQuantas vez quer repetir?: ");
        r = int.Parse(Console.ReadLine());
        Console.Clear();
        int c = 0;
        Console.WriteLine("\n\n\tAqui está a sua repetição {0}!\n\n",nome);
        while( c < r){
        rep[c] = texto;
        Console.WriteLine("\t" + rep[c]);
        c++;
        }
        }else{
            if(choose == "n" || choose == "N" || choose == "não" || choose == "NÃO" || choose == "Não" || choose == "NAO" || choose == "Nao" || choose == "nao"){
            goto fim;
            }else{
            Console.WriteLine("\n\nResposta inválida {0}...Tente de novo!\n\n",nome);
            Console.ReadLine();
            goto inicio;
            } 
        }
        novo:
        Console.Write("\n\n\tDeseja realizar uma nova repetição {0}?: ",nome);
        novo = Console.ReadLine();
        if(novo == "s" || novo == "S" || novo == "sim" || novo == "SIM" || novo == "Sim"){
            goto inicio;
        }else{
             if(novo == "n" || novo == "N" || novo == "não" || novo == "NÃO" || novo == "Não" || novo== "NAO" || novo == "Nao" || novo == "nao"){
            goto fim;
            }else{
            Console.WriteLine("\n\nResposta inválida {0}...Tente de novo!\n\n",nome);
            goto novo;
            } 
        }
        fim:
        Console.Clear();
        Console.WriteLine("\n\n\tEntão beleza {0}, até mais!!!\n\n",nome);
        Console.ReadLine();
    }
}