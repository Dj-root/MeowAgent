using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    class OsInfo : SysInfo
    {
        public int BuildNumber { get; set; }
        public string Caption { get; set; }
        public double FreePhysicalMemory { get; set; }
        public double FreeVirtualMemory { get; set; }
        public string Name { get; set; }
        public int OSType { get; set; }
        public string RegisteredUser { get; set; }
        public string SerialNumber { get; set; }
        public int ServicePackMajorVersion { get; set; }
        public int ServicePackMinorVersion { get; set; }
        public string Status { get; set; }
        public string SystemDevice { get; set; }
        public string SystemDirectory { get; set; }
        public string SystemDrive { get; set; }
        public string Version { get; set; }
        public string WindowsDirectory { get; set; }

        public OsInfo()
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("Win32_OperatingSystem instance");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("BuildNumber: {0}", BuildNumber);
            Console.WriteLine("Caption: {0}", Caption);
            Console.WriteLine("FreePhysicalMemory: {0} MB", FreePhysicalMemory);
            Console.WriteLine("FreeVirtualMemory: {0} MB", FreeVirtualMemory);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("OSType: {0}", OSType);
            Console.WriteLine("RegisteredUser: {0}", RegisteredUser);
            Console.WriteLine("SerialNumber: {0}", SerialNumber);
            Console.WriteLine("ServicePackMajorVersion: {0}", ServicePackMajorVersion);
            Console.WriteLine("ServicePackMinorVersion: {0}", ServicePackMinorVersion);
            Console.WriteLine("Status: {0}", Status);
            Console.WriteLine("SystemDevice: {0}", SystemDevice);
            Console.WriteLine("SystemDirectory: {0}", SystemDirectory);
            Console.WriteLine("SystemDrive: {0}", SystemDrive);
            Console.WriteLine("Version: {0}", Version);
            Console.WriteLine("WindowsDirectory: {0}", WindowsDirectory);

        }

    }
}



