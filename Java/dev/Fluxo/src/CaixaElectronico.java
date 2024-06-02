import java.util.Locale;
import java.util.Scanner;

public class CaixaElectronico {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in).useLocale(Locale.US);
        double saldo = 376.98;
        System.out.print("\nValor do saque: ");
        double valorSolicitado = scanner.nextDouble();
        scanner.close();

        if(valorSolicitado <= saldo)
        {
            saldo -= valorSolicitado;
        }

        System.out.println("\nSaldo atual: " + saldo + "\n");
    }
}
