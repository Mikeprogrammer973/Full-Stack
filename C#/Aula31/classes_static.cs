using System;

 static public class Player
{
    //Propriedades
    static public int energia;

    static public bool vivo;

    static public string nome;

    static public void iniciar(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    static public void Info()
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

}

public class Inimigo
{
    static public bool alerta;
    public string nome;

    public Inimigo(string n)
    {
        alerta = false;
        nome = n;
    }
    public void info()
    {
        Console.WriteLine("Nome: {0}", nome);
        Console.WriteLine("estado de alerta: {0}", alerta);
        Console.WriteLine("--------------------------------------------");
    }

    class Aula31
    {
        static void Main()
        {

            Player.iniciar("Mike");
            Player.Info();
            Inimigo i1 = new Inimigo("Maluco");
            Inimigo i2 = new Inimigo("Doidão");
            Inimigo i3 = new Inimigo("Cheirador");

            Inimigo.alerta = true;

            i1.info();
            i2.info();
            i3.info();


            Console.ReadLine();
        }

    }
}