using Microsoft.AspNetCore.Mvc;
using BurguerMania_API.Services;
using BurguerMania_API.DTOs;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UserService _service;

    public UsersController(UserService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<UserDto>> GetAllUsers()
    {
        return Ok(_service.GetAllUsers());
    }

    [HttpPost]
    public ActionResult<UserDto> CreateUser(CreateUserDto createUserDto)
    {
        var user = _service.CreateUser(createUserDto);
        return CreatedAtAction(nameof(GetAllUsers), new { id = user.Id }, user);
    }
}
