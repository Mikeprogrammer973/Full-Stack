package edu.mike.metodos;

public class Metodos {
    public static void main(String[] args) {
        System.out.println(new Metodos().somar(5.6, 9.08));
        imprimir("Caramba! Sou muito foda, mano!");
    }

    public double somar(double n1, double n2)
    {
        return n1 + n2;
    }

    public static void imprimir(String message)
    {
        System.out.println(message);
    }
}
