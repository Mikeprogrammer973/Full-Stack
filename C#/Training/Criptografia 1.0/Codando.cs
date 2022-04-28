using System;
using System.Collections.Generic;

namespace CodNumber{
    // classes para codagem de números
    public class Cript
    {
        public static void Cript1(int number)
        {
            int code = 0;

            switch (number)
            {
                case 0:
                    code = 48;
                    break;
                case 1:
                    code = 49;
                    break;
                case 2:
                    code = 50;
                    break;
                case 3:
                    code = 51;
                    break;
                case 4:
                    code = 52;
                    break;
                case 5:
                    code = 53;
                    break;
                case 6:
                    code = 54;
                    break;
                case 7:
                    code = 55;
                    break;
                case 8:
                    code = 56;
                    break;
                case 9:
                    code = 57;
                    break;
            }

            Console.WriteLine("\nCódigo 1: {0}\n", code);
        }

        public static void Cript3(int number)
        {
            string code = "0";

            switch (number)
            {// - => subtração ou adição
             // _ => divisão ou multiplicação
                case 0:
                    code = "7-6-1";
                    break;
                case 1:
                    code = "12-1-10";
                    break;
                case 2:
                    code = "34-4-36";
                    break;
                case 3:
                    code = "9-0-6";
                    break;
                case 4:
                    code = "8_2-12";
                    break;
                case 5:
                    code ="18_2-4";
                    break;
                case 6:
                    code = "2_3";
                    break;
                case 7:
                    code = "7_7-7_6";
                    break;
                case 8:
                    code = "6_8-40";
                    break;
                case 9:
                    code = "3-7-1";
                    break;
            }

            Console.WriteLine("\nCódigo 3: {0}\n", code);
        }

        public static void Cript2(int number)
        {
            int code = 0;

            switch (number)
            {
                case 0:
                    code = 4578;
                    break;
                case 1:
                    code = 4569;
                    break;
                case 2:
                    code = 5550;
                    break;
                case 3:
                    code = 5541;
                    break;
                case 4:
                    code = 5532;
                    break;
                case 5:
                    code = 5523;
                    break;
                case 6:
                    code = 5514;
                    break;
                case 7:
                    code = 5505;
                    break;
                case 8:
                    code = 5496;
                    break;
                case 9:
                    code = 5487;
                    break;
            }

            Console.WriteLine("\nCódigo 2: {0}\n", code);
        }
    }
}

namespace CodChar{
    // classes para codagem de letras
    public class Cript
    {
        public static void Cript1(string letra)
        {
            int code = 0;

            switch (letra)
            {
                case "A":
                case "a":
                    code = 1;
                    break;
                case "B":
                case "b":
                    code = 2;
                    break;
                case "C":
                case "c":
                    code = 3;
                    break;
                case "D":
                case "d":
                    code = 4;
                        break;
                case "E":
                case "e":
                    code = 5;
                        break;
                case "F":
                case "f":
                    code = 6;
                        break;
                case "G":
                case "g":
                    code = 7;
                        break;
                case "H":
                case "h":
                    code = 8;
                        break;
                case "I":
                case "i":
                    code = 9;
                        break;
                case "J":
                case "j":
                    code = 10;
                        break;
                case "K":
                case "k":
                    code = 11;
                        break;
                case "L":
                case "l":
                    code = 12;
                        break;
                case "M":
                case "m":
                    code = 13;
                        break;
                case "N":
                case "n":
                    code = 14;
                        break;
                case "O":
                case "o":
                    code = 15;
                        break;
                case "P":
                case "p":
                    code = 16;
                        break;
                case "Q":
                case "q":
                    code = 17;
                        break;
                case "R":
                case "r":
                    code = 18;
                        break;
                case "S":
                case "s":
                    code = 19;
                        break;
                case "T":
                case "t":
                    code = 20;
                        break;
                case "U":
                case "u":
                    code = 21;
                        break;
                case "V":
                case "v":
                    code = 22;
                        break;
                case "W":
                case "w":
                    code = 23;
                        break;
                case "X":
                case "x":
                    code = 24;
                        break;
                case "Y":
                case "y":
                    code = 25;
                        break;
                case "Z":
                case "z":
                    code = 26;
                        break;
            }

            Console.WriteLine("\nCódigo 1: {0}\n", code);
        }


        public static void Cript2(string letra)
        {
            int code = 0;

            switch (letra)
            {
                case "A":
                case "a":
                    code = 126;
                    break;
                case "B":
                case "b":
                    code = 225;
                    break;
                case "C":
                case "c":
                    code = 324;
                    break;
                case "D":
                case "d":
                    code = 423;
                    break;
                case "E":
                case "e":
                    code = 522;
                    break;
                case "F":
                case "f":
                    code = 621;
                    break;
                case "G":
                case "g":
                    code = 720;
                    break;
                case "H":
                case "h":
                    code = 819;
                    break;
                case "I":
                case "i":
                    code = 918;
                    break;
                case "J":
                case "j":
                    code = 1017;
                    break;
                case "K":
                case "k":
                    code = 1116;
                    break;
                case "L":
                case "l":
                    code = 1215;
                    break;
                case "M":
                case "m":
                    code = 1314;
                    break;
                case "N":
                case "n":
                    code = 1413;
                    break;
                case "O":
                case "o":
                    code = 1512;
                    break;
                case "P":
                case "p":
                    code = 1611;
                    break;
                case "Q":
                case "q":
                    code = 1710;
                    break;
                case "R":
                case "r":
                    code = 189;
                    break;
                case "S":
                case "s":
                    code = 198;
                    break;
                case "T":
                case "t":
                    code = 207;
                    break;
                case "U":
                case "u":
                    code = 216;
                    break;
                case "V":
                case "v":
                    code = 225;
                    break;
                case "W":
                case "w":
                    code = 234;
                    break;
                case "X":
                case "x":
                    code = 243;
                    break;
                case "Y":
                case "y":
                    code = 252;
                    break;
                case "Z":
                case "z":
                    code = 261;
                    break;
            }

            Console.WriteLine("\nCódigo 2: {0}\n", code);
        }

        public static void Cript4(string letra)
        {
            int code = 0;

            switch (letra)
            {
                case "A":
                case "a":
                    code = 6905;
                    break;
                case "B":
                case "b":
                    code = 6896;
                    break;
                case "C":
                case "c":
                    code = 6887;
                    break;
                case "D":
                case "d":
                    code = 6878;
                    break;
                case "E":
                case "e":
                    code = 6869;
                    break;
                case "F":
                case "f":
                    code = 7850;
                    break;
                case "G":
                case "g":
                    code = 7841;
                    break;
                case "H":
                case "h":
                    code = 7832;
                    break;
                case "I":
                case "i":
                    code = 7823;
                    break;
                case "J":
                case "j":
                    code = 7814;
                    break;
                case "K":
                case "k":
                    code = 7805;
                    break;
                case "L":
                case "l":
                    code = 7796;
                    break;
                case "M":
                case "m":
                    code = 7787;
                    break;
                case "N":
                case "n":
                    code = 7778;
                    break;
                case "O":
                case "o":
                    code = 7769;
                    break;
                case "P":
                case "p":
                    code = 8750;
                    break;
                case "Q":
                case "q":
                    code = 8741;
                    break;
                case "R":
                case "r":
                    code = 8732;
                    break;
                case "S":
                case "s":
                    code = 8723;
                    break;
                case "T":
                case "t":
                    code = 8714;
                    break;
                case "U":
                case "u":
                    code = 8705;
                    break;
                case "V":
                case "v":
                    code = 8696;
                    break;
                case "W":
                case "w":
                    code = 8687;
                    break;
                case "X":
                case "x":
                    code = 8678;
                    break;
                case "Y":
                case "y":
                    code = 8669;
                    break;
                case "Z":
                case "z":
                    code = 9650;
                    break;
            }

            Console.WriteLine("\nCódigo 4: {0}\n", code);
        }

        public static void Cript3(string letra)
        {
            int code = 0;

            switch (letra)
            {
                case "A":
                case "a":
                    code = 65;
                    break;
                case "B":
                case "b":
                    code = 66;
                    break;
                case "C":
                case "c":
                    code = 67;
                    break;
                case "D":
                case "d":
                    code = 68;
                    break;
                case "E":
                case "e":
                    code = 69;
                    break;
                case "F":
                case "f":
                    code = 70;
                    break;
                case "G":
                case "g":
                    code = 71;
                    break;
                case "H":
                case "h":
                    code = 72;
                    break;
                case "I":
                case "i":
                    code = 73;
                    break;
                case "J":
                case "j":
                    code = 74;
                    break;
                case "K":
                case "k":
                    code = 75;
                    break;
                case "L":
                case "l":
                    code = 76;
                    break;
                case "M":
                case "m":
                    code = 77;
                    break;
                case "N":
                case "n":
                    code = 78;
                    break;
                case "O":
                case "o":
                    code = 79;
                    break;
                case "P":
                case "p":
                    code = 80;
                    break;
                case "Q":
                case "q":
                    code = 81;
                    break;
                case "R":
                case "r":
                    code = 82;
                    break;
                case "S":
                case "s":
                    code = 83;
                    break;
                case "T":
                case "t":
                    code = 84;
                    break;
                case "U":
                case "u":
                    code = 85;
                    break;
                case "V":
                case "v":
                    code = 86;
                    break;
                case "W":
                case "w":
                    code = 87;
                    break;
                case "X":
                case "x":
                    code = 88;
                    break;
                case "Y":
                case "y":
                    code = 89;
                    break;
                case "Z":
                case "z":
                    code = 90;
                    break;
            }

            Console.WriteLine("\nCódigo 3: {0}\n", code);
        }
    }
}

public class Training{
    static void Main(){
        int number;
        string letra, novo, choose, op;

        Console.Write("\nDeseja realizar uma criptografia?: ");
        choose = Console.ReadLine();

    inicio:
        Console.Clear();

        if(choose == "s" || choose == "S" || choose == "sim" || choose == "Sim" || choose == "SIM")
        {
    opcao:

            Console.Write("\n\n[l] Letra\n\n[n] Número\n\nEscolhe uma das opções acima: ");
            op = Console.ReadLine();
            Console.Clear();

            if(op == "l")
            {
                try
                {
                    Console.Write("\nDigite a letra: ");
                    letra = Console.ReadLine();
                    CodChar.Cript.Cript1(letra);
                    CodChar.Cript.Cript2(letra);
                    CodChar.Cript.Cript3(letra);
                    CodChar.Cript.Cript4(letra);
                }catch(Exception ex)
                {
                    Console.WriteLine("\nErro: {0}\n", ex.Message);
                    Console.WriteLine("\nExeção: {0}", ex.GetType());
                }
            }
            else if(op == "n")
            {
                try
                {
                    Console.Write("\nDigite o número (de 0 até 9): ");
                    number = int.Parse(Console.ReadLine());
                    CodNumber.Cript.Cript1(number);
                    CodNumber.Cript.Cript2(number);
                    CodNumber.Cript.Cript3(number);
                } catch(Exception ex)
                {
                    Console.WriteLine("\nErro: {0}\n", ex.Message);
                    Console.WriteLine("\nExeção: {0}", ex.GetType());
                }            
            }
            else
            {
                Console.WriteLine("\nOpção inválida...Tente de novo!\n");
                goto opcao;
            }

        }else if(choose == "n" || choose == "N" || choose == "não" || choose == "Não" || choose == "nao" || choose == "Nao" || choose == "NAO" || choose == "NÃO")
        {
            goto fim;
        }


        Console.Write("\nDeseja realizar uma nova criptografia?: ");
        novo = Console.ReadLine();
        if (novo == "s" || novo == "S" || novo == "sim" || novo == "Sim" || novo == "SIM")
        {
            goto inicio;
        }
        else if (novo == "n" || novo == "N" || novo == "não" || novo == "Não" || novo == "nao" || novo == "Nao" || novo == "NAO" || novo == "NÃO")
        {
            goto fim;
        }

    fim:

        Console.Clear();
        Console.WriteLine("\nBeleza, até mais!!!\n");
        Console.ReadLine();


    }
}