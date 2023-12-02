using Common;

namespace Tests;

public class TrivialPersonSourceTests
{
    [Fact]
    public void TestGetPersons()
    {
        var source = new TrivialPersonSource(12);
        var persons = source.GetPersons();
        Assert.Equal(12, persons.Count());
    }
}