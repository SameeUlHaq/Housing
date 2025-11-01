using System.Collections.Generic;
using System.Linq;
using Housing.Models;

namespace Housing.LogicLayers
{
    public class HousingService
    {
        private readonly InMemoryDatabase db = new();
        private int nextApplicationId = 1;

        public List<Room> GetAvailableRooms() =>
            db.Rooms.Where(r => r.IsAvailable()).ToList();


        public bool ApplyForRoom(int studentId, int roomId)
        {
            var student = db.Students.FirstOrDefault(s => s.Id == studentId);
            var room = db.Rooms.FirstOrDefault(r => r.Id == roomId);

            if (student == null || room == null || !room.IsAvailable())
                return false;

            var application = new Application(nextApplicationId++, student, room);
            room.Status = RoomStatus.Occupied;
            student.Applications.Add(application);
            db.Applications.Add(application);

            return true;
        }

        public List<Application> GetApplications(int studentId) =>
            db.Applications.Where(a => a.Student.Id == studentId).ToList();


        // ======================================================
        //  LOGIN + REGISTER
        // ======================================================
        public User Login(string username, string password)
        {
            var student = db.Students
                .FirstOrDefault(s => s.Username == username && s.Password == password);

            if (student != null)
                return student;

            var admin = db.Admins
                .FirstOrDefault(a => a.Username == username && a.Password == password);

            return admin; // can be null → login fail
        }


        public bool Register(string username, string password)
        {
            // don't allow duplicates
            if (db.Students.Any(s => s.Username == username) ||
                db.Admins.Any(a => a.Username == username))
                return false;

            // create new student
            db.Students.Add(
                new Student(
                    db.Students.Count + 1,
                    username,   // Name
                    username,   // Username
                    password
                )
            );

            return true;
        }
    }
}
