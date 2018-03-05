using System;

using System.Collections.Generic;
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

            //            SystemInfo.GetActiveProcessList();
            //            SystemInfo.GetInstalledSoftList();
            //            SystemInfo.GetServicesStatus();
            //            SystemInfo.GetOSInfo();
            //            SystemInfo.GetStorageInfo();
            //            SystemInfo.GetNetworkInterfacesInfo();
            //            SystemInfo.GetVideoControllerInfo();
            //            SystemInfo.GetCpuInfo();
//            SystemInfo.GetRamInfo();
            SystemInfo.GetHddInfo();







            //            try
            //            {
            //                InitialConfig();
            //            }
            //            catch (NotImplementedException e)
            //            {
            //                Console.WriteLine("The called method was not implemented");
            //                Console.WriteLine(e.Message);
            //            }









            Console.ReadLine();

        }

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
    }
}
