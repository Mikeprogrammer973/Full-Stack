using System;

public class Veiculo
{
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax, int velAtual)
    {
       if(velMax < velAtual)
        {
            this.velMax = velMax;
            velAtual = 0;
        }
        else
        {
            this.velMax = velMax;
            this.velAtual = velAtual;
        }
       
        ligado = false;
    }
    public int getVelMax()
    {
        return velMax;
    }
}
class Carro : Veiculo
{
    public string nome;

    public Carro(string nome, int va, int vm) : base(vm, va)
    {
        this.nome = nome;
        if(velAtual < 0)
        {
            velAtual = 0;
        }else if(velAtual == 0)
        {
            ligado = false;
        }
        else
        {
            ligado = true;
        }
        
    }
    public string getLigado()
    {
        return (ligado ? "Ligadíssimo" : "Desligado");
    }
}
class Aula36
{
    static void Main()
    {
        int vm, va;
        string nome;
        Console.Write("\nNome do Carro: ");
        nome = Console.ReadLine();
        Console.Write("\nVel. Máxima: ");
        vm = int.Parse(Console.ReadLine());
        Console.Write("\nVel. Atual: ");
        va = int.Parse(Console.ReadLine());
        Console.Clear();
        Carro car = new Carro(nome, va, vm);

        Console.WriteLine("\nNome: {0}\n\nVel. Atual: {1}\n\nVel. Máxima: {2}\n\nEstado: {3}\n", car.nome, car.velAtual, car.getVelMax(), car.getLigado());

        Console.ReadLine();
    }
}