import java.text.NumberFormat;
import java.util.concurrent.ThreadLocalRandom;
public class While_ {
    public static void main(String[] args) {
        double mesada = 78.85;

        System.out.println("\n\nMesada: " + mesada + "$\n\n");

        while(mesada > 0)
        {
            double valorDoce = ValorAleatorio();

            if(valorDoce > mesada) valorDoce = mesada;

            System.out.println("\nDoce do valor de " + NumberFormat.getCurrencyInstance().format(valorDoce) + " adicionado no carrinho...");

            mesada -= valorDoce;
        }

        System.out.println("\n\nMesada: " + mesada + "$\n");
        System.out.println("Joozinho gastou toda a sua mesada em doces!");
    }

    private static double ValorAleatorio()
    {
        return ThreadLocalRandom.current().nextDouble(2, 8);
    }
}
