namespace BurguerMania_API.Services;

using BurguerMania_API.DTOs;
using BurguerMania_API.Models;

public class UserService
{
    private readonly UserRepository _repository;

    public UserService(UserRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<UserDto> GetAllUsers()
    {
        return _repository.GetAll().Select(user => new UserDto
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email
        });
    }

    public UserDto CreateUser(CreateUserDto createUserDto)
    {
        var user = new User
        {
            Name = createUserDto.Name,
            Email = createUserDto.Email,
            Password = createUserDto.Password // Lembre-se de hashear a senha!
        };

        _repository.Add(user);

        return new UserDto
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email
        };
    }
}
