namespace BurguerMania_API.DTOs;
public class CreateUserDto
{
    public string ?Name { get; set; }
    public string ?Email { get; set; }
    public string ?Password { get; set; }
}