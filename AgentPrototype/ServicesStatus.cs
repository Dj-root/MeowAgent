using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    class ServicesStatus: SysInfo
    {
        public string Caption { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string PathName { get; set; }
        public bool Started { get; set; }




        public override void GetInfo()
        {
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("Win32_Service instance");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Caption: {0}", Caption);
            Console.WriteLine("Description: {0}", Description);
            Console.WriteLine("DisplayName: {0}", DisplayName);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("PathName: {0}", PathName);
            Console.WriteLine("Started: {0}", Started);
        }
    }
}
