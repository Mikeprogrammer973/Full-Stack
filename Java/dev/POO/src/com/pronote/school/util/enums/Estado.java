package com.pronote.school.util.enums;

public enum Estado {
    SANTA_CATARINA("Santa Catarina", "SC"),
    RIO_DE_JANEIRO("Rio de Janeiro", "RJ"),
    MINA_GERAIS("Mina Gerais", "MG"),
    ESPIRITO_SANTO("Espírito Santo", "ES"),
    BELO_HORIZONTE("Belo Horizonte", "BH");

    private String nome;
    private String sigla;

    private Estado(String nome, String sigla){
        this.nome = nome;
        this.sigla = sigla;
    }

    public String getNome() {
        return nome;
    }
    public String getSigla() {
        return sigla;
    }
    public void setNome(String nome) {
        this.nome = nome;
    }
    public void setSigla(String sigla) {
        this.sigla = sigla;
    }
    public String getNomeMaiusculo()
    {
        return this.nome.toUpperCase();
    }

    
}
