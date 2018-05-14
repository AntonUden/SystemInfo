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
            Console.WriteLine("Processor count: " + Environment.ProcessorCount);

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

            Console.ReadKey();
        }
    }
}
