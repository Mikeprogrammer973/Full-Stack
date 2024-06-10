public class ForArray {
    public static void main(String[] args) {
        String[] alunos = {"Tamires", "Samantha", "Viviane", "Sarah", "Karoline", "Paula", "Fernanada", "Lola"};

        for (int i = 0; i < alunos.length; i++) {
            System.out.println("\nO(A) aluno(a) na indice " + i + " se chama " + alunos[i]);
        }

        System.out.println("--------------------------------------------------");

        for(String aluno : alunos)
        {
            System.out.println(aluno);
        }
    }
}
