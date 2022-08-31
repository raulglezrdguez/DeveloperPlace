namespace DeveloperPlace.Shared;

public class DeveloperList
{
    // developers list
    public List<Developer> Developers { get; set; } =
        new List<Developer>();

    // add new member to developer list
    public void Add(Developer developer) =>
        Developers.Add(developer);

    // get a developer from the developer list
    public Developer? GetDeveloper(int id) =>
        Developers.SingleOrDefault(developer => developer.Id == id);
}