using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    class SystemInfo
    {
        // Varibles

        // Constructors


        // Methods


        public static void GetStorageInfo()
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2", "Select * From Win32_Volume");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Win32_Volume instance");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Capacity: {0}", queryObj["Capacity"]);
                Console.WriteLine("Caption: {0}", queryObj["Caption"]);
                Console.WriteLine("DriveLetter: {0}", queryObj["DriveLetter"]);
                Console.WriteLine("DriveType: {0}", queryObj["DriveType"]);
                Console.WriteLine("FileSystem: {0}", queryObj["FileSystem"]);
                Console.WriteLine("FreeSpace: {0}", queryObj["FreeSpace"]);
            }
            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
        }

        public static void GetOSInfo()
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2", "Select * From Win32_OperatingSystem");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Win32_OperatingSystem instance");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("BuildNumber: {0}", queryObj["BuildNumber"]);
                Console.WriteLine("Caption: {0}", queryObj["Caption"]);
                Console.WriteLine("FreePhysicalMemory: {0}", queryObj["FreePhysicalMemory"]);
                Console.WriteLine("FreeVirtualMemory: {0}", queryObj["FreeVirtualMemory"]);
                Console.WriteLine("Name: {0}", queryObj["Name"]);
                Console.WriteLine("OSType: {0}", queryObj["OSType"]);
                Console.WriteLine("RegisteredUser: {0}", queryObj["RegisteredUser"]);
                Console.WriteLine("SerialNumber: {0}", queryObj["SerialNumber"]);
                Console.WriteLine("ServicePackMajorVersion: {0}", queryObj["ServicePackMajorVersion"]);
                Console.WriteLine("ServicePackMinorVersion: {0}", queryObj["ServicePackMinorVersion"]);
                Console.WriteLine("Status: {0}", queryObj["Status"]);
                Console.WriteLine("SystemDevice: {0}", queryObj["SystemDevice"]);
                Console.WriteLine("SystemDirectory: {0}", queryObj["SystemDirectory"]);
                Console.WriteLine("SystemDrive: {0}", queryObj["SystemDrive"]);
                Console.WriteLine("Version: {0}", queryObj["Version"]);
                Console.WriteLine("WindowsDirectory: {0}", queryObj["WindowsDirectory"]);
            }
            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
        }

        public static void GetServicesStatus()
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2", "Select * From Win32_Service");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("\n------------------------------------------------");
                Console.WriteLine("Win32_Service instance");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Caption: {0}", queryObj["Caption"]);
                Console.WriteLine("Description: {0}", queryObj["Description"]);
                Console.WriteLine("DisplayName: {0}", queryObj["DisplayName"]);
                Console.WriteLine("Name: {0}", queryObj["Name"]);
                Console.WriteLine("PathName: {0}", queryObj["PathName"]);
                Console.WriteLine("Started: {0}", queryObj["Started"]);
            }

            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
        }

        public static void GetInstalledSoftList()
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2", "Select * From Win32_Product");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("<soft> Caption: {0}; InstallDate: {1}</soft>", queryObj["Caption"], queryObj["InstallDate"]);
            }

            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
        }

        public static void GetActiveProcessList()
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2", "Select Name, CommandLine From Win32_Process");

            foreach (ManagementBaseObject instance in searcher.Get())
            {
                Console.WriteLine("{0}", instance["Name"]);
            }

            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
        }
    }
}
