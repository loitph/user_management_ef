namespace user_management_ef.DTOs;

public class UserQueryParams
{
  public int PageIndex { get; set; } = 1;
  public int PageSize { get; set; } = 10;
  public string? SortBy { get; set; }
  public string? Search { get; set; }
  public bool Desc {get; set;} = false;
}