namespace Common;

public class Person
{
    public string name { get; set; }
    public int age { get; set; }
    public int height { get; set; }

    public Person(string name, int age, int height){
        this.name = name;
        this.age = age;
        this.height = height;
    }

    public static Person GetMe()
    {
        return new Person("Zsombor", 20, 180);
    }

    public override string ToString()
    {
        return $"Név: {name}, Kor: {age}, Magasság: {height}";
    }
}