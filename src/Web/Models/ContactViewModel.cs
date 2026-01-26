using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models;

public class ContactViewModel
{
    public int? Id { get; set; }

    [Required]
    [DisplayName("Name")]
    public string Name { get; set; }

    [Required]
    [DisplayName("Email")]
    public string Email { get; set; }
}