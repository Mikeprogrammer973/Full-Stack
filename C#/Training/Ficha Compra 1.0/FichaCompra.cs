using System;

class Training{
    
    static void Main(){

        string nome = "Mike Pascal";
        string localCompra = "Atacadão";
        string p1 = "Maçã";
        string p2 = "Carne";
        string p3 = "Arroz";
        string p4 = "Ketchup";
        string p5 = "Farina";
        string p6 = "Salsicha";
        string p7 = "Faca";
        int qtdm = 10, qtdc = 3, qtda = 1, qtdk = 2, qtdf = 2, qtds = 1, qtdf2 = 1;
        double pp1 = qtdm * 0.75, pp2 = qtdc * 20.95, pp3 = qtda * 23.5, pp4 = qtdk * 6.8, pp5 = qtdf * 7.9, pp6 = qtds * 28.3, pp7 = qtdf2 * 34.6;
        double ptotal = pp1 + pp2 + pp3 + pp4 + pp5 + pp6 + pp7;
        double imE = ((ptotal * 0.02) / 100);
        double imF = ((ptotal * 0.07) / 100);
        Console.WriteLine("\nComprador: {0}\n\nEstabelecimento: {1}\n", nome, localCompra);
        Console.WriteLine("\nCompras..........................................\n");
        Console.WriteLine("\n\t1. {0} \tQtd......{1}    {2, 7:c}", p1, qtdm, pp1);
        Console.WriteLine("\n\t2. {0} \tQtd......{1}Kg   {2, 7:c}", p2, qtdc, pp2);
        Console.WriteLine("\n\t3. {0} \tQtd......{1}     {2, 7:c}", p3, qtda, pp3);
        Console.WriteLine("\n\t4. {0} \tQtd......{1}     {2, 7:c}", p4, qtdk, pp4);
        Console.WriteLine("\n\t5. {0} \tQtd......{1}Kg   {2, 7:c}", p5, qtdf, pp5);
        Console.WriteLine("\n\t6. {0} \tQtd......{1}     {2, 7:c}", p6, qtds, pp6);
        Console.WriteLine("\n\t7. {0} \tQtd......{1}     {2, 7:c}", p7, qtdf2, pp7);
        Console.WriteLine("\n\t\t\tTotal..........{0, 7:c}\n", ptotal);
        Console.WriteLine("\nImposto Estuadual......  {0, 7:p} ({0, 1:c})", imE);
        Console.WriteLine("\nImposto Federal........  {0, 7:p} ({0, 1:c})\n", imF);
        Console.WriteLine("\n\n................................................................................");
        Console.WriteLine("\n\n\tObrigado {0} pela preferência, volte sempre!!!\n\n", nome);
        Console.ReadLine();
    }
}