using System.Collections.Generic;
using Housing.Models;

namespace Housing.LogicLayers
{
    public class InMemoryDatabase
    {
        public List<Student> Students { get; set; } = new();
        public List<Admin> Admins { get; set; } = new();
        public List<Room> Rooms { get; set; } = new();
        public List<Application> Applications { get; set; } = new();

        public InMemoryDatabase()
        {
            var buildingA = new Building(1, "Alpha Hall", "North Campus");
            var buildingB = new Building(2, "Beta Hall", "South Campus");

            Rooms.Add(new Room(1, "101", RoomType.Single, RoomStatus.Available, buildingA));
            Rooms.Add(new Room(2, "102", RoomType.Shared, RoomStatus.Available, buildingA));
            Rooms.Add(new Room(3, "201", RoomType.Single, RoomStatus.Available, buildingB));
        }
    }
}
// This is an in-memory database used only while the program is running.
// It simulates a real database by storing data in lists (Students, Rooms, Applications).
// When the application closes, everything resets. Useful for testing logic without SQL/database setup.
