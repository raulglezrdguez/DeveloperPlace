using System.ComponentModel.DataAnnotations;

namespace DeveloperPlace.Shared;

public class Customer
{
    // customer id
    public int Id { get; set; }
    // customer name
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = default!;
    // customer street
    [Required(ErrorMessage = "Street is required")]
    public string Street { get; set; } = default!;
    // customer city
    [Required(ErrorMessage = "City is required")]
    public string City { get; set; } = default!;
}