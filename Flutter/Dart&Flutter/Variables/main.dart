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

  print(
      'O produto $codigo é um $nome e o seu preço é $preco reais.\nEn promotion: ${(desconto ? 'Oui' : 'Non')}');

  print(check_num(7));
  print(check_num(456));
  print(check_num(251));

  if (0 > 9 && 7 > 9) {
    print('OK 1');
  } else {
    print('NO OK 1');
    if (9 >= 21 || 0 == 0) {
      print('OK 2');
    }
  }

  int num = 3;

  switch (num) {
    case 1:
    case 2:
    case 3:
      print('--$num--');
      break;
    case 7:
      print('Jackpot!!!');
      break;
    default:
      print('__ $num __');
  }
}

String check_num(int num) {
  if (num % 2 != 0) {
    return '$num é um mumero impar!';
  }
  return '$num é um mumero par!';
}
