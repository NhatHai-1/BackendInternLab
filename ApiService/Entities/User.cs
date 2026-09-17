namespace ApiService.Entities;

public enum UserRole
{
    Admin = 1,
    ProjectManager = 2,
    Developer = 3,
    
}

public class Uer
{
    public Guid Id {get; set; } = Guid.NewGuid();
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; } = UserRole.Developer;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}