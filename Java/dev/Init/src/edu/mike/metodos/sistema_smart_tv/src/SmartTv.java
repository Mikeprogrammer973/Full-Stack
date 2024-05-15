package edu.mike.metodos.sistema_smart_tv.src;

public class SmartTv {
    boolean ligada = false;
    int canal = 7;
    int volume = 54;

    public void aumentarCanal()
    {
        canal++;
    }

    public void diminuirCanal()
    {
        if(canal > 1)
            canal--;
    }

    public void selecionarCanal(int canal)
    {
        this.canal = canal;
    }

    public void aumentarVolume()
    {
        if(volume < 100)
            volume++;
    }

    public void diminuirVolume()
    {
        if(volume > 0)
            volume--;
    }

    public void ligar()
    {
        ligada = true;
    }

    public void desligar()
    {
        ligada = false;
    }
}
