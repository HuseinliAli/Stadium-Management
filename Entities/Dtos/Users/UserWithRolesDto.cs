namespace Entities.Dtos.Users
{
    public class UserWithRolesDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<string> RoleNames { get; set; } = new List<string>();
    }
}
