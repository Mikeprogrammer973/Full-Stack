using System;

public class Training{
    static void Main(){
        string nome, novo, operation, option;
        Console.Write("\nDigite o seu nome: ");
        nome = Console.ReadLine();
        inicio:
        Console.Clear();
        Console.Write("\nDeseja realizar uma operação aritmética {0}?: ", nome);
        operation = Console.ReadLine();
        Console.Clear();
        if (operation == "s" || operation == "S" || operation == "sim" || operation == "SIM" || operation == "Sim"){
            op:
            Console.Write("\n[1] Adição\n\n[2] Multiplicação\n\n[3] Divisão\n\n[4] Fatoração\n\n[5] Módulo\n\n[6] Valor Absoluto\n\n[7] Raiz Quadrada\n\n[8] Raiz Cúbica\n\n\nDigite a sua opção: ");
            option = Console.ReadLine();
            Console.Clear();
            switch(option){
                case "1":
                    int num;
                    double[] somme = new double[10000];
                    Console.Write("\nQuantos valores deseja somar?: ");
                    num = int.Parse(Console.ReadLine());
                    for(int c = 0; c < num; c++)
                    {
                        int i;
                        i = c + 1;
                        Console.Write("\nDigite o valor {0}: ", i);
                        somme[c] += float.Parse(Console.ReadLine());
                        
                    }
                    Console.Clear();
                    for(int n = 0; n < num-1; n++)
                    {
                        Console.Write(somme[n]);
                        Console.Write(" + ");
                    }
                    for (int n = num-1; n < num; n++)
                    {
                        Console.Write(somme[n]);
                        Console.Write(" = ");
                    }
                    Ad(somme);
                break;
                case "2":
                    double v1, v2, result;
                    Console.Write("\nvalor 1: ");
                    v1 = double.Parse(Console.ReadLine());
                    Console.Write("\nvalor 2: ");
                    v2 = double.Parse(Console.ReadLine());
                    result = Mul(v1, v2);
                    Console.Clear();
                    Console.WriteLine("\n{0} x {1} = {2}\n", v1, v2, result);
                    break;
                case "3":
                    float n1, n2, resultat;
                    Console.Write("\nvalor 1: ");
                    n1 = float.Parse(Console.ReadLine());
                    Console.Write("\nvalor 2: ");
                    n2 = float.Parse(Console.ReadLine());
                    resultat = Div(n1, n2);
                    Console.Clear();
                    Console.WriteLine("\n{0} / {1} = {2}\n", n1, n2, resultat);
                    break;
                case "4":
                    int val, resultado;
                    Console.Write("\nvalor: ");
                    val = int.Parse(Console.ReadLine());
                    resultado = Fat(val);
                    Console.Clear();
                    Console.WriteLine("\n{0}! = {1}\n", val, resultado);
                    break;
                case "5":
                    int num1, num2, r;
                    Console.Write("\nvalor 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("\nvalor 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    r = Mod(num1, num2);
                    Console.Clear();
                    Console.WriteLine("\n{0} % {1} = {2}\n", num1, num2, r);
                    break;
                case "6":
                    int valor, abs;
                    Console.Write("\nvalor : ");
                    valor = int.Parse(Console.ReadLine());
                    abs = Abs(valor);
                    Console.Clear();
                    Console.WriteLine("\n|{0}| = {1}\n", valor, abs);
                    break;
                case "7":
                    float v, sqrt;
                    Console.Write("\nvalor : ");
                    v = float.Parse(Console.ReadLine());
                    sqrt = Square(v);
                    Console.Clear();
                    Console.WriteLine("\nsqrt({0})= {1}\n", v, sqrt);
                    break;
                case "8":
                    float valeur, cubo;
                    Console.Write("\nvalor : ");
                    valeur = float.Parse(Console.ReadLine());
                    cubo = Cubo(valeur);
                    Console.Clear();
                    Console.WriteLine("\nR. cubo de {0} = {1}\n", valeur, cubo);
                    break;
                default:
                Console.WriteLine("\nOpção inválida {0}...Tente de novo!\n\n", nome);
                Console.ReadLine();
                Console.Clear();
                goto op;
                
            }
        }else{
            if(operation == "n" || operation == "N" || operation == "não" || operation == "NÃO" || operation == "NAO" || operation == "Nao" || operation == "nao" || operation == "Não")
            {
                goto fim;
            }else{
                Console.WriteLine("\nResposta inválida {0}...Tente de novo!\n\n", nome);
                Console.ReadLine();
               goto inicio; 
            }
        }
        novo:
        Console.Write("\n\nDeseja realizar uma nova operação {0}?: ", nome);
        novo = Console.ReadLine();
        if(novo == "s" || novo == "S" || novo == "sim" || novo == "SIM" || novo == "Sim"){
            goto inicio;
        }else{
           if(novo == "n" || novo == "N" || novo == "não" || novo == "NÃO" || novo == "Não" || novo == "NAO" || novo == "nao" || novo == "Nao"){
               goto fim;
           }else{
               Console.WriteLine("\nResposta inválida {0}...Tente de novo!\n\n", nome);
                Console.ReadLine();
                Console.Clear();
                goto novo; 
           }}
            fim:
            Console.Clear();
            Console.WriteLine("\n\nBeleza {0}, até mais!", nome);
            Console.ReadLine();
        }
        
        static void Ad(params double[]ad){
        double addition = 0;
        if(ad.Length == 0){
            Console.WriteLine("\nImpossível realizar a soma!\n"); 
        }else if(ad.Length == 1){
             Console.WriteLine("\nValores insuficientes: '{0}'\n", ad[0]);
        }else if(ad.Length > 1){
            for(int c = 0; c < ad.Length; c++){
                addition += ad[c];
                //Console.Write(n[c]);
            }
            Console.WriteLine("{0}\n", addition);
        }
    }
    static double Mul(double v1, double v2){
        double multiplication;
        multiplication = v1 * v2;
        return multiplication;
        
    }
    static float Div(float v1, float v2){
        float division;
        division = v1 / v2;
        return division;
    }
    static int Fat(int v1){
        int fat = 1;
        for(int c = v1; c >= 1; c--){
            fat *= c;
        }
        return fat;
    }
    static int Mod(int v1, int v2){
        int module;
        module = v1 % v2;
        return module;
    }
    static int Abs(int v1){
        int abs;
        if(v1 >= 0){
            abs = v1;
        }else{
            abs = -v1;
        }
        return abs;
    }
    static float Square(float v1){
        float square;
        square = v1 * v1;
        return square;
    }
    static float Cubo(float v1){
        float cubo;
        cubo = v1 * v1 * v1;
        return cubo;
    }
}

    
    