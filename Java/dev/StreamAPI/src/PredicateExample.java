import java.util.Arrays;
import java.util.List;
import java.util.function.Predicate;

public class PredicateExample {
    public static void main(String[] args) {
        List<String> words = Arrays.asList("Java", "Python", "Csharp", "C++", "PHP", "Laravel");

        Predicate<String> maisDe5Chars = word -> word.length() > 5;

        words.stream().filter(maisDe5Chars).forEach(System.out::println);
    }
}
