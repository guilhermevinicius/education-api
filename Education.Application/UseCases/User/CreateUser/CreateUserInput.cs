using Education.Application.UseCases.User.Common;
using MediatR;

namespace Education.Application.UseCases.User.CreateUser;

public class CreateUserInput(string name, string email, string password) : IRequest<UserOutputModel>
{
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
}