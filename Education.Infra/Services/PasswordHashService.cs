using Education.Domain.Services;

namespace Education.Infra.Services;

public class PasswordHashService : IPasswordHash
{
    public async Task<string> Generate(string password)
    {
        return "";
    }

    public async Task<bool> Compare(string hashPassword, string password)
    {
        return false;
    }
}