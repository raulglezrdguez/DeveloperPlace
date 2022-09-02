namespace DeveloperPlace.Shared;

// app state
public class State
{
    // developer list
    public DeveloperList DeveloperList { get; } = new DeveloperList();
    // developer group selected by the customer
    public DeveloperGroup Group { get; } = new DeveloperGroup();
    // user interface
    public UI UI { get; } = new UI();

    // returns total group salary 
    public decimal TotalSalary() =>
        Group.Members.Sum(id => DeveloperList.GetDeveloper(id)!.Salary);
}