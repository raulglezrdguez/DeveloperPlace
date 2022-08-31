namespace DeveloperPlace.Shared;

public class DeveloperList
{
    public List<Developer> Developers { get; set; } =
        new List<Developer>();

    public void Add(Developer developer) =>
        Developers.Add(developer);

    public Developer? GetDeveloper(int id) =>
        Developers.SingleOrDefault(developer => developer.Id == id);
}