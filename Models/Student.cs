using System.Collections.Generic;

namespace Housing.Models
{
    public class Student : User
    {
        public List<Application> Applications { get; } = new();

        public Student(int id, string name, string email, string password)
            : base(id, name, email, password) { }

        public override string GetRole() => "Student";
    }
}
