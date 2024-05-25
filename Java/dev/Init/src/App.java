import java.util.Locale;
import java.util.Scanner;

public class App {
    public static void main(String[] args) {
        System.out.println("Oi, fui executado pelo Terminal!\n\n");

        /*
        String nome = args[0];
        String sobrenome = args[1];
        int idade = Integer.valueOf(args[2]);
        double altura = Double.valueOf(args[3]);
        */

        Scanner scanner = new Scanner(System.in).useLocale(Locale.US);

        System.out.println("Digite o seu nome");
        String nome = scanner.next();

        System.out.println("\nDigite o seu sobrenome");
        String sobrenome = scanner.next();

        System.out.println("\nDigite a sua idade");
        int idade = scanner.nextInt();

        System.out.println("\nDigite a sua altura");
        float altura = scanner.nextFloat();

        scanner.close();

        System.out.println("\n\nOlá, meu nome é " + nome + " " + sobrenome);
        System.out.println("Eu tenho " + idade + " anos");
        System.out.println("Minha altura é " + altura + " m\n\n");
    }
}
