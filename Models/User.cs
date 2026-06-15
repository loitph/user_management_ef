namespace user_management_ef.Models;

public class User
{
  // auto increament
  public int Id {get; set;}

  public string Name {get; set;} = string.Empty;
  public string Email {get; set;} = string.Empty;

  public string? Description {get; set;}

  public int Age {get; set;}

  public DateTime CreateAt {get; set;}
  public DateTime UpdateAt {get; set;}

  // soft delete
  public bool Deleted {get; set;}
}