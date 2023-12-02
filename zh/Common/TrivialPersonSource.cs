namespace Common;

public class TrivialPersonSource : IPersonSource
{
    private int n; 
    public TrivialPersonSource(int n)
    {
        this.n = n;
    }
    public IEnumerable<Person> GetPersons()
    {
        for (int i = 0; i < n; i++)
        {
            yield return Person.GetMe();
        }
    }
}