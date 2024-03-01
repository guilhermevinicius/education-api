using Education.Application.UseCases.User.Common;
using MediatR;

namespace Education.Application.UseCases.User.CreateUser;

public class CreateUserInput : IRequest<UserOutputModel>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}