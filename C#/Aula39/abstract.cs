using System;

abstract class Veiculo
{// Classe base abstrata
    protected int velMax;

    protected int velAtual;

    protected bool on;

    public Veiculo()
    {
        velAtual = 0;
    }
    public int getVelAtual()
    {
        if(velAtual < 0)
        {
            velAtual = 0;
        }
        return velAtual;
    }
    public int getVelMax()
    {
        if (velAtual <= 0)
        {
            velMax = 120;
        }
        else
        {
            velMax = velAtual * 7;
        }
        return velMax;
    }
    public string getOn()
    {
        if (velAtual > 0)
        {
            on = true;
        }
        else
        {
            on = false;
        }
        return (on ? "Ligado" : "Desligado");
    }
    abstract public void aceleracao(int aceleracao);
}

class Carro : Veiculo
{
    override public void aceleracao(int aceleracao)
    {
        velAtual += 7 * aceleracao;
    }
}

class Aula39
{
    static void Main()
    {
        Carro carro = new Carro();
        int a;
        Console.Write("\n\nDigite a acceleração do carro: ");
        a = int.Parse(Console.ReadLine());
        carro.aceleracao(a);
        Console.Clear();
        Console.Write("\nVel. Atual: {0}\n\nVel. Máxima: {2}\n\nEstado: {1}\n", carro.getVelAtual(), carro.getOn(), carro.getVelMax());

        Console.ReadLine();
    }
}