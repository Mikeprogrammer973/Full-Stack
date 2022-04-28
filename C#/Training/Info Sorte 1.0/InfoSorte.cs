using System;
public class Info
{
    public string nome;
    public int nasc;
    public int ano;
    public int idade;
    public string address;
    public string cpf;

    public Info()
    {
        nome = "Undefined";
        nasc = 0;
        ano = 0;
        idade = ano - nasc;
        address = "Undefined";
        cpf = "Undefined";
    }
    public Info(string nome)
    {
        this.nome = nome;
        nasc = 0;
        ano = 0;
        idade = ano - nasc;
        address = "Undefined";
        cpf = "Undefined";
    }
    public Info(string nome, int data)
    {
        this.nome = nome;
        nasc = data;
        ano = 0;
        idade = ano - nasc;
        address = "Undefined";
        cpf = "Undefined";
    }
    public Info(string nome, int data, int ano)
    {
        this.nome = nome;
        nasc = data;
        this.ano = ano;
        idade = this.ano - nasc;
        address = "Undefined";
        cpf = "Undefined";
    }
    public Info(string nome, int data, int ano, string address)
    {
        this.nome = nome;
        nasc = data;
        this.ano = ano;
        idade = this.ano - nasc;
        this.address = address;
        cpf = "Undefined";
    }
    public Info(string nome, int data, int ano, string address, string cpf)
    {
        this.nome = nome;
        nasc = data;
        this.ano = ano;
        idade = this.ano - nasc;
        this.address = address;
        this.cpf = cpf;
    }
    public void info()
    {
        Console.WriteLine("\n\nNome: {0}\n\nAno de Nascimento: {1}\n\nIdade: {2}\n\nEndereço: {3}\n\nCPF: {4}\n", nome, nasc, idade, address, cpf);
    }
}
static public class Sorte
{
    static public int[] num = new int[7];

    static public void numero()
    {
        Random nalt = new Random();
        Console.Write("\nN° de sorte: ");
        for(int c = 0; c < 7; c++)
        {
            num[c] = nalt.Next(0, 1000000);
        }
        foreach(int n in num)
        {
            Console.Write(n + " ");
        }
    }
}
public class Training
{
    static void Main()
    {
        string nome, cpf, address, novo;
        int ano, data;

        inicio:

        Console.Write("\n\nNome: ");
        nome = Console.ReadLine();
        Console.Write("\n\nAno de nascimento: ");
        data = int.Parse(Console.ReadLine());
        Console.Write("\n\nAno atual: ");
        ano = int.Parse(Console.ReadLine());
        Console.Write("\n\nEndereço: ");
        address = Console.ReadLine();
        Console.Write("\n\nCPF: ");
        cpf = Console.ReadLine();
        Console.Clear();
        Info pessoa = new Info(nome, data, ano, address, cpf);

        pessoa.info();
        Sorte.numero();

        novo:

        Console.Write("\n\nDeseja realizar uma nova consulta?: ");
        novo = Console.ReadLine();
        Console.Clear();
        if (novo == "s" || novo == "S" || novo == "sim" || novo == "Sim" || novo == "SIM")
        {
            Console.Clear();
            goto inicio;
        }else if(novo == "n" || novo == "N" || novo == "não" || novo == "Não" || novo == "NÃO" || novo == "nao" || novo == "Nao" || novo == "NAO")
        {
            Console.Clear();
            goto fim;
        }
        else
        {
            Console.WriteLine("\nResposta inválida {0}...Tente de novo!\n", nome);
            Console.ReadLine();
            Console.Clear();
            goto novo;
        }

    fim:

        Console.WriteLine("\n\nBeleza {0}, até mais!\n", nome);

        Console.ReadLine();
    }
}