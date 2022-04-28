using System;

class Aula23{
    static void Main(){
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,55,77},{33,66,88,99,00}};

        Random random = new Random();
        for(int i=0;i<vetor1.Length;i++){
            vetor1[i] = random.Next(50);
        }
        Console.Write("\nElementos do vetor 1: ");
        foreach(int n in vetor1){
            Console.WriteLine("\n"+n);

        }
        Console.WriteLine("---------------------------------------------------");
        //public static int BinarySearch(array,valor);
        Console.WriteLine("\n\nBinarySearch\n\n");
        int procurado = 32;
        int pos = Array.BinarySearch(vetor1,procurado);
        Console.WriteLine("\n\nValor {0} está na posição {1}",procurado,pos);
        Console.WriteLine("---------------------------------------------------");

        //public static void Copy(Ar_origem,Ar_destino,qtd_de_elementos);
        Console.WriteLine("\n\nCopy\n\n");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach(int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------------------------");

        //public void CopyTo(Ar_destino,a_parit_desta_pos);
        Console.WriteLine("\n\nCopyTo\n\n");
        vetor1.CopyTo(vetor3, 0);
        foreach(int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------------------------");

        //public long GetLongLength(dimensão);
        Console.WriteLine("\n\nGetLongLength\n\n");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos: {0}", qtdeElementosVetor);
        Console.WriteLine("---------------------------------------------------");

        //public int GetLowerBound(dimensão);
        Console.WriteLine("\n\nGetLowerBound\n\n");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor índice do vetor1: {0}", MenorIndiceVetor);
        Console.WriteLine("---------------------------------------------------");

        //public int GetUpperBound(dimensão);
        Console.WriteLine("\n\nGetUpperBound\n\n");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Maior índice do vetor1: {0}", MaiorIndiceVetor);
        Console.WriteLine("---------------------------------------------------");

        //public object GetValue(long indice);
        Console.WriteLine("\n\nGetValue\n\n");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("---------------------------------------------------");

        //public static int IndexOf(array,valor);
        Console.WriteLine("\n\nIndexOf\n\n");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Índice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("---------------------------------------------------");

        //public static int LastIndexOf(array,valor);
        Console.WriteLine("\n\nLastIndexOf\n\n");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Índice do último valor 3: {0}", indice2);
        Console.WriteLine("---------------------------------------------------");

        //public static void Reverse();
        Console.WriteLine("\n\nReverse\n\n");
        Array.Reverse(vetor1);
        foreach(int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------------------------");

        //public void SetValue(object valor, long pos);
        Console.WriteLine("\n\nSetValue\n\n");
        vetor2.SetValue(99, 0);
        for(int i = 1; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        Console.Write("Valores do vetor2: ");
        foreach(int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------------------------");

        //public static void Sort(array);
        Console.WriteLine("\n\nSort\n\n");
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        foreach(int n in vetor1)
        {
            Console.WriteLine("Vetor 1: {0}\n", n);
        }
        foreach (int n in vetor2)
        {
            Console.WriteLine("Vetor 2: {0}\n", n);
        }
        foreach (int n in vetor3)
        {
            Console.WriteLine("Vetor 3: {0}\n", n);
        }
        Console.WriteLine("---------------------------------------------------");
    }
}