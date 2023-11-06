void main() {
  Person person = new Person('John', 17, '528-452-8596');

  person.printInfo();
  person.name = 'Peter';
  print(person.name);

  Father father = new Father('Floriano', 45, '458-8596-895', 'Charpenter');
  father.printInfo();

  World.gravity = 89.87;
  print(World.gravity);

  const int a = 1; //Coisas fixas - que jà conhecemos
  //a++;
  print(a);

  final DateTime date = new DateTime.now();
  //Coisas de fora - que ainda desconhecemos
  //date = new DateTime.timestamp();
  print(date.toString());

  Player player = new Player(7, 85, 'Big Hero X');
  player.show();
}

abstract class Character {
  int posX = 0;
  int posY = 0;
  String name = "";
  Character(this.posX, this.posY, this.name);
  void show() {
    print('Your player is located at position $posX e $posY');
  }
}

class Player extends Character {
  Player(int posX, int posY, String name) : super(posX, posY, name);
}

class World {
  static double gravity = 54.89;
}

class Person {
  String _name = '';
  int age = 0;
  String tel = '';

  Person(String name, this.age, this.tel) {
    this.name = name;
  }

  String get name {
    return this._name;
  }

  set name(String name) {
    this._name = name;
  }

  void printInfo() {
    print('Name: ${this.name}');
    print('Age: ${this.age}');
    print('Tel: ${this.tel}');
  }
}

class Father extends Person {
  String profession = '';

  Father(String name, int age, String tel, this.profession)
      : super(name, age, tel);

  @override
  void printInfo() {
    print('Name: ${this.name}');
    print('Age: ${this.age}');
    print('Tel: ${this.tel}');
    print('Profession: ${this.profession}');
  }
}
