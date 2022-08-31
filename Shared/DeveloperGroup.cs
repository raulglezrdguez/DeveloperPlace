namespace DeveloperPlace.Shared;

public class DeveloperGroup
{
    public Customer Customer { get; set; } = new Customer();
    public List<int> Members { get; set; } = new List<int>();
    public bool GroupClosed { get; set; } = false;
}