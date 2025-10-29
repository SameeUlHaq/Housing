using System;
using Housing.LogicLayers;

namespace Housing.GUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new HousingService();

            Console.WriteLine("=== AVAILABLE ROOMS ===");
            foreach (var room in service.GetAvailableRooms())
                Console.WriteLine(room);

            Console.WriteLine("\nStudent 1 applies for room 1...");
            bool success = service.ApplyForRoom(1, 1);
            Console.WriteLine(success ? "Application submitted!" : "Failed to apply.");

            Console.WriteLine("\n=== ROOMS AFTER APPLICATION ===");
            foreach (var room in service.GetAvailableRooms())
                Console.WriteLine(room);

            Console.WriteLine("\n=== APPLICATIONS FOR STUDENT 1 ===");
            foreach (var app in service.GetApplications(1))
                Console.WriteLine(app);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
