namespace Else_ISD.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }

        public ICollection<DbDump> DbDumps { get; set; } // Collection of DbDumps created by the user
    }
}
