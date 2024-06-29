import java.util.Arrays;
import java.util.List;
import java.util.function.Function;
import java.util.stream.Collectors;

public class FunctionExample {
    public static void main(String[] args) {
        List<Integer> numeros = Arrays.asList(2, 4, 6,7, 11, 23, 44, 67);

        Function<Integer, Integer> dobrar = numero -> numero * 2;

        //List<Integer> numerosDobrados = numeros.stream().map(dobrar).collect(Collectors.toList());

        List<Integer> numerosDobrados = numeros.stream().map(numero -> numero * 2).collect(Collectors.toList());

        numerosDobrados.stream().forEach(System.out::println);
    }
}
