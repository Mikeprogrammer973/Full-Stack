using System;

struct Carro{
	
	public string marca;
	public string modelo;
	public string cor;
	public int velMax;
	
	public Carro(string marca, string modelo, string cor, int velMax){
		
		this.marca = marca;
		this.modelo = modelo;
		this.cor = cor;
		this.velMax = velMax;
		
	}
	public void info(){
		
		Console.WriteLine("\nMarca......: {0}\n\nModelo.....: {1}\n\nVel. Máxima: {3} Km/h\n\nCor........: {2}\n", marca, modelo, cor, velMax);
	
	}
}

class Aula44{
	
	static void Main(){
		
		Carro car = new Carro("BMW", "Folhrg", "Azul", 1270);
		Carro carro;
		
		carro.marca = "Ferrari";
		carro.modelo = "Shark";
		carro.cor = "Vermelho";
		carro.velMax = 720;
		
		car.info();
		carro.info();
		
		Console.ReadLine();
		
	}
}