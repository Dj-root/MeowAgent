using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    class NetworkInfo : SysInfo
    {
        public string Caption { get; set; }
        public List<string> arrDefaultIPGateway = new List<string>();
        public List<string> arrDNSServerSearchOrder = new List<string>();
        public List<string> arrIPAddress = new List<string>();
        public List<string> arrIPSubnet = new List<string>();
        public string MACAddress { get; set; }
        public string ServiceName { get; set; }

        public List<string> test = new List<string>();

        public NetworkInfo()
        {
        }


        public override void GetInfo()
        {

            //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            //Console.WriteLine("Diagnistic info");
            //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("\n--------- Win32_NetworkAdapterConfiguration instance --------------");
            Console.WriteLine("Caption: {0}", Caption);

            if (arrDefaultIPGateway.Count == 0)
            {
                Console.WriteLine("DefaultIPGateway: ");
            }
            else
            {
                foreach (String arrValue in arrDefaultIPGateway)
                {
                    Console.WriteLine("DefaultIPGateway: {0}", arrValue);
                }
            }

            if (arrDNSServerSearchOrder.Count == 0)
            {
                Console.WriteLine("DNSServerSearchOrder: ");
            }
            else
            {
                foreach (String arrValue in arrDNSServerSearchOrder)
                {
                    Console.WriteLine("DNSServerSearchOrder: {0}", arrValue);
                }
            }

            if (arrIPAddress.Count == 0)
            {
                Console.WriteLine("IPAddress: ");
            }
            else
            {
                foreach (String arrValue in arrIPAddress)
                {
                    Console.WriteLine("IPAddress: {0}", arrValue);
                }
            }

            if (arrIPSubnet.Count == 0)
            {
                Console.WriteLine("IPSubnet:");
            }
            else
            {
                foreach (String arrValue in arrIPSubnet)
                {
                    Console.WriteLine("IPSubnet: {0}", arrValue);
                }
            }
            Console.WriteLine("MACAddress: {0}", MACAddress);
            Console.WriteLine("ServiceName: {0}", ServiceName);

        }

        public override string ToString()
        {
            return string.Format("Not implemented");
            //return string.Format("VideoProcessor: {0} \nDescription: {1} \nCaption: {2} \nAdapterRAM: {3} ",
            //    VideoProcessor, Description, Caption, AdapterRAM);
        }

    }

}
