using Common;

namespace Tests;

public class AdvancedPersonSourceTests
{
    [Fact]
    public void TestList()
    {
        AdvancedPersonSource advancedPersonSource = new();
        advancedPersonSource.AddPerson("John", 12, 123);
        advancedPersonSource.AddPerson("Big Joe", 112, 80);
        advancedPersonSource.AddPerson("ASD", 52, 55);
        Assert.Equal(3, advancedPersonSource.GetPersons().Count());
    }
}