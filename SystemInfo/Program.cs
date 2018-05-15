using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Drawing;

namespace SystemInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OS: " + Environment.OSVersion);
            Console.WriteLine("64 bit: " + Environment.Is64BitOperatingSystem);
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in mos.Get())
            {
                Console.WriteLine("Procesor: " + mo["Name"]);
            }
            Console.WriteLine("Processor count (Cores): " + Environment.ProcessorCount);

            Console.WriteLine("Machine name: " + Environment.MachineName);
            Console.WriteLine("Computer name: " + SystemInformation.ComputerName);
            Console.WriteLine("User name: " + SystemInformation.UserName);
            Console.WriteLine("User domain name: " + SystemInformation.UserDomainName);

            Console.WriteLine("Mouse wheel present: " + SystemInformation.MouseWheelPresent);
            Console.WriteLine("Mouse buttons: " + SystemInformation.MouseButtons);

            Console.WriteLine("Network: " + SystemInformation.Network);

            Console.WriteLine("Working area:  Width: " + SystemInformation.WorkingArea.Width + " Height: " + SystemInformation.WorkingArea.Height);
            Console.WriteLine("Monitor count: " + SystemInformation.MonitorCount);
            Console.WriteLine("Primary monitor size: " + SystemInformation.PrimaryMonitorSize.Width + "x" + SystemInformation.PrimaryMonitorSize.Height);
            Console.WriteLine();
            Console.WriteLine("--------- Monitors ---------");
            foreach (var screen in Screen.AllScreens)
            {
                decimal mpixel = (decimal)(screen.Bounds.Width * screen.Bounds.Height) / 1000000;
                Console.WriteLine("Is primary Screen: " + screen.Primary);
                Console.WriteLine("Device Name: " + screen.DeviceName);
                Console.WriteLine("Resolution: " + screen.Bounds.Width + "x" + screen.Bounds.Height + " " + mpixel + " Megapixels");
                Console.WriteLine("Bits per pixel: " + screen.BitsPerPixel);
                Console.WriteLine("----------------------------");
            }

            Console.ReadKey();
        }
    }
}
