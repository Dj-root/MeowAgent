using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    class InstalledSoft : SysInfo
    {
        public string Caption { get; set; }
        public string InstallDate { get; set; }

        public InstalledSoft()
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("Win32 Installed Software");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Caption: {0}; InstallDate: {1}", Caption, InstallDate);
        }
    }
}
