using System;

class Aula18{
    static void Main(){
     
        int[,] n = new int[3,5];
        int[,] num = new int[2,2]{{10,20},{30,40}};
        /*
        10 20 30 40 50
        60 70 80 90 51
        11 21 31 41 52
        */
    

        n[0,0] = 10;  n[0,1] = 20;  n[0,2] = 30;  n[0,3] = 40;  n[0,4] = 50; 
        n[1,0] = 60;  n[1,1] = 70;  n[1,2] = 80;  n[1,3] = 90;  n[1,4] = 51;
        n[2,0] = 11;  n[2,1] = 21;  n[2,2] = 31;  n[2,3] = 41;  n[2,4] = 52;

        Console.WriteLine(num[0,0]);
        Console.ReadLine();

    }
}