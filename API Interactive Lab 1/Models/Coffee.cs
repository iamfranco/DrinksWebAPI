namespace API_Interactive_Lab_1.Models;

public class Coffee
{
    private static int _nextId = 0;

    public string Name { get; init; }
    public int Id { get; init; }

    public Coffee(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public Coffee(string name) : this(name, _nextId++)
    {
    }
}
