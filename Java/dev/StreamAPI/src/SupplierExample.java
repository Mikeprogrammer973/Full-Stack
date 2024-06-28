import java.util.List;
import java.util.function.Supplier;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class SupplierExample {
    public static void main(String[] args) {
        Supplier<String> saudacao = () -> "Hello, your are welcome!";

        //List<String> saudacoes = Stream.generate(saudacao).limit(7).collect(Collectors.toList());

        List<String> saudacoes = Stream.generate(() -> "Hello, you are welcome!").limit(7).collect(Collectors.toList());

        saudacoes.forEach(s -> System.out.println(s));
    }
}
