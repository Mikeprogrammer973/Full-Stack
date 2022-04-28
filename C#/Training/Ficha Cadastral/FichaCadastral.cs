using System;

class Training{

    static void Main(){
        int ano, sorte, idade;
        double peso, altura;
        string nome, data, sexo, nacio;
        Console.Write("\n\nSeu nome completo: ");
        nome = Console.ReadLine();
        Console.Clear();
         Console.Write("\n\nSeu ano de nascimento: ");
        ano = int.Parse(Console.ReadLine());
         Console.Clear();
         Console.Write("\n\nSua data de nascimento: ");
        data = Console.ReadLine();
         Console.Clear();
        Console.Write("\n\nSeu sexo: ");
        sexo = Console.ReadLine();
         Console.Clear();
        Console.Write("\n\nSua altura: ");
        altura = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("\n\nSeu peso: ");
        peso = double.Parse(Console.ReadLine());
         Console.Clear();
        Console.Write("\n\nSua nacionalidade: ");
        nacio = Console.ReadLine();
         Console.Clear();
        Console.Write("\n\nSeu número de sorte: ");
        sorte = int.Parse(Console.ReadLine());
         Console.Clear();
        idade = 2022 - ano;

        Console.WriteLine("\n\nNome: {0}\n\nIdade: {1} anos\n\nPeso: {2} kg\n\nAltura: {3} m\n\nSexo: {4}\n\nNacionalidade: {5}\n\nN° de sorte: {6}\n\n",nome, idade, peso, altura, sexo, nacio, sorte);
        Console.ReadLine();
    
    }
}