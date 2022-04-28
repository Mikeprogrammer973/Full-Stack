using System;

class Aula51{
    static void Main(string[] args){

        int res = 0;

        if(args.Length > 0){
            Console.WriteLine("Ciao!");
            Console.Write("Argumentos({0}): ", args.Length);
            for(int c = 0; c < args.Length; c++){
                res += int.Parse(args[c]);
            } 
            for(int c = 0; c < args.Length-1; c++){
                Console.Write(args[c] + " + ");
            }
            for(int c = args.Length-1; c < args.Length; c++){
                Console.Write(args[c] + " = ");
            }
             Console.WriteLine(res); 
        }else{
          Console.WriteLine("Ciao!"); 
           Console.WriteLine("Argumentos(0): Nenhum argumento foi passado!"); 
        }
        
        
    }
}