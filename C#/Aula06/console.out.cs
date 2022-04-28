using System;

class Aula06{
    static void Main(){
        /*
        int n1, n2, n3;
        n1 = 10;
        n2 = 20;
        n3 = 30;

        Console.Write("\nn1 =\t{0}\nn2 =\t{1}\nn3 =\t{2}\n", n1, n2, n3);
        */

        double valorCompra = 7.50;
        double valorVenda;
        double lucro = 0.5;
        string produto = "Pastel";
        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("\nProduto................:{0, 17}", produto);
        Console.WriteLine("\nValor de Compra........:{0, 17 :c}", valorCompra);
        Console.WriteLine("\nLucro..................:{0, 17 :p}", lucro);
        Console.WriteLine("\nValor de Venda.........:{0, 17 :c}\n", valorVenda);
    }
}