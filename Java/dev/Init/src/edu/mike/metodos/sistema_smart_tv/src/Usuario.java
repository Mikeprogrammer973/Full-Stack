package edu.mike.metodos.sistema_smart_tv.src;

public class Usuario {
    public static void main(String[] args) throws Exception {
        SmartTv smartTv = new SmartTv();

        smartTv.selecionarCanal(53);

        smartTv.diminuirCanal();
        smartTv.diminuirCanal();

        System.out.println("TV ligada: " + smartTv.ligada);
        System.out.println("Canal atual: " + smartTv.canal);
        System.out.println("Volume atual: " + smartTv.volume);

        smartTv.ligar();

        System.out.println("Novo Status -> TV ligada: " + smartTv.ligada);

        for(int i = 0; i < 15; i++)
        {
            smartTv.aumentarVolume();
        }

        System.out.println("Novo Status -> Volume: " + smartTv.volume);
    }
}
