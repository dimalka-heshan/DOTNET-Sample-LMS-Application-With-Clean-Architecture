namespace LMS.API.Authentication
{
    public record RegisterRequest(
        string Name,
        string Email,
        string Password

        );
    
}
