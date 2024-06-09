namespace TodoKingServer.Models
{
    public class TKTask
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime Created { get; set; }
        public string Status { get; set; } = String.Empty;
        public Guid TKUserId { get; set; }
        public TKUser TKUser { get; set; }

    }
}
