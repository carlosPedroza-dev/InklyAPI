

namespace Inkly.Domain
{
  
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = String.Empty;
        public string PasswordHash { get; set; } = String.Empty;
        public string UserName { get; set; } = String.Empty;
        public bool EmailVerified { get; set; } = false;
        public ICollection<Document> Documents { get; set; } = new List<Document>();
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
        public UserUsage? Usage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
