namespace DeveloperPlace.Shared;

public class State
{
    public DeveloperList DeveloperList { get; } = new DeveloperList();
    public DeveloperGroup Group { get; } = new DeveloperGroup();
    public UI UI { get; } = new UI();
}