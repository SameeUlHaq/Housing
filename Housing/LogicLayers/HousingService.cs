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
    }
}
