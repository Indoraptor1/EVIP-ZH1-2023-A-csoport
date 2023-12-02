namespace Common;

public class AdvancedPersonSource : IPersonSource
{
    private List<Person> Persons { get; set; }
    public IEnumerable<Person> GetPersons()
    {
        return Persons;
    }

    public void AddPerson(string name, int age, int height)
    {
        Persons.Add(new Person(name, age, height));
    }

    public AdvancedPersonSource()
    {
        Persons = new List<Person>();
    }
}