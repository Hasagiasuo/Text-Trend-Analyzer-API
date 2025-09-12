namespace TTA.Domain.Models;

public class User
{
  public Guid Id { get; set; }
  public string Username { get; set; } = "";
  public string HashPassword { get; set; } = "";
  public Role Role { get; set; }
  public Guid RoleId { get; set; }
}