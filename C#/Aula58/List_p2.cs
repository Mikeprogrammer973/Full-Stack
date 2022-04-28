using System;
using System.Collections.Generic;

class Aula57{
    static void Main(){
        List <string> books= new List<string> ();
        string[] books2= new string[8];

        books.Add("Harry Potter");
        books.Add("Bíblia Sagrada");
        books.Add("A Seca");
        books.Add("Percy Jackson - O Labirinto");
        books.Add("Os Filhos de Anansi");
        books.Add("Apolo - L`oracle Secret");

        //books2.AddRange(books);

        //books2.Clear();

        var l = "A Seca";
        if(books.Contains(l)){
            Console.WriteLine("\nLivro '{0}' está na lista!\n", l);
        }else{
             Console.WriteLine("\nLivro '{0}' não está na lista!\n", l);
        }

        books.CopyTo(books2, 1);

        books.Insert(3, "Origem");
        books.Insert(0, "Bíblia Sagrada");
        books.Insert(2, "O Código da Vinte");
        books.Insert(4, "O Símbolo Perdido");

        //books.Remove("Os Filhos de Anansi");

        //books.RemoveAt(2);

        //books.Reverse();// Inverte

        books.Sort(); // Ordena

        Console.WriteLine("\nTamanho da lista: {0}\n", books.Count);

        //books.Capacity = 17;
        int cap = books.Capacity;
        Console.WriteLine("\nCapacidade da lista: {0}\n", cap);

        Console.WriteLine("\nLivros Lidos:\n");
        foreach (string b in books)
        {
            Console.WriteLine(b);
        }

        string c = "Bíblia Sagrada";
        int pos = 0;
        pos = books.IndexOf(c);

        Console.WriteLine("\nO primeiro livro '{0}' está na posção {1} da lista.\n", c, pos);

        c = "Bíblia Sagrada";
        pos = 0;
        pos = books.LastIndexOf(c);

        Console.WriteLine("\nO último livro '{0}' está na posção {1} da lista.", c, pos);
    }
}