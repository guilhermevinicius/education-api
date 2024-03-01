namespace Education.Application.UseCases.User.Common;

public class UserOutputModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public static UserOutputModel FromEntity(Domain.Entities.User user)
    {
        return new UserOutputModel
        {
            Id = user.Id,
            Email = user.Email,
            Name = user.Name
        };
    }
}