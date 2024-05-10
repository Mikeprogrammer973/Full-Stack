package edu.mike.tipos_variaveis;

public class TiposVariaveis {
    public static void main(String[] args) {
        double salarioMinimo = 2500.36;
        float pi = 3.14f; //Precisa de un f/F no final
        long cpf = 80083057989l; // Precisa de um l/L no final

        short numeroCurto = 1;
        int numeroNormal = numeroCurto;
        short numeroCurto2 = (short) numeroNormal; // Fortemente tipado

        int numero = 5;

        numero = 7;

        System.out.print(numero);

        String meuNome = "Karina Reys";
        
        // Constantes

        final double VALOR_DE_PI = 3.14;

        //VALOR_DE_PI = 3.1415; // Não pode mudar!
    }
}
