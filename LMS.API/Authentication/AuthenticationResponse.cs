namespace LMS.API.Authentication
{
    public record AuthenticationResponse(
        Guid id,
      string Name,
      string Email,
      string Token
      );
}
