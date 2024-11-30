using System.ComponentModel.DataAnnotations;

public class CreateUserForm
{
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string ?Name { get; set; }

    [Required]
    [EmailAddress]
    public string ?Email { get; set; }

    [Required]
    [MinLength(6)]
    public string ?Password { get; set; }
}
