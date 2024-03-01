using Education.Domain.SeedWork;

namespace Education.Domain.Entities;

public class Course(string name, string description) : Entity
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public bool IsActive { get; private set; } = true;
}