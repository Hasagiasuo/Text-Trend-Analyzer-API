using System.Text.Json.Serialization;

namespace TTA.Domain.Models;

public class Role
{
  public Guid Id { get; set; }
  public string Title { get; set; } = "";
  [JsonIgnore]
  public List<User> Users { get; set; } = [];
}