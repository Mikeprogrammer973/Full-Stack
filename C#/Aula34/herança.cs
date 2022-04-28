using System;

class Veiculo
{//Classe Base
    public int rodas;
    public int velMax;
    private bool ligado;

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
        string status;
        if(ligado == true)
        {
            status = "Ligado";
        }
        else
        {
            status = "Desligado";
        }
        return status;
    }
}
class Carro : Veiculo
{//Classe Derivada
    public string nome;
    public string cor;

    public Carro(string nome, string cor)
    {
        desligar();
        rodas = 4;
        velMax = 150;
        this.nome = nome;
        this.cor = cor;
    }
}
class Aula34
{
    static void Main()
    {
        Carro c1 = new Carro("Ferrari", "Preta");

        Console.WriteLine("\nMarca: {0}\n\nCor: {1}\n\nVel. Máxima: {2} km/h\n\nEstado: {3}\n", c1.nome, c1.cor, c1.velMax, c1.getLigar());
    }
}