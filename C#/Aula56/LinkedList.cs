using System;
using System.Collections.Generic;

class Aula56{
    static void Main(){
        LinkedList<string> trans = new LinkedList<string> ();

        trans.AddFirst("Carro");
        trans.AddFirst("Avião");
        trans.AddFirst("Bicicleta");
        trans.AddFirst("Moto");
        
        trans.AddLast("Helicóptero");

        LinkedListNode<string> neue; 
        //neue = trans.FindLast("Avião");
        //neue = trans.FindLast("Avião").Next; 
        neue = trans.FindLast("Avião").Previous;      
        trans.AddAfter(neue, "Navio");

        trans.AddBefore(neue, "Caminhão");

        //trans.Clear();

        if(trans.Find("Patinete") == null){
            Console.WriteLine("\n'Patinete' not found! Then, it wasn´t removed sucessfull");           
        }else{
            Console.WriteLine("\n'Patinete' found successfull! Then, it was removed sucessfull!");
             trans.Remove("Patinete");// Remove um elemento indicado
        }

        trans.RemoveFirst();// Remove o primeiro
        Console.WriteLine("\n'Moto' was removed!");

        trans.RemoveLast();// Remove o último
        Console.WriteLine("\n'Helicóptero' was removed!");

        Console.Write("\n\nTansportes: ");
        foreach (string t in trans)
        {
            Console.Write(t + "   ");
        }

        Console.ReadLine();
    }    
}