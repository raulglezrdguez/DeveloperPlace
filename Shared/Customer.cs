namespace DeveloperPlace.Shared;

public class Customer
{
    // customer id
    public int Id { get; set; }
    // customer name
    public string Name { get; set; } = default!;
    // customer street
    public string Street { get; set; } = default!;
    // customer city
    public string City { get; set; } = default!;
}