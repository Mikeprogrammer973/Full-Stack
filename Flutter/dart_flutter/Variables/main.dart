import 'dart:math';

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

  print(check_num(num: 7));
  print(check_num(num: 456));
  print(check_num(num: 251));

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

  for (int i = 0; i < 10; i++) {
    for (int j = 0; j < 10; j++) {
      print('$i$j');
    }
  }

  int count = 0;
  while (count < 7) {
    print(count);
    count++;
  }

  bool found = false;
  do {
    int val = Random().nextInt(100) + 7;
    if (val % 2 == 0) {
      found = true;
      print('Sim, assim é...');
    } else {
      found = false;
      print('Acabou a sorte...');
    }
  } while (found);
}

String check_num({int num = 2}) {
  if (num % 2 != 0) {
    return '$num é um mumero impar!';
  }
  return '$num é um mumero par!';
}
