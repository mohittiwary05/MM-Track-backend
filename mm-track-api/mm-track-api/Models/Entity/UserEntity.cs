namespace mm_track_api.Models.Entity
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PIN { get; set; }
        public bool IsActive { get; set; }
        public string OTP { get; set; }
        public DateTime CteatedDate { get; set; }
    }
}
