namespace Education.Domain.Services;

public interface IPasswordHash
{
    Task<string> Generate(string password);
    Task<bool> Compare(string hashPassword, string password);
}