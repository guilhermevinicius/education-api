using Education.Application.UseCases.Account.Common;
using MediatR;

namespace Education.Application.UseCases.Account.SignIn;

public class SignInInput : IRequest<AccessTokenOutputModel>
{
    public string Email { get; set; }
    public string Password { get; set; }
}