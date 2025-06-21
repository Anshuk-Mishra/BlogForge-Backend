namespace Application.Dto
{
    public class UserRegistrationDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PassHash { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string PhraseHash { get; set; } = string.Empty;
        public DateTime Dob { get; set; }
    }

    public class UserLoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string PassHash { get; set; } = string.Empty;
    }

    public class UserDto
    {
        public int Uid { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Dob { get; set; }
    }
}