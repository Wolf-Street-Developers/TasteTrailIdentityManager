namespace TasteTrailIdentityManager.Infrastructure.Users.Dtos;

public class UpdateUserDto
{
    public required string Name { get; set; }
    public required string Email { get; set; }
}