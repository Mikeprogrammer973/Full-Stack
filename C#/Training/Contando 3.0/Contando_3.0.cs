using System;

class Training{
    static void Main(){
        int[,] proposta = new int[4,120];
        string perso, contar, op, nome;
        
        Console.Write("\n\nDigite o seu nome: ");
        nome = Console.ReadLine();
   
        inicio:
        Console.Clear();
/*
         for(cm = 0; cm < proposta.Length; cm++){
            for(ca1 = 0; ca1 < 11; ca1++){
            proposta[cm,ca1] = ca1;
            }
            for(ca2 = 10; ca2 > -1; ca2--){
            proposta[cm,ca2] = ca2;
            }
            for(ca3 = 0; ca3 < 1001; ca3++){
            proposta[cm,ca3] = ca3;
            }
            for(ca4 = 100; ca4 > -1; ca4--){
            proposta[cm,ca4] = ca4;
            }
         }
         */

    Console.Write("\n\n\tBem-vindo ao Contando 3.0 {0}!\n\n",nome);
    Console.Write("\n\n\tDeseja realizar uma contagem?: ");
    contar = Console.ReadLine();
    Console.Clear();
    if(contar == "Sim" || contar == "sim" || contar == "SIM" || contar == "S" || contar == "s"){
        opcoes:
       Console.WriteLine("\n\n[1] 0 -> 10\n[2] 10 -> 0\n[3] 0 -> 100\n[4] 100 -> 0\n[5] Contagem Personalizada\n");
       Console.Write("\n\nEscolhe uma das opções acima {0}: ",nome);
       op = Console.ReadLine();
       Console.Clear();
       switch(op){
           case "1":
           int cm;
            for(cm = 0; cm <= 0; cm++){// 0 -> 10
            Console.Write("\n\nAqui está a sua contagem {0}!",nome);
            Console.WriteLine("................................................................................\n\tContagem:\n\n");
             for(int ca1 = 0; ca1 < 11; ca1++){
            proposta[cm,ca1] = ca1;
            Console.Write("{0,2}  ->  ",proposta[cm,ca1]);
            }
            Console.Write("</>");
            }
            break;
           case "2":
          
            for(cm = 1; cm <= 1; cm++){// 10 -> 0
            Console.Write("\n\nAqui está a sua contagem {0}!",nome);
            Console.WriteLine("................................................................................\n\tContagem:\n\n");
             for(int ca2 = 10; ca2 > -1; ca2--){
            proposta[cm,ca2] = ca2;
            Console.Write("{0,2}  ->  ",proposta[cm,ca2]);
            }
            Console.Write("</>");
            }
            break;
           case "3":
         
           for(cm = 2; cm <= 2; cm++){// 0 -> 100
           Console.Write("\n\nAqui está a sua contagem {0}!",nome);
            Console.WriteLine("................................................................................\n\tContagem:\n\n");
             for(int ca3 = 0; ca3 < 101; ca3++){
            proposta[cm,ca3] = ca3;
            Console.Write("{0,2}  ->  ",proposta[cm,ca3]);
            }
            Console.Write("</>");
            }
            break;
           case "4":
          
           for(cm = 3; cm <= 3; cm++){// 100 -> 0
           Console.Write("\n\nAqui está a sua contagem {0}!",nome);
            Console.WriteLine("................................................................................\n\tContagem:\n\n");
             for(int ca4 = 100; ca4 > -1; ca4--){
            proposta[cm,ca4] = ca4;
            Console.Write("{0,2}  ->  ",proposta[cm,ca4]);
            }
            Console.Write("</>");
            }
            break;
            case "5":
            perso:
            int cont, init, fim, passo;
            Console.Write("\n[R] Contagem regressiva\n[P] Contagem progressiva\n\nEscolha o tipo de contagem: ");
            perso = Console.ReadLine();
            Console.Clear();
            Console.Write("\nInício: ");
            init = int.Parse(Console.ReadLine());
            Console.Write("\nFim: ");
            fim = int.Parse(Console.ReadLine());
            Console.Write("\nPasso: ");
            passo = int.Parse(Console.ReadLine());
            if(perso == "R" || perso == "Regressiva" || perso == "r" || perso == "regressiva" || perso == "REGRESSIVA"){
            Console.Write("\n\nAqui está a sua contagem {0}!",nome);
            Console.Write("\n................................................................................\n\nContagem:\n\n");
            for(cont = init; cont >= fim; cont -= passo){//Contagem regressiva
            Console.Write("{0,2}  ->  ",cont);
            }
            }else{
                if(perso == "P" || perso == "Progressiva" || perso == "p" || perso == "progressiva" || perso == "PROGRESSIVA"){
            Console.Write("\n\nAqui está a sua contagem {0}!",nome);
            Console.Write("\n................................................................................\n\nContagem:\n\n");
            for(cont = init; cont <= fim; cont += passo){//Contagem progressiva
            Console.Write("{0,2}  ->  ",cont);
            }
                }else{
                Console.WriteLine("\n\nOpção '{1}' é inválida {0}...Tente de novo!\n\n",nome,perso);
                Console.ReadLine();
                goto perso;  
                }
            
           
            }
             Console.Write("</>");
            break;
            default:
            Console.WriteLine("\n\nOpção '{1}' é inválida {0}...Tente de novo!\n\n",nome,op);
            Console.ReadLine();
            goto opcoes;
       }
        }else{
            if(contar == "Não" || contar == "não" || contar == "NÂO" || contar == "N" || contar == "n" || contar == "nao" || contar == "NAO" || contar == "Nao"){
               goto fim;
            }else{
                Console.WriteLine("\n\nResposta inválida {0}...Tente de novo!\n\n",nome);
                Console.ReadLine();
                goto inicio; 
            }    
    }
    
    novo:
    string novo;
    Console.Write("................................................................................\n\n{0}, deseja realizar uma outra contagem?: ",nome);
    novo = Console.ReadLine();

    if(novo == "Sim" || novo == "sim" || novo == "SIM" || novo == "S" || novo == "s"){
    goto inicio;
    }else{
       if(novo == "Não" || novo == "não" || novo == "NÂO" || novo == "N" || novo == "n" || novo == "nao" || novo == "NAO" || novo == "Nao"){
               goto fim; 
            }else{
                Console.WriteLine("\n\nResposta inválida {0}...Tente de novo!\n\n",nome);
                goto novo;
            }    
    }

    fim:
    Console.Clear();
    Console.WriteLine("\n\nEntão beleza {0}! Até mais!!!",nome);
    Console.ReadLine();
}
}



    
