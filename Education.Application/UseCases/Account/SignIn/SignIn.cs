using Education.Application.Repositories;
using Education.Application.UseCases.Account.Common;
using Education.Domain.Services;

namespace Education.Application.UseCases.Account.SignIn;

public class SignIn(
    IUserRepository userRepository,
    IPasswordHash passwordHash,
    IGenerateJwt generateJwt) : ISignIn
{
    public async Task<AccessTokenOutputModel> Handle(SignInInput request, CancellationToken cancellationToken)
    {
        var user = userRepository.ByEmail(request.Email);
        if (user == null)
            throw new Exception("E-mail/Passwird invalid");

        var isValidPassword = await passwordHash.Compare(user.Password, request.Password);
        if(!isValidPassword)
            throw new Exception("E-mail/Passwird invalid");

        var accessToken = await generateJwt.Generate(user);

        return new AccessTokenOutputModel (accessToken);
    }
}