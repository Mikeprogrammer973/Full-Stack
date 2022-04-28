using System;
using System.Collections.Generic;

class Aula57{
    static void Main(){
        List <string> books= new List<string> ();
        string[] books2= new string[8];

        books.Add("Harry Potter");
        books.Add("Bíblia Sagrada");
        books.Add("A Seca");
        books.Add("Os Filhos de Anansi");

        //books2.AddRange(books);

        //books2.Clear();

        var l = "A Seca";
        if(books.Contains(l)){
            Console.WriteLine("\nLivro '{0}' está na lista!\n", l);
        }else{
             Console.WriteLine("\nLivro '{0}' não está na lista!\n", l);
        }

        //books.CopyTo(books2, 1);

        Console.WriteLine("\nLivros Lidos:\n");
        foreach (string b in books)
        {
            Console.WriteLine(b);
        }

        string c = "Bíblia Sagrada";
        int pos = 0;
        pos = books.IndexOf(c);

        Console.WriteLine("\n'{0}' está na posção {1} da lista.", c, pos);
    }
}