using Common;

TrivialPersonSource tsource = new(3);
AdvancedPersonSource asource = new();
asource.AddPerson("John", 12, 123);
asource.AddPerson("Big Joe", 112, 80);
asource.AddPerson("ASD", 52, 55);
asource.AddPerson("ASD2", 52, 55);
foreach (var person in tsource.GetPersons())
{
    Console.WriteLine(person.ToString());
}

foreach (var person in asource.GetPersons())
{
    Console.WriteLine(person.ToString());
}
