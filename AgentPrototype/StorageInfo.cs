using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    class StorageInfo : SysInfo
    {
        public double Capacity { get; set; }    
        public string Caption { get; set; }
        public string DriveLetter { get; set; }
        public string DriveType { get; set; }
        public string FileSystem { get; set; }
        public double FreeSpace { get; set; }

        public StorageInfo()
        {
        }


        public override void GetInfo()
        {
            Console.WriteLine("\n--------- Win32_Volume instance ---------");
            Console.WriteLine("Capacity: {0} GB", Capacity);
            Console.WriteLine("Caption: {0}", Caption);
            Console.WriteLine("DriveLetter: {0}", DriveLetter);
            Console.WriteLine("DriveType: {0}", DriveType);
            Console.WriteLine("FileSystem: {0}", FileSystem);
            Console.WriteLine("FreeSpace: {0} GB", FreeSpace);

            //Console.WriteLine("BankLabel = {0}, Capacity = {1} Speed = {2}", BankLabel, Capacity, Speed);
        }
    }
}


/*
 Console.WriteLine("Capacity: {0}", queryObj["Capacity"]);
            Console.WriteLine("Caption: {0}", queryObj["Caption"]);
            Console.WriteLine("DriveLetter: {0}", queryObj["DriveLetter"]);
            Console.WriteLine("DriveType: {0}", queryObj["DriveType"]);
            Console.WriteLine("FileSystem: {0}", queryObj["FileSystem"]);
            Console.WriteLine("FreeSpace: {0}", queryObj["FreeSpace"]);
        }
 */
