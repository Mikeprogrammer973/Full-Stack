void main() {
  Person person = new Person('John', 17, '528-452-8596');

  person.printInfo();
  person.name = 'Peter';
  print(person.name);
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
