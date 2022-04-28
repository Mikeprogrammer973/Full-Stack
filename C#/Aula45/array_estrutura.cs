using System;

struct Carro
{

	public string modelo;
	public string cor;

	public void info()
	{

		Console.WriteLine("\n\nModelo.....: {0}\n\nCor........: {1}\n", modelo, cor);
		Console.WriteLine("---------------------------");
	}
}

class Aula45
{

	static void Main()
	{

		Carro[] cars = new Carro[7];

		cars[0].modelo = "Fatdi";
		cars[0].cor = "Vermelho";
		cars[1].modelo = "Tyfxi";
		cars[1].cor = "Branca";
		cars[2].modelo = "HRV";
		cars[2].cor = "Prata";
		cars[3].modelo = "Terrain";
		cars[3].cor = "Preta";
		cars[4].modelo = "Golf";
		cars[4].cor = "Branco";
		cars[5].modelo = "Forrk";
		cars[5].cor = "Azul";
		cars[6].modelo = "Wort";
		cars[6].cor = "Branco";

		for(int c = 0; c < cars.Length; c++)
        {
			cars[c].info();
        }

		Console.ReadLine();

	}
}