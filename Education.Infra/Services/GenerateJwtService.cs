using Education.Domain.Entities;
using Education.Domain.Services;

namespace Education.Infra.Services;

public class GenerateJwtService : IGenerateJwt
{
    public async Task<string> Generate(User user)
    {
        return "";
    }
}