using Education.Application.Repositories;
using Education.Application.UseCases.User.CreateUser;
using Education.Domain.SeedWork;
using Education.Domain.Services;
using Education.Infra.Data.Repositories;
using Education.Infra.Services;

namespace Education.Api.Configurations;

public static class UseCasesConfiguration
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddMediatR(opt => opt.RegisterServicesFromAssemblyContaining<CreateUser>());
        services.AddRepositories();
        services.AddServices();
        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IPasswordHash, PasswordHashService>();
        services.AddScoped<IGenerateJwt, GenerateJwtService>();
        return services;
    }
}