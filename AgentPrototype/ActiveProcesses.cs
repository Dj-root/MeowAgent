using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    class ActiveProcesses : SysInfo
    {
        public string Name { get; set; }

        public ActiveProcesses()
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine("{0}", Name);
        }
    }
}
