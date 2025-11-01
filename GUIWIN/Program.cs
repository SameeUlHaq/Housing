using System;
using System.Windows.Forms;
using Housing.LogicLayers;
using Housing.Models;

namespace GUIWIN
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // skapa service
            var service = new HousingService();

            // skapa en dummy student (tills vi fixar login)
            var dummyStudent = new Student(1, "Samee Ebadul", "test", "test123");


            // starta mainform direkt
            System.Windows.Forms.Application.Run(new MainForm(service, dummyStudent));

        }
    }
}
