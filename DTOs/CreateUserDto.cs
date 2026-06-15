
using System.ComponentModel.DataAnnotations;

namespace user_management_ef.DTOs;

public class CreateUserDto
{
  [Required(ErrorMessage = "Name là bắt buộc")]
  [MaxLength(100, ErrorMessage = "Name tối đa 100 ký tự")]
  public string Name {get; set;} = string.Empty;

  [Required(ErrorMessage = "Email là bắt buộc")]
  [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
  [MaxLength(150, ErrorMessage = "Email tối đa 150 ký tự")]
  public string Email {get; set;} = string.Empty;

  [MaxLength(500, ErrorMessage = "Miêu tả tối đa 500 ký tự")]
  public string? Description {get; set;}

  [Range(1, 120, ErrorMessage = "Tuổi phải nằm trong khoảng 1 đến 120")]
  public int Age {get; set;}
}