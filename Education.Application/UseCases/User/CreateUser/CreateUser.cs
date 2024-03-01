using Education.Application.Repositories;
using Education.Application.UseCases.User.Common;
using Education.Domain.SeedWork;
using Education.Domain.Services;

namespace Education.Application.UseCases.User.CreateUser;

public class CreateUser(
    IUserRepository userRepository,
    IUnitOfWork uow,
    IPasswordHash passwordHash) : ICreateUser
{
    public async Task<UserOutputModel> Handle(CreateUserInput request, CancellationToken cancellationToken)
    {
        if (userRepository.IsExistUserWithEmail(request.Email))
            throw new Exception("");

        var password = await passwordHash.Generate(request.Password);
        
        var user = new Domain.Entities.User(
            request.Name,
            request.Email,
            password
        );
        await userRepository.Save(user);
        await uow.CommitAsync(cancellationToken);
        return UserOutputModel.FromEntity(user);
    }
}