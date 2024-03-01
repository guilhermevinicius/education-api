using Education.Application.Repositories;
using Education.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Education.Infra.Data.Repositories;

public class UserRepository(DataContext context) : IUserRepository
{
    
    public bool IsExistUserWithEmail(string email)
    {
        return context.Users.AsNoTracking()
            .Any(x => x.Email == email);
    }

    public User? ByEmail(string email)
    {
        return context.Users.AsNoTracking()
            .FirstOrDefault(x => x.Email == email);
    }

    public User? ById(Guid id)
    {
        return context.Users.AsNoTracking()
            .FirstOrDefault(x => x.Id == id);
    }

    public async Task<User> Save(User user)
    {
        await context.Users.AddAsync(user);
        return user;
    }

    public User Update(User user)
    {
        return context.Users.Update(user).Entity;
    }
}