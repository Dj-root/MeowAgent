using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    class CpuInfo : SysInfo
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public int NumberOfCores { get; set; }
        public int NumberOfLogicalProcessors { get; set; }
        public int ThreadCount { get; set; }
        public int CurrentClockSpeed { get; set; }
        public string ProcessorId { get; set; }


        public CpuInfo(string manufacturer, string name, int numberOfCores, int numberOfLogicalProcessors, int threadCount, int currentClockSpeed, string processorId)
        {
            Manufacturer = manufacturer;
            Name = name;
            NumberOfCores = numberOfCores;
            NumberOfLogicalProcessors = numberOfLogicalProcessors;
            ThreadCount = threadCount;
            CurrentClockSpeed = currentClockSpeed;
            ProcessorId = processorId;
        }

        public CpuInfo()
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine("------------- Win32_Processor instance ---------------");
            Console.WriteLine("Manufacturer: {0}", Manufacturer);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("NumberOfCores: {0}", NumberOfCores);
            Console.WriteLine("NumberOfLogicalProcessors: {0}", NumberOfLogicalProcessors);
            Console.WriteLine("ThreadCount: {0}", ThreadCount);
            Console.WriteLine("CurrentClockSpeed: {0}", CurrentClockSpeed);
            Console.WriteLine("ProcessorId: {0}", ProcessorId);
        }

        public override string ToString()
        {
            return string.Format("Manufacturer: {0} \nName: {1} \nNumberOfCores: {2} \nNumberOfLogicalProcessors: {3} \n" +
                                 "ThreadCount: {4} \nCurrentClockSpeed: {5} \nProcessorId: {6}",
                Manufacturer, Name, NumberOfCores, NumberOfLogicalProcessors, ThreadCount, CurrentClockSpeed, ProcessorId);
        }
    }
}


//Console.WriteLine("------------- Win32_Processor instance ---------------");
//Console.WriteLine("Manufacturer: {0}", queryObj["Manufacturer"]);
//Console.WriteLine("Name: {0}", queryObj["Name"]);
//Console.WriteLine("NumberOfCores: {0}", queryObj["NumberOfCores"]);
//Console.WriteLine("NumberOfLogicalProcessors: {0}", queryObj["NumberOfLogicalProcessors"]);
//Console.WriteLine("ThreadCount: {0}", queryObj["ThreadCount"]);
//Console.WriteLine("CurrentClockSpeed: {0}", queryObj["CurrentClockSpeed"]);
//Console.WriteLine("ProcessorId: {0}", queryObj["ProcessorId"]);