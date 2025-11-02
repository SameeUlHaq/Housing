using System;
using System.Windows.Forms;
using Housing.LogicLayers;

namespace GUIWIN
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var service = new HousingService();

            Application.Run(new LoginForm(service));
        }
    }
}
