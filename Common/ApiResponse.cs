namespace user_management_ef.Common;

public class ApiResponse<T>
{
  public int StatusCode {get; set;}
  public string Message {get; set;} = string.Empty;
  public T? Content {get; set;}
  public DateTime DateTime {get; set;}

  public ApiResponse() {}

  public ApiResponse(int statusCode, string message, T? content)
  {
    StatusCode = statusCode;
    Message = message;
    Content = content;
    DateTime = DateTime.UtcNow;
  }
}