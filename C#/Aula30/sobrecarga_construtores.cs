using System;

public class Player
{
    //Propriedades
    public int energia;

    public bool vivo;

    public string nome;

    //sobrecarga de  construtores
    public Player()
    {
        energia = 100;
        vivo = true;
        nome = "Player";
    }
    public Player(string name)
    {
        energia = 100;
        vivo = true;
        nome = name;
    }
    public Player(string name, int e)
    {
        energia = e;
        vivo = true;
        nome = name;
    }
    public Player(string name, int e, bool v)
    {
        energia = e;
        vivo = v;
        nome = name;
    }

    //Sobrecarga de métodos
    public void Info()
    {
        string status;
        if(vivo == true)
        {
            status = "Vivo";
        }
        else
        {
            status = "Morto";
        }
        Console.WriteLine("\nNome: {0}\n\nEnergia: {1}\n\nEstado: {2}\n", nome, energia, status);
    }
    public void Info(int n)
    {
        string status;
        if (vivo == true)
        {
            status = "Vivo";
        }
        else
        {
            status = "Morto";
        }
        Console.WriteLine("\nNome: {0}\n\nEnergia: {1}\n\nEstado: {2}\n", nome, energia, status);
    }

    /*
    ~Player()
    {
        Console.WriteLine("\nJogador {0} foi exterminado!\n", nome);
    }
    */

}

class Aula30
{
    static void Main()
    {
        Player j1 = new Player();
        Player j2 = new Player("Mike");
        Player j3 = new Player("Jesus", 100);
        Player j4 = new Player("Napoleão", 20, true);
        Player j5 = new Player("Jackson", 0, false);

        j1.Info();
        j2.Info();
        j3.Info();
        j4.Info();
        j5.Info();

        Console.ReadLine();
    }

}