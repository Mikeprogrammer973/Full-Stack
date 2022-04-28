using System;

class variables{

static void Main(){
    /*
    byte n1 = 12; // (8 bits) entre 0 e 255
    int num = -10;
    char letra = 'm';
    float valor = 17.56f;
    string nome = "Mike";
    */
    int num1, num2, res;
    num1 = 10;
    num2 = 2;
    res = num1 + num2;

    var aux = res;// Não precisa especificar o tipo

    Console.WriteLine( num1 + " + " + num2 + " = " + aux);
    Console.ReadLine();

}
}