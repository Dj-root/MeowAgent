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

        //        ===================================================================
        //        Work with sensor's data
        //        ===================================================================









        //        ===================================================================
        //        Get information from system sensors
        //        ===================================================================

        public static List<HddInfo> GetHddInfo()
        {
            List<HddInfo> hddInfo = new List<HddInfo>();

            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_DiskDrive");

            //            Console.WriteLine("--------- Win32_DiskDrive instance ---------------");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                HddInfo hi = new HddInfo();

                hi.Caption = (string)queryObj["Caption"];
                hi.DeviceID = (string)queryObj["DeviceID"];
                hi.InterfaceType = (string)queryObj["InterfaceType"];
                hi.Manufacturer = (string)queryObj["Manufacturer"];
                hi.Model = (string)queryObj["Model"];
                hi.Size = Math.Round(System.Convert.ToDouble(queryObj["Size"]) / 1024 / 1024 / 1024, 2);
                hi.SerialNumber = (string)queryObj["SerialNumber"];

                hddInfo.Add(hi);
                //                Console.WriteLine("DeviceID: {0}; InterfaceType: {1}; Manufacturer: {2}; Model: {3}; SerialNumber: {4}; Size: {5} Gb", queryObj["DeviceID"],
                //                                queryObj["InterfaceType"],
                //                                queryObj["Manufacturer"],
                //                                queryObj["Model"],
                //                                queryObj["SerialNumber"],
                //                                Math.Round(System.Convert.ToDouble(queryObj["Size"]) / 1024 / 1024 / 1024, 2));
                //                Console.WriteLine("-----");
            }

            //            foreach (ManagementObject queryObj in searcher.Get())
            //            {
            //                queryObj.ToString();
            //            }
            //            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
            return hddInfo;
        }

        public static List<RamInfo> GetRamInfo()
        {
            List<RamInfo> ramList = new List<RamInfo>();

            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PhysicalMemory");

            //            Console.WriteLine("------------- Win32_PhysicalMemory instance --------");
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

        public static List<CpuInfo> GetCpuInfo()
        {
            List<CpuInfo> cpuInfo = new List<CpuInfo>();

            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                CpuInfo si = new CpuInfo();
                si.Manufacturer = (string)queryObj["Manufacturer"].ToString();
                si.Name = (string)queryObj["Name"].ToString();
                si.NumberOfCores = Int32.Parse(queryObj["NumberOfCores"].ToString());
                si.NumberOfLogicalProcessors = Int32.Parse(queryObj["NumberOfLogicalProcessors"].ToString());
                si.ThreadCount = Int32.Parse(queryObj["ThreadCount"].ToString());
                si.CurrentClockSpeed = Int32.Parse(queryObj["CurrentClockSpeed"].ToString());
                si.ProcessorId = queryObj["ProcessorId"].ToString();

                cpuInfo.Add(si);

                //                Console.WriteLine("------------- Win32_Processor instance ---------------");
                //                Console.WriteLine("Manufacturer: {0}", queryObj["Manufacturer"]);
                //                Console.WriteLine("Name: {0}", queryObj["Name"]);
                //                Console.WriteLine("NumberOfCores: {0}", queryObj["NumberOfCores"]);
                //                Console.WriteLine("NumberOfLogicalProcessors: {0}", queryObj["NumberOfLogicalProcessors"]);
                //                Console.WriteLine("ThreadCount: {0}", queryObj["ThreadCount"]);
                //                Console.WriteLine("CurrentClockSpeed: {0}", queryObj["CurrentClockSpeed"]);
                //                Console.WriteLine("ProcessorId: {0}", queryObj["ProcessorId"]);
            }

            //            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
            return cpuInfo;
        }

        public static List<VideoInfo> GetVideoControllerInfo()
        {
            List<VideoInfo> videoInfo = new List<VideoInfo>();


            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_VideoController");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                VideoInfo vi = new VideoInfo();
                vi.AdapterRAM = Math.Round(System.Convert.ToDouble(queryObj["AdapterRAM"]) / 1024 / 1024 / 1024, 2);
                vi.Caption = (string)queryObj["Caption"];
                vi.Description = (string)queryObj["Description"];
                vi.VideoProcessor = (string)queryObj["VideoProcessor"];

                videoInfo.Add(vi);
                //                Console.WriteLine("----------- Win32_VideoController instance -----------");
                //                Console.WriteLine("AdapterRAM: {0} GB", Math.Round(System.Convert.ToDouble(queryObj["AdapterRAM"]) / 1024 / 1024 / 1024, 2));
                //                Console.WriteLine("Caption: {0}", queryObj["Caption"]);
                //                Console.WriteLine("Description: {0}", queryObj["Description"]);
                //                Console.WriteLine("VideoProcessor: {0}", queryObj["VideoProcessor"]);
            }

            return videoInfo;
            //            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);
        }

        public static List<NetworkInfo> GetNetworkInterfacesInfo()
        {
            List<NetworkInfo> networkInfo = new List<NetworkInfo>();


            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                                        "SELECT * FROM Win32_NetworkAdapterConfiguration");


            foreach (ManagementObject queryObj in searcher.Get())
            {
                NetworkInfo ni = new NetworkInfo();

                //Console.WriteLine("--------- Win32_NetworkAdapterConfiguration instance --------------");

                ni.Caption = (string)queryObj["Caption"].ToString();
                //Console.WriteLine("Caption: {0}", queryObj["Caption"]);

                if (queryObj["DefaultIPGateway"] == null)
                {
                    //Console.WriteLine("DefaultIPGateway: {0}", queryObj["DefaultIPGateway"]);
                }
                else
                {

                    String[] arrDefaultIPGateway = (String[])(queryObj["DefaultIPGateway"]);
                    ni.arrDefaultIPGateway.AddRange(arrDefaultIPGateway.ToList());
                    //foreach (String arrValue in arrDefaultIPGateway)
                    //{
                    //    Console.WriteLine("DefaultIPGateway: {0}", arrValue);
                    //}
                }

                if (queryObj["DNSServerSearchOrder"] == null)
                {
                    //Console.WriteLine("DNSServerSearchOrder: {0}", queryObj["DNSServerSearchOrder"]);
                }
                else
                {
                    String[] arrDNSServerSearchOrder = (String[])(queryObj["DNSServerSearchOrder"]);
                    ni.arrDNSServerSearchOrder = (arrDNSServerSearchOrder.ToList());

                    //foreach (String arrValue in arrDNSServerSearchOrder)
                    //{
                    //    Console.WriteLine("DNSServerSearchOrder: {0}", arrValue);
                    //}
                }

                if (queryObj["IPAddress"] == null)
                {
                    //Console.WriteLine("IPAddress: {0}", queryObj["IPAddress"]);
                }
                else
                {
                    String[] arrIPAddress = (String[])(queryObj["IPAddress"]);
                    ni.arrIPAddress = arrIPAddress.ToList();

                    //foreach (String arrValue in arrIPAddress)
                    //{
                    //    Console.WriteLine("IPAddress: {0}", arrValue);
                    //}
                }

                if (queryObj["IPSubnet"] == null)
                {
                    //Console.WriteLine("IPSubnet: {0}", queryObj["IPSubnet"]);
                }
                else
                {
                    String[] arrIPSubnet = (String[])(queryObj["IPSubnet"]);
                    ni.arrIPSubnet = arrIPSubnet.ToList();

                    //foreach (String arrValue in arrIPSubnet)
                    //{
                    //    Console.WriteLine("IPSubnet: {0}", arrValue);
                    //}
                }

                ni.MACAddress = (string)queryObj["MACAddress"];
                ni.ServiceName = (string)queryObj["ServiceName"];
                //Console.WriteLine("MACAddress: {0}", queryObj["MACAddress"]);
                //Console.WriteLine("ServiceName: {0}", queryObj["ServiceName"]);

                networkInfo.Add(ni);
            }


            /* Backup source data

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
             *
             */
            Console.WriteLine("\nCollection finished at {0}", System.DateTime.Now);

            return networkInfo;
        }

        public static List<StorageInfo> GetStorageInfo()
        {
            List<StorageInfo> storageInfo = new List<StorageInfo>();


            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2", "Select * From Win32_Volume");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                StorageInfo si = new StorageInfo();

                //Console.WriteLine("-----------------------------------");
                //Console.WriteLine("Win32_Volume instance");
                //Console.WriteLine("-----------------------------------");
                si.Capacity = Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024, 2);
                si.Caption = queryObj["Caption"].ToString();

                //si.DriveLetter = queryObj["DriveLetter"].ToString() ?

                if (queryObj["DriveLetter"] == null)
                {
                    si.DriveLetter = "";
                }
                else
                {
                    si.DriveLetter = queryObj["DriveLetter"].ToString();
                }

                si.DriveType = queryObj["DriveType"].ToString();
                si.FileSystem = queryObj["FileSystem"].ToString();
                si.FreeSpace = Math.Round(System.Convert.ToDouble(queryObj["FreeSpace"]) / 1024 / 1024 / 1024, 2);

                storageInfo.Add(si);
            }

            return storageInfo;
        }

        public static List<OsInfo> GetOSInfo()
        {
            List<OsInfo> osInfo = new List<OsInfo>();

            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2", "Select * From Win32_OperatingSystem");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                OsInfo oi = new OsInfo();

                oi.BuildNumber = Int32.Parse(queryObj["BuildNumber"].ToString());
                oi.Caption = (string)queryObj["Caption"];
                oi.FreePhysicalMemory = Math.Round(System.Convert.ToDouble(queryObj["FreePhysicalMemory"]) / 1024 / 1024, 2);
                oi.FreeVirtualMemory = Math.Round(System.Convert.ToDouble(queryObj["FreeVirtualMemory"]) / 1024 / 1024, 2);
                oi.Name = (string)queryObj["Name"];
                oi.OSType = Int32.Parse(queryObj["OSType"].ToString());
                oi.RegisteredUser = (string)queryObj["RegisteredUser"];
                oi.SerialNumber = (string)queryObj["SerialNumber"];
                oi.ServicePackMajorVersion = Int32.Parse(queryObj["ServicePackMajorVersion"].ToString());
                oi.ServicePackMinorVersion = Int32.Parse(queryObj["ServicePackMinorVersion"].ToString());
                oi.Status = (string)queryObj["Status"];
                oi.SystemDevice = (string)queryObj["SystemDevice"];
                oi.SystemDirectory = (string)queryObj["SystemDirectory"];
                oi.SystemDrive = (string)queryObj["SystemDrive"];
                oi.Version = (string)queryObj["Version"];
                oi.WindowsDirectory = (string)queryObj["WindowsDirectory"];


                osInfo.Add(oi);
            }

            return osInfo;

        }

        public static List<ServicesStatus> GetServicesStatus()
        {
            List<ServicesStatus> servicesStatus = new List<ServicesStatus>();


            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\CIMV2", "Select * From Win32_Service");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                ServicesStatus si = new ServicesStatus();

                si.Caption = (string)queryObj["Caption"];
                si.Description = (string)queryObj["Description"];
                si.DisplayName = (string)queryObj["DisplayName"];
                si.Name = (string)queryObj["Name"];
                si.PathName = (string)queryObj["PathName"];
                si.Started = bool.Parse(queryObj["Started"].ToString());

                servicesStatus.Add(si);
            }

            return servicesStatus;
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
