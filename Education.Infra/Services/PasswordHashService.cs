using Education.Domain.Services;
using BC = BCrypt.Net.BCrypt;

namespace Education.Infra.Services;

public class PasswordHashService : IPasswordHash
{
    public async Task<string> Generate(string password)
    {
        return BC.HashString(password, 12);
    }

    public async Task<bool> Compare(string hashPassword, string password)
    {
        return BC.Verify(password, hashPassword);
    }
}