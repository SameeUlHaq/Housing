namespace Housing.Models
{
    public class Admin : User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public Admin(int id, string name, string username, string password)
            : base(id, name)
        {
            Username = username;
            Password = password;
        }

        public override string GetRole() => "Admin";
    }
}
