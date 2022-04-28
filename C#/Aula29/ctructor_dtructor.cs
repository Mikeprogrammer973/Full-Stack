using System;

public class Player
{
    //Propriedades
    public int energia;

    public bool vivo;

    public string nome;

    //Método construtor
    public Player(string name)
    {
        energia = 100;
        vivo = true;
        nome = name;
    }

    //Método destrutor
    ~Player()
    {
        Console.WriteLine("\nJogador {0} foi exterminado!\n", nome);
    }

}

class Aula29
{
    static void Main()
    {
        string jg1, jg2;
        Console.Write("\nJogador 1: ");
        jg1 = Console.ReadLine();
        Console.Write("\nJogador 2: ");
        jg2 = Console.ReadLine();
        Console.Clear();
        Player j1 = new Player(jg1);
        Player j2 = new Player(jg2);
       
        //j1.energia = 50;
        Console.WriteLine("\nNome do jogador 1: {0}", j1.nome);
        //j2.energia = 25;
        Console.WriteLine("\nNome do jogador 2: {0}", j2.nome);
       
    }

}