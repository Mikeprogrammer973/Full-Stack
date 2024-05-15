package edu.mike.operadores;

public class Operadores {
    public static void main(String[] args) {
        String nomeCompleto = "Linguagem " + "Java";

        System.out.println(nomeCompleto);

        int numero = 7;

        numero = - numero;

        numero++;

        numero -= 3;

        System.out.println(numero >= 0 ? numero : - numero);
    }
}
