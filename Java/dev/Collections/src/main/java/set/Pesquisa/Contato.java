package main.java.set.Pesquisa;

import java.util.Objects;

public class Contato {
  //atributos
  private String nome;
  private int numero;

  public Contato(String nome, int numero) {
    this.nome = nome;
    this.numero = numero;
  }

  public String getNome() {
    return nome;
  }

  public int getNumero() {
    return numero;
  }

  public void setNumero(int numero) {
    this.numero = numero;
  }

  @Override
  public boolean equals(Object o) {
    Contato contato = new Contato(nome, numero);
    if (this == o) return true;
    if (!(o instanceof Contato)) return false;
    return Objects.equals(getNome(), contato.getNome());
  }

  @Override
  public int hashCode() {
    return Objects.hash(getNome());
  }

  @Override
  public String toString() {
    return "{" + nome + "," + numero + "}";
  }
}
