import Generics.Box;

public class App {
    public static void main(String[] args) throws Exception {
        Box box_01 = new Box<String>("OK!");
        Box box_02 = new Box<Boolean>(true);

        System.out.println(box_01.getT());
        System.out.println(box_02.getT());
    }
}
