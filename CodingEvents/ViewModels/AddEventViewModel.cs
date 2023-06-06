using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels;

public class AddEventViewModel
{
    [Required(ErrorMessage = "Name of event is required.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Event name should be between 3-50 characters.")]
    public string? Name { get; set; }
    [StringLength(500, ErrorMessage = "Event description is over 500 characters.")]
    [Required(ErrorMessage = "Description of event is required.")]
    public string? Description { get; set; }
    [EmailAddress]
    public string? ContactEmail { get; set; }
}