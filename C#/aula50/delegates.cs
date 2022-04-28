using System;

delegate int Operation(int n1, int n2);

class Mat{

public static int soma(int n1, int n2){
    return n1 + n2;
}

public static int div(int n1, int n2){
    return n1 / n2;
}

public static int mul(int n1, int n2){
    return n1 * n2;
}

}

class Aula50{
    static void Main(){
        int vsoma, vmult, vdiv;
        
        Operation d1 = new Operation(Mat.soma);

        vsoma = d1(12, 7);

        Console.WriteLine("Soma: {0}", vsoma);

        d1 = new Operation(Mat.mul);

         vmult= d1(12, 7);

        Console.WriteLine("Multiplicação: {0}", vmult);

         d1 = new Operation(Mat.div);

         vdiv= d1(12, 6);

        Console.WriteLine("Divisão: {0}", vdiv);

    }
}