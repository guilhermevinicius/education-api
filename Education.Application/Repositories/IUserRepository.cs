using Education.Domain.Entities;

namespace Education.Application.Repositories;

public interface IUserRepository
{
    bool IsExistUserWithEmail(string email);
    User? ByEmail(string email);
    User? ById(Guid id);
    Task<User> Save(User user);
    User Update(User user);
}