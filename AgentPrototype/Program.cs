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
            SystemInfo.DebugSystemInfo();
            List<SysInfo> sysInfo = SystemInfo.GetAllSystemInfo();
            SystemInfo.PrintAllSystemInfo(sysInfo);

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

    }
}
