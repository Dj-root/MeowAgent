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


        public static void GetHddInfo()
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_DiskDrive");

            Console.WriteLine("--------- Win32_DiskDrive instance ---------------");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("DeviceID: {0}; InterfaceType: {1}; Manufacturer: {2}; Model: {3}; SerialNumber: {4}; Size: {5} Gb", queryObj["DeviceID"],
                    queryObj["InterfaceType"],
                    queryObj["Manufacturer"],
                    queryObj["Model"],
                    queryObj["SerialNumber"],
                    Math.Round(System.Convert.ToDouble(queryObj["Size"]) / 1024 / 1024 / 1024, 2));
                Console.WriteLine("-----");
            }
            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
        }

        public static List<RamInfo> GetRamInfo()
        {
            List<RamInfo> ramList = new List<RamInfo>();

            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PhysicalMemory");

            Console.WriteLine("------------- Win32_PhysicalMemory instance --------");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                //Console.WriteLine("BankLabel: {0} ; Capacity: {1} Gb; Speed: {2} ", queryObj["BankLabel"],
                //    Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024, 2),
                //    queryObj["Speed"]);

                RamInfo r = new RamInfo();

                r.BankLabel = (string)queryObj["BankLabel"].ToString();
                r.Capacity = Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024, 2);
                r.Speed = Int32.Parse(queryObj["Speed"].ToString());

                ramList.Add(r);

                //ramList.Add(new RamInfo {Int32.TryParse(queryObj["BankLabel"])});
            }

            return ramList;
            //Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
        }

        public static void GetCpuInfo()
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("------------- Win32_Processor instance ---------------");
                Console.WriteLine("Name: {0}", queryObj["Name"]);
                Console.WriteLine("NumberOfCores: {0}", queryObj["NumberOfCores"]);
                Console.WriteLine("ProcessorId: {0}", queryObj["ProcessorId"]);
            }

            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
        }

        public static void GetVideoControllerInfo()
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_VideoController");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("----------- Win32_VideoController instance -----------");
                Console.WriteLine("AdapterRAM: {0}", queryObj["AdapterRAM"]);
                Console.WriteLine("Caption: {0}", queryObj["Caption"]);
                Console.WriteLine("Description: {0}", queryObj["Description"]);
                Console.WriteLine("VideoProcessor: {0}", queryObj["VideoProcessor"]);
            }

            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
        }

        public static void GetNetworkInterfacesInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                                        "SELECT * FROM Win32_NetworkAdapterConfiguration");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Console.WriteLine("--------- Win32_NetworkAdapterConfiguration instance --------------");
                Console.WriteLine("Caption: {0}", queryObj["Caption"]);

                if (queryObj["DefaultIPGateway"] == null)
                    Console.WriteLine("DefaultIPGateway: {0}", queryObj["DefaultIPGateway"]);
                else
                {
                    String[] arrDefaultIPGateway = (String[])(queryObj["DefaultIPGateway"]);
                    foreach (String arrValue in arrDefaultIPGateway)
                    {
                        Console.WriteLine("DefaultIPGateway: {0}", arrValue);
                    }
                }

                if (queryObj["DNSServerSearchOrder"] == null)
                    Console.WriteLine("DNSServerSearchOrder: {0}", queryObj["DNSServerSearchOrder"]);
                else
                {
                    String[] arrDNSServerSearchOrder = (String[])(queryObj["DNSServerSearchOrder"]);
                    foreach (String arrValue in arrDNSServerSearchOrder)
                    {
                        Console.WriteLine("DNSServerSearchOrder: {0}", arrValue);
                    }
                }

                if (queryObj["IPAddress"] == null)
                    Console.WriteLine("IPAddress: {0}", queryObj["IPAddress"]);
                else
                {
                    String[] arrIPAddress = (String[])(queryObj["IPAddress"]);
                    foreach (String arrValue in arrIPAddress)
                    {
                        Console.WriteLine("IPAddress: {0}", arrValue);
                    }
                }

                if (queryObj["IPSubnet"] == null)
                    Console.WriteLine("IPSubnet: {0}", queryObj["IPSubnet"]);
                else
                {
                    String[] arrIPSubnet = (String[])(queryObj["IPSubnet"]);
                    foreach (String arrValue in arrIPSubnet)
                    {
                        Console.WriteLine("IPSubnet: {0}", arrValue);
                    }
                }
                Console.WriteLine("MACAddress: {0}", queryObj["MACAddress"]);
                Console.WriteLine("ServiceName: {0}", queryObj["ServiceName"]);
            }
            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
        }

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
