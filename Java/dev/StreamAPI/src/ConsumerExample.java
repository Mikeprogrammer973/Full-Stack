import java.util.Arrays;
import java.util.List;
import java.util.function.Consumer;

public class ConsumerExample {
    public static void main(String[] args) {
        List<Integer> numeros = Arrays.asList(1, 2, 5, 12, 23, 45, 66, 84, 95, 98);

        Consumer<Integer> imprimirNumerosPares = numero -> {
            if(numero % 2 == 0)
                System.out.println(numero);
        };

        //numeros.stream().forEach(imprimirNumerosPares);
        numeros.stream().forEach(n -> {
            if(n % 2 == 0) System.out.println(n);
        });
    }
}
