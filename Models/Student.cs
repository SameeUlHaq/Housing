namespace Housing.Models
{
    public class Student : User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public List<Application> Applications { get; set; } = new();

        public Student(int id, string name, string username, string password)
            : base(id, name)
        {
            Username = username;
            Password = password;
        }

        public override string GetRole() => "Student";
    }
}
