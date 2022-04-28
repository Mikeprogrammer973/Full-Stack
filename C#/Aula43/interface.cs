using System;

// Não pode conter propriedades(campo), nem construtores e, nem destrutores.
// Só contém a assinatura dos métodos.

public interface Veiculo{
	
	void ligar();
	
	void desligar();
	
	void info();
}

public interface Combate{
	
	void disparar();
}

class Carro : Veiculo, Combate{
	
	public bool on;
	
	private int municao;
	
	public string status{
		
		get{
			
			return (on ? "Ligado" : "Desligado");
			
		}
	}
	public int mnc{
		
		get{
			
			return municao;
			
		}
	}
	
	public Carro(){
		
		setMunicao(100);
		
	}
	public void ligar(){
		
		on = true;
		
	}
	public void desligar(){
		
		on = false;
		
	}
	public void setMunicao(int qtd){
		
		this.municao = qtd;
		
	}
	public void info(){
		
	}
	public void disparar(){
		
	}
}

class Aula43{
	
	static void Main(){
		
		Carro car = new Carro();
		
		car.ligar();
		car.setMunicao(70);
		
		Console.WriteLine(car.status);
		Console.WriteLine(car.mnc);
		
	}
}