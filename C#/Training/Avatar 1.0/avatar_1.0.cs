using System;

public class AvatarLevel1
{
    public string nome;
    public static int anoAtual;
    protected string corCabelo;
    private string vestimentos;
    protected string ferramentas;
    protected string habilidades;
    protected string level;
    private string corPele;
    private string tipoCabelo;

    public AvatarLevel1(string nome)
    {
        this.nome = nome;

        Random alt = new Random();
        int cor;
        cor = alt.Next(1, 3);
        switch (cor)
        {
            case 1:
                corCabelo = "Preto";
                break;
            case 2:
                corCabelo = "Cinza";
                break;
            case 3:
                corCabelo = "Branco";
                break; 
        }

        int vest;
        vest = alt.Next(1, 10);
        switch (vest)
        {
            case 1:
                vestimentos = "Camiseta branca, Short azul, Havaianas";
                break;
            case 2:
                vestimentos = "Regata preta, Calça jeans, Botas";
                break;
            case 3:
                vestimentos = "Jaqueta preta, Bermuda branca, Tênis Puma";
                break;
            case 4:
                vestimentos = "Camisa cinza, Calça branca, Chinelos";
                break;
            case 5:
                vestimentos = "Moletom azul, Bermuda azul, Havaianas";
                break;
            case 6:
                vestimentos = "Regata branca, Short preta, Tênis Nike";
                break;
            case 7:
                vestimentos = "Camiseta amarela, Calça jeans, Botas";
                break;
        }

        ferramentas = "Pedra, Faca, Lençol";

        habilidades = "Rapidez, Super Força, Visão de Águia";

        level = "Nível 1";

        int corpele;
        corpele = alt.Next(1, 3);
        switch (corpele)
        {
            case 1:
                corPele = "Preto(a)";
                break;
            case 2:
                corPele = "Branco(a)";
                break;
            case 3:
                corPele = "Moreno(a)";
                break;
        }

        int ticab;
        ticab = alt.Next(1, 3);
        switch (ticab)
        {
            case 1:
                tipoCabelo = "Curto";
                break;
            case 2:
                tipoCabelo = "Cacheado";
                break;
            case 3:
                tipoCabelo = "Longo";
                break;
        }

    }
    public string getCorPele()
    {
        return corPele;
    }
    public string getVestimentos()
    {
        return vestimentos;
    }
    public string getTipoCabelo()
    {
        return tipoCabelo;
    }
    public static int setAnoAtual(int ano)
    {
        anoAtual = ano;
        return anoAtual;
    }
    public void info()
    {
        Console.WriteLine("\nNome: {0}\n", nome);
        Console.WriteLine("Cor de Cabelo: {0}\n", corCabelo);
        Console.WriteLine("Tipo de Cabelo: {0}\n", tipoCabelo);
        Console.WriteLine("Vestimentos: {0}\n", vestimentos);
        Console.WriteLine("Ferramentas: {0}\n", ferramentas);
        Console.WriteLine("Cor da Pele: {0}\n", corPele);
        Console.WriteLine("Habilidades: {0}\n", habilidades);
        Console.WriteLine("Nível: {0}\n", level);
    }
}
public class AvatarLevel2 : AvatarLevel1
{
    public AvatarLevel2(string nome) : base(nome)
    {
        this.nome = nome;

        Random alt = new Random();
        int cor;
        cor = alt.Next(1, 3);
        switch (cor)
        {
            case 1:
                corCabelo = "Verde";
                break;
            case 2:
                corCabelo = "Laranja";
                break;
            case 3:
                corCabelo = "Amarelo";
                break;
        }

        ferramentas = "Faca, Isqueiro, Fusil";

        habilidades = "Super Inteligência, Voar, Invisibilidade";

        level = "Nível 2";
    }
}
public class AvatarLevel3 : AvatarLevel2
{
    public AvatarLevel3(string nome) : base(nome)
    {
        this.nome = nome;

        Random alt = new Random();
        int cor;
        cor = alt.Next(1, 5);
        switch (cor)
        {
            case 1:
                corCabelo = "Dourado";
                break;
            case 2:
                corCabelo = "Vermelho";
                break;
            case 3:
                corCabelo = "Azul";
                break;
            case 4:
                corCabelo = "Marrom";
                break;
            case 5:
                corCabelo = "Branca";
                break;
        }

        ferramentas = "Revólver, Grenada, Fusil, Bomba, Faca";

        habilidades = "Super Inteligência, Invisibilidade, Teletransporte, Telekinesia";

        level = "Nível 3";
    }
}
public class Training
{
    static void Main()
    {
        int nasc, idade, atual;
        string nome, avatarNome, sim, novo;

        Console.Write("\nDigite o seu nome: ");
        nome = Console.ReadLine();
        Console.Write("\nAno de Nascimento: ");
        nasc = int.Parse(Console.ReadLine());
        Console.Write("\nAno Atual: ");
        atual= int.Parse(Console.ReadLine());

        idade = AvatarLevel1.setAnoAtual(atual) - nasc;

        inicio:

        Console.Clear();
        Console.Write("\nDeseja Configurar um avatar {0}?: ", nome);
        sim = Console.ReadLine();
        Console.Clear();

        if (sim == "s" || sim == "S" || sim == "sim" || sim == "Sim" || sim == "SIM")
        {
            if(idade < 8 || idade >= 50)
            {
                Console.Write("\nNome do avatar: ");
                avatarNome = Console.ReadLine();
                AvatarLevel1 avatar = new AvatarLevel1(avatarNome);
                Console.Clear();
                avatar.info();
                
            }else if(idade >= 7 && idade < 15 || idade > 30 && idade < 50)
            {
                Console.Write("\nNome do avatar: ");
                avatarNome = Console.ReadLine();
                AvatarLevel2 avatar = new AvatarLevel2(avatarNome);
                Console.Clear();
                avatar.info();
            }
            else
            {
                Console.Write("\nNome do avatar: ");
                avatarNome = Console.ReadLine();
                AvatarLevel3 avatar = new AvatarLevel3(avatarNome);
                Console.Clear();
                avatar.info();
            }
        }else if(sim == "n" || sim == "N" || sim == "não" || sim == "Não" || sim == "NÃO" || sim == "nao" || sim == "Nao" || sim == "NAO")
        {
            goto fim;
        }
        else
        {
            Console.WriteLine("\n\nResposta inválida...Tente de novo!");
            Console.ReadLine();
            goto inicio;
        }

    novo:

        Console.Write("\n\nDesja configurar um novo avatar {0}?: ", nome);
        novo = Console.ReadLine();

        if (novo == "s" || novo == "S" || novo == "sim" || novo == "Sim" || novo == "SIM")
        {
            goto inicio;
        }
        else if (novo == "n" || novo == "N" || novo == "não" || novo == "Não" || novo == "NÃO" || novo == "nao" || novo == "Nao" || novo == "NAO")
        {
            goto fim;
        }
        else
        {
            Console.WriteLine("\n\nResposta inválida...Tente de novo!");
            Console.ReadLine();
            goto novo;
        }

    fim:

        Console.Clear();
        Console.WriteLine("\n\nBeleza {0}, até mais!", nome);
        Console.ReadLine();
    }
}