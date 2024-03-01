using Education.Application.UseCases.Account.Common;
using MediatR;

namespace Education.Application.UseCases.Account.SignIn;

public interface ISignIn : IRequestHandler<SignInInput, AccessTokenOutputModel>
{
}