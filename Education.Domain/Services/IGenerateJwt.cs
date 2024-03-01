using Education.Domain.Entities;

namespace Education.Domain.Services;

public interface IGenerateJwt
{
    Task<string> Generate(User user);
}