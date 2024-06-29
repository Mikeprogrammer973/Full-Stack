import java.util.Arrays;
import java.util.List;
import java.util.function.BinaryOperator;

public class BinaryOperatorExample {
    public static void main(String[] args) {
        List<Integer> numbers = Arrays.asList(5, 10, 15, 7, 2, 20);

        BinaryOperator<Integer> somar = (number1, number2) -> number1 + number2;

        System.out.println("Soma do números: " + numbers.stream().reduce(0, somar));
    }
}
