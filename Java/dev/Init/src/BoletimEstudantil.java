public class BoletimEstudantil 
{
    public static void main(String[] args)
    {
        double media = 7;

        if(media >= 6)
        {
            if(media >= 8)
            {
                if(media >= 9.5)
                {
                    System.err.print("APROVADO COM EXCELÊNCIA");
                }
                else
                {
                    System.out.print("APROVADO");
                }
            }
            else
            {
                System.out.print("PROVA DE MINERVA");
            }
        }
        else
        {
            System.out.print("REPROVADO");
        }
    }
}
