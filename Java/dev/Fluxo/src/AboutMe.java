import java.util.InputMismatchException;
import java.util.Locale;
import java.util.Scanner;

public class AboutMe {
    public static void main(String[] args) {
        try {
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

            System.out.println("\n\nOlá, meu nome é " + nome.toUpperCase() + " " + sobrenome.toUpperCase());
            System.out.println("Eu tenho " + idade + " anos");
            System.out.println("Minha altura é " + altura + " m\n\n");
        } catch (InputMismatchException e) {
            System.err.println("\nOs campos idade e altura precisam ser numericos!\n");
        }

    }
}
