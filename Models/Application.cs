using System;

namespace Housing.Models
{
    public class Application
    {
        public int Id { get; }
        public Student Student { get; }
        public Room Room { get; }
        public DateTime Date { get; }
        public ApplicationStatus Status { get; set; }

        public Application(int id, Student student, Room room)
        {
            Id = id;
            Student = student;
            Room = room;
            Date = DateTime.Now;
            Status = ApplicationStatus.Pending;
        }

        public override string ToString() =>
            $"Application {Id}: {Student.Name} -> {Room.Number} ({Status})";
    }
}
