using Microsoft.EntityFrameworkCore;

namespace TodoKingServer.Models
{
    
    public class TKUser
    {
        
        public Guid Id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public IEnumerable<TKTask> Tasks { get; set; }
    }
}
