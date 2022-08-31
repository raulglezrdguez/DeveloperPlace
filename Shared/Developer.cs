namespace DeveloperPlace.Shared;

public class Developer
{
    public int Id { get; }
    public string Name { get; }
    public decimal Salary { get; }
    public Levels Level { get; }

    public Developer(int id, string name, decimal salary, Levels level)
    {
        this.Id = id;
        this.Name = name;
        this.Salary = salary;
        this.Level = level;
    }
}