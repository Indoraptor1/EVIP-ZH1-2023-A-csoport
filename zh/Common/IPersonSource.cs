namespace Common;

public interface IPersonSource
{
    public IEnumerable<Person> GetPersons();
}