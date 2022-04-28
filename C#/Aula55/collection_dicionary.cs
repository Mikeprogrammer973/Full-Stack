using System;
using System.Collections.Generic;

class Aula55{
    static void Main(){

        Dictionary <int, string> veiculos = new Dictionary<int,string> ();

        veiculos.Add(7, "Carro");
        veiculos.Add(17, "Avião");
        veiculos.Add(1, "Moto");
        veiculos.Add(19, "Navio");
        veiculos.Add(23, "Caminhão");

        //veiculos.Clear();

        veiculos.Remove(19);

        Console.WriteLine("\nTamanho do Dicionário: {0}\n", veiculos.Count);

        var key = 19;
        if(veiculos.ContainsKey(key)){
            Console.WriteLine("\nA chave {0} foi encontrada com sucesso!\n", key);
        }else{
            Console.WriteLine("\nA chave {0} não foi encontrada!\n", key);
        }

        veiculos[23] = "Bicicleta";

        var value = "Bicicleta";
        if(veiculos.ContainsValue(value)){
            Console.WriteLine("\nO valor '{0}' foi encontrado com sucesso!\n", value);
        }else{
            Console.WriteLine("\nO valor  '{0}' não foi encontrado!\n", value);
        }

        Dictionary <int, String>.ValueCollection valores = veiculos.Values;
        Console.Write("\nÌtens do Dicionário: ");
        foreach (string v in valores)
        {
            Console.Write(v + "  ");

        }

        Console.Write("\nÌtens do Dicionário: ");
        foreach (KeyValuePair<int,string> v in veiculos)
        {
            Console.Write(v.Value + "(" + v.Key + ")" + "  ");

        }

    }
}