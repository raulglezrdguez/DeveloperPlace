namespace DeveloperPlace.Shared;

public class DeveloperGroup
{
    // client who created the developer group
    public Customer Customer { get; set; } = new Customer();
    // members list of the developer group
    public List<int> Members { get; set; } = new List<int>();
    // is the group closed
    public bool GroupClosed { get; set; } = false;
    // add developer id to this group members
    public void Add(int developerId) => Members.Add(developerId);

    // remove a developer at position pos
    public void RemoveAt(int pos) => Members.RemoveAt(pos);

}