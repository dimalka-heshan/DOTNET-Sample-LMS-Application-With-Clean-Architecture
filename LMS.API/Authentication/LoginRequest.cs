namespace LMS.API.Authentication
{
    public record LoginRequest(
      string Email,
      string Password
      );
}
