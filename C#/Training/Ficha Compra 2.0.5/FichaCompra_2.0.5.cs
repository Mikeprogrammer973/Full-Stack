using System;

class Training{
    static void Main(){
        double[,] pp = new double[3,10000];
        string[] nomep = new string[10000];
        string nome, ficha, novo, local, cnpj, cliente;
        int qtp, c; 
        float ppp;
        ppp = 0;

        Console.Write("\nDigite o seu nome: ");
        nome = Console.ReadLine();
        inicio:
        Console.Clear();
        Console.Write("\nDeseja realizar uma ficha de compra {0}?: ",nome);
        ficha = Console.ReadLine();
        Console.Clear();
        if (ficha == "s" || ficha == "S" || ficha == "sim" || ficha == "SIM" || ficha == "Sim"){
            Console.Write("\nCliente: ");
            cliente = Console.ReadLine();
            Console.Write("\nEstabelecimento: ");
            local = Console.ReadLine();
            Console.Write("\nCPF/CNPJ: ");
            cnpj = Console.ReadLine();
            Console.Write("\nN° de produtos: ");
            qtp = int.Parse(Console.ReadLine());
            Console.Clear();
            int i = 1;
            c = 0;
            while(c<qtp){
            Console.Write("\nProduto {0}: ",i);
            nomep[c] = Console.ReadLine();
            Console.Write("\nQuantidade: ");
            //qp = int.Parse(Console.ReadLine());
            pp[0,c] = int.Parse(Console.ReadLine());
            Console.Write("\nPreço da unidade: ");
            //pu = float.Parse(Console.ReadLine());
            pp[1,c] = float.Parse(Console.ReadLine());
            //pt = qp*pu;
            pp[2,c] = pp[0, c] * pp[1, c];
            ppp += (float)pp[2,c];
            c++;
            i++;
            Console.Clear();
            }
            Console.WriteLine("\n\nCliente: {0}\n\nEstabelecimento: {1}\n\nCPF/CNPJ: {2}\n\n", cliente, local, cnpj);
            for(int v = 0; v<qtp; v++)
            {
                Console.WriteLine("\n{0,3}------------ Qtd: {1} -----------------{2:c}",nomep[v],pp[0,v],pp[2,v]);
            }
            Console.WriteLine("\nPreço total: {0:c}\n\n", ppp);
        }
        else{
            if(ficha == "n" || ficha == "N" || ficha == "não" || ficha == "NÃO" || ficha == "Não" || ficha == "Nao" || ficha == "NAO" || ficha == "nao"){
            goto fim;
            }else{
            Console.WriteLine("\n\nResposta inválida {0}...Tente de novo!\n\n",nome);
            Console.ReadLine();
            goto inicio;
            }
        }
        novo:
        Console.Write("\nDeseja realizar uma nova ficha {0}?: ",nome);
        novo = Console.ReadLine();
        if(novo == "s" || novo == "S" || novo == "sim" || novo == "SIM" || novo == "Sim"){
            goto inicio;
        }else{
             if(novo == "n" || novo == "N" || novo == "não" || novo == "NÃO" || novo == "Não" || novo == "Nao" || novo == "NAO" || novo == "nao"){
            goto fim;
            }else{
            Console.WriteLine("\n\nResposta inválida {0}...Tente de novo!\n\n",nome);
            Console.ReadLine();
            goto novo;
            }
        }
    fim:
        Console.Clear();
        Console.Write("\n\nBeleza {0}, até mais!\n\n",nome);
        Console.ReadLine();
    }
}