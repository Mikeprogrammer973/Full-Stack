using System;

class Carro
{
    private string cor;
    private int velMax;

    public string Cor
    {
        get
        {
            return cor;
        }
        set
        {
            cor = value;
        }
    }
    public int vm
    {
        get
        {
            return velMax;
        }
        set
        {
            if(value < 0)
            {
                velMax = 0;
            }else if(value > 700)
            {
                velMax = 700;
            }
            else
            {
                velMax = value;
            }
        }
    }

    public Carro(string color)
    {
        vm = 130;
        Cor = color;
    }
}

class Aula41
{
    static void Main()
    {
        Carro car = new Carro("Preto");

        car.vm = 689;

        Console.WriteLine("\n\nVel. Máxima: {0}\n\nCor: {1}\n", car.vm, car.Cor);
    }
}