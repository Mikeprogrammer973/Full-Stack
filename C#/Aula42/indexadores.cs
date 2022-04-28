using System;

class Carro
{
    private string cor;
    private int[] velMax = new int[5] { 120, 220, 380, 500, 700 };

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
    public int this[int i]
    {
        get
        {
            return velMax[i];
        }
        set
        {
            if (value < 0)
            {
                velMax[i] = 0;
            }
            else if (value > 700)
            {
                velMax[i] = 700;
            }
            else
            {
                velMax[i] = value;
            }
        }
    }

    public Carro(string color)
    {
        Cor = color;
    }
}

class Aula42
{
    static void Main()
    {
        Carro car = new Carro("Amarelo");

        car[4] = 578;

        Console.WriteLine("\n\nVel. Máxima: {0}\n\nCor: {1}\n", car[4], car.Cor);
    }
}