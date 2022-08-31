namespace DeveloperPlace.Shared;

public class Developer
{
    // developer id
    public int Id { get; }
    // developer name
    public string Name { get; }
    // developer salary
    public decimal Salary { get; }
    // developer level
    public Levels Level { get; }

    public Developer(int id, string name, decimal salary, Levels level)
    {
        this.Id = id;
        this.Name = name;
        this.Salary = salary;
        this.Level = level;
    }
}