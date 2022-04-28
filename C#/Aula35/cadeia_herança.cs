using System;

class Veiculo
{//Classe Base
    private int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo(int rodas)
    {
        this.rodas = rodas;
    }
    public int getRodas()
    {
        return rodas;
    }
    public void ligar()
    {
        ligado = true;
    }
    public void desligar()
    {
        ligado = false;
    }
    public string getLigar()
    {
        return (ligado ? "Ligado" : "Desligado");
    }
    public void setRodas(int rodas)
    {
        if(rodas < 0)
        {
            this.rodas = 0;
        }else if(rodas > 70)
        {
            this.rodas = 70;
        }
        else
        {
            this.rodas = rodas;
        }
    }
}
class Carro : Veiculo
{//Classe Derivada
    public string nome;
    public string cor;

    public Carro(string nome, string cor) : base(4)
    {
        desligar();
        velMax = 150;
        this.nome = nome;
        this.cor = cor;
    }
}
class CarroCombate : Carro
{
    public int municao;

    public CarroCombate() : base("RedFire","Vermelho")
    {
        velMax = 750;
        municao = 100;
        setRodas(7);
    }
}
class Aula35
{
    static void Main()
    {
        Carro c1 = new Carro("Ferrari", "Preta");
        CarroCombate cc1 = new CarroCombate();


        Console.WriteLine("\nNome: {0}\n\nCor: {1}\n\nRodas: {4}\n\nVel. Máxima: {2} km/h\n\nEstado: {3}\n", c1.nome, c1.cor, c1.velMax, c1.getLigar(), c1.getRodas());

        Console.WriteLine("--------------------------------------------------------");

        cc1.ligar();

        Console.WriteLine("\nNome: {0}\n\nCor: {1}\n\nRodas: {4}\n\nVel. Máxima: {2} km/h\n\nMunição: {5}%\n\nEstado: {3}\n", cc1.nome, cc1.cor, cc1.velMax, cc1.getLigar(), cc1.getRodas(), cc1.municao);
    }
}