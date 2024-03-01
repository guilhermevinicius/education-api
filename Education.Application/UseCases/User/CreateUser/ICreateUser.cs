using Education.Application.UseCases.User.Common;
using MediatR;

namespace Education.Application.UseCases.User.CreateUser;

public interface ICreateUser : IRequestHandler<CreateUserInput, UserOutputModel>
{
}