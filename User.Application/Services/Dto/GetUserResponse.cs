namespace User.Application.Services.Dto;

public class GetUserResponse
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string CustomerDocument { get; set; }
    public int PhoneNumber { get; set; }
}