namespace MyCollection;

internal class Dog
{
    private string _name;
    private int _age;

    public Dog()
    {
        _name = "No name";
        _age = 0;
    }

    public Dog (string name, int age)
    {
        _name = name;
        _age = age;
    }

    public override string ToString()
    {
        string str = "-- Собака --\n";
        str += "Name: " + _name + "\n";
        str += $"Age: {_age}";
        return str;
    }
}
