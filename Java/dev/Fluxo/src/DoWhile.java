import java.util.Random;

public class DoWhile {
    public static void main(String[] args) {
        System.out.println("\nDiscando...\n");

        do
        {
            System.out.println("Telefone tocando...");
        }while(tocando());

        System.out.println("\nConversando...\n");
    }

    private static boolean tocando()
    {
        return !(new Random().nextInt(7) == 1);
    }
}
