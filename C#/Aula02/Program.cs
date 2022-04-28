using System;

class Program
{
    static void Main(String[] args){
        Console.WriteLine("Olá Mundo!");
        if(args.GetLength(0) > 0){

        Console.Write(args.GetValue(0));

        }

    }
}