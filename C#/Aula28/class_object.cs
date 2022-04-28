using System;

public class Player{
    //Propriedades
    public int energia = 100;

    public bool vivo = true;
}

class Aula28{
    static void Main(){
        Player j1 = new Player();
        Player  j2 = new Player();
        Player  j3 = new Player();

        j1.energia = 50;
        Console.WriteLine("\nEnergia do jogador 1: {0}%", j1.energia);
        j2.energia = 25;
        Console.WriteLine("\nEnergia do jogador 2: {0}%", j2.energia);
        j3.energia = 75;
        Console.WriteLine("\nEnergia do jogador 3: {0}%", j3.energia);
    }
   
}