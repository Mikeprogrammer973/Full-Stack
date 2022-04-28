using System;

// Usado p/ organizar, agrupar 
namespace Calc1{
        
    class Area{
        public static float Ret(float bas, float alt){

            if(bas == 0 || alt == 0){
                throw new Exception ("Base e/ou Altura inválida!");
            }else if(bas == alt || alt == bas){
                throw new Exception ("Altura não pode ser == à Base / Base não pode ser == à Altura!");
            }
            return bas * alt;
        }
    }

}

namespace Calc2{
    
    class Area{
        public static float Quad(float bas, float alt){

            if(bas == 0 || alt == 0){
                throw new Exception ("Base e/ou Altura inválida!");
            }else if(bas != alt || alt != bas){
                throw new Exception ("Altura não pode ser != da Base / Base não pode ser != da Altura!");
            }
            return bas * alt;
        }
    }

}

class Aula54{
    static void Main(){

        float n1, n2, res;

        res = n1 = n2 = 0;

        Console.Write("\n-----------------------------------------------------Calculando área de retângulo----------------------------\n\n");
        Console.Write("\nBase: ");
        n1 = float.Parse(Console.ReadLine());
        Console.Write("\nAltura: ");
        n2 = float.Parse(Console.ReadLine());
        Console.Clear();

        try{
            res = Calc1.Area.Ret(n1, n2);
            Console.WriteLine("\nRetângulo: {0} x {1}\n\nÁrea: {2}", n1, n2, res);                   
        }catch(Exception ex){
            Console.Write("\nERRO: {0}", ex.Message);
            Console.Write("\nExeção: {0}", ex.GetType());
        }finally{
            Console.WriteLine("\n\nFim do Tratamento...");
        }

        Console.ReadLine();

    }
}