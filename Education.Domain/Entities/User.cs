using Education.Domain.SeedWork;

namespace Education.Domain.Entities;

public class User(string name, string email, string? password = null) : Entity
{
    public string Name { get; private set; } = name;
    public string Email { get; private set; } = email;
    public string? Password { get; private set; } = password;
    public bool IsActive { get; private set; } = true;
    
    public void Update(string name, string email)
    {
        Name = email;
        Email = email;
    }
}