void main() {
  // Produtos

  int codigo = 7;

  double preco = 2.85;

  String nome = 'Sabonete Iris';

  bool desconto = true;

  var loja = 'My Stores';
  //loja = 4;

  dynamic variable = 74;
  variable = '00K';

  /*print(codigo);
  print(preco);
  print(nome);
  print(desconto ? 'Oui' : 'Non');
  print(loja);
  print(variable);*/

  /*print('Code: $codigo');
  print('Code 2: ${codigo + 7}');*/

  //print('Code: ' + codigo.toString());

  print('O produto $codigo é um $nome e o seu preço é $preco reais.');

  print(check_num(7));
  print(check_num(456));
  print(check_num(251));
}

String check_num(int num) {
  if (num % 2 != 0) {
    return '$num é um mumero impar!';
  }
  return '$num é um mumero par!';
}
