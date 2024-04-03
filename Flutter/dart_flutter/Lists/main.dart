
void main()
{
  List<String> people = ['Mary', 'Harry', 'Jane', 'Patrick'];

  print(people);

  print(people[2]);

  people.add('Peter');

  people.insert(3, 'Fred');

  people.removeAt(4);

  print(people);

  print(people.contains('Davi'));

  people.forEach((person)=> print(person));
}