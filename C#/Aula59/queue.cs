using System;
using System.Collections.Generic;

class Aula59{
    static void Main(){
        // intstring[] f = [3]{"Vingadores", "Wonderwoman", "Iron Man"};
        Queue<string> movies = new Queue<string> ();

        movies.Enqueue("Iron Man");
        movies.Enqueue("Deus não está Morto");
        movies.Enqueue("Mr. Bean");
        movies.Enqueue("Old Guard");

        // movies.Clear();

        //Console.WriteLine("Primeiro filme: " + movies.Dequeue());// Retorna e remove o 1° da fila

        Console.WriteLine("Primeiro filme: " + movies.Peek());// Retorna o 1° da fila, mas não remove

        Console.WriteLine("\nTamanho da fila: " + movies.Count);

        var e = "Homem de Ferro";
        if(movies.Contains(e)){
            Console.WriteLine("\n'{0}' está na fila!", e);
        }else{
            Console.WriteLine("\n'{0}' não está na fila!", e);
        }


        Console.Write("Itens da fila: ");
        foreach(string f in movies)
        {
            Console.Write(f + " || ");
        }

        while(movies.Count > 0){
            Console.WriteLine("\n'{0}' foi removido da fila!", movies.Dequeue());
        }

        Console.WriteLine("\n\nTamanho da fila: " + movies.Count);
    }
}