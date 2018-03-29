using System;

using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace AgentPrototype
{
    class Program
    {

        static void Main(string[] args)
        {

            //        ===================================================================
            //        Debug source data
            //        ===================================================================

            SystemInfo.GetInstalledSoftList();
            //Console.WriteLine("\n===\n");

            //SystemInfo.GetOSInfo();
            //List<NetworkInfo> netInfo = SystemInfo.GetNetworkInterfacesInfo();
            //List<StorageInfo> storInfo = SystemInfo.GetStorageInfo();

            //foreach (var info in storInfo)
            //{
            //    info.GetInfo();
            //}



            //        ===================================================================
            //        Work with sensor's data
            //        ===================================================================

            //            Create List of Base Class
            List<SysInfo> sysInfo = new List<SysInfo>();

            //            Create Lists of Child classed and fill it
            List<RamInfo> ramInfo = SystemInfo.GetRamInfo();
            List<CpuInfo> cpuInfo = SystemInfo.GetCpuInfo();
            List<VideoInfo> videoInfo = SystemInfo.GetVideoControllerInfo();
            List<HddInfo> hddInfo = SystemInfo.GetHddInfo();
            List<StorageInfo> storageInfo = SystemInfo.GetStorageInfo();
            List<NetworkInfo> networkInfo = SystemInfo.GetNetworkInterfacesInfo();
            List<OsInfo> osInfo = SystemInfo.GetOSInfo();
            List<ServicesStatus> servicesStatus = SystemInfo.GetServicesStatus();

            //            Add Child's Lists to Base List            
            sysInfo.AddRange(ramInfo);
            sysInfo.AddRange(cpuInfo);
            sysInfo.AddRange(videoInfo);
            sysInfo.AddRange(hddInfo);
            sysInfo.AddRange(networkInfo);
            sysInfo.AddRange(storageInfo);
            sysInfo.AddRange(osInfo);
            sysInfo.AddRange(servicesStatus);




            // Print all data from List to screen

            /*
            foreach (var ri in sysInfo)
            {
                ri.GetInfo();
            }
            Console.ReadLine();
            //*/

            //PreparationForSerialization();
            //Serializator.GetSystemVariables();



            Console.WriteLine("*** End of Main Section. Press Enter... ***");
            Console.ReadLine();
        }



        public static void PreparationForSerialization()
        {
            Console.WriteLine(Environment.SystemDirectory);
            //Environment.OSVersion.Version.Build.ToString();

        //public StringDictionary EnvironmentVariables { get; }


    }





        //        ===================================================================
        //        Old data
        //        ===================================================================
        /*
        static void InitialConfig()
        {
            string prgName = "Moo Agent";
            bool autoConfig = false;
            bool manualConfig = false;


            Console.WriteLine("***** Welcome to {0} *****", prgName);

            autoConfig = UsingXmlConfig();
            if (autoConfig)
            {
                Console.WriteLine("Program started using config file.\nHere is initial config:");

                return;
            }

            manualConfig = ManualConfig();
            if (manualConfig)
            {
                Console.WriteLine("Program started using manual configuration.\nHere is initial config:");
            }
            else
            {
                Console.WriteLine("Something wrong with configuration");
            }

        }

        static bool ManualConfig()
        {
            throw new NotImplementedException();
        }

        static bool UsingXmlConfig()
        {
            throw new NotImplementedException();
        }
        */
    }
}
