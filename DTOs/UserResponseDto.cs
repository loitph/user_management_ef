namespace user_management_ef.DTOs;

public class UserResponseDto
{
  public int Id {get; set;}
  public string Name {get; set;} = string.Empty;
  public string Email {get; set;} = string.Empty;
  public string? Description {get; set;}
  public int Age {get; set;}
  public DateTime CreatedAt {get; set;}
  public DateTime UpdatedAt {get; set;}
}