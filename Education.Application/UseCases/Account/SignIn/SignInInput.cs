using Education.Application.UseCases.Account.Common;
using MediatR;

namespace Education.Application.UseCases.Account.SignIn;

public class SignInInput(string email, string password) : IRequest<AccessTokenOutputModel>
{
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
}