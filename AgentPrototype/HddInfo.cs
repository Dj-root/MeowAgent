using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    class HddInfo : SysInfo
    {
        public string Caption { get; set; }
        public string DeviceID { get; set; }    
        public string InterfaceType { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public double Size { get; set; }

        public HddInfo(string caption, string deviceId, string interfaceType, string manufacturer, string model, string serialNumber, double size)
        {
            Caption = caption;
            DeviceID = deviceId;
            InterfaceType = interfaceType;
            Manufacturer = manufacturer;
            Model = model;
            SerialNumber = serialNumber;
            Size = size;
        }

        public HddInfo()
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine("--------- Win32_DiskDrive instance ---------------");
            Console.WriteLine("Caption: {0}", Caption);
            Console.WriteLine("DeviceID: {0}", DeviceID);
            Console.WriteLine("InterfaceType: {0}", InterfaceType);
            Console.WriteLine("Manufacturer: {0}", Manufacturer);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Size: {0}", Size);
            Console.WriteLine("SerialNumber: {0}", SerialNumber);
        }

        public override string ToString()
        {
            return string.Format("Caption: {0} \nDeviceID: {1} \nInterfaceType: {2} \nManufacturer: {3} \n" +
                                 "Model: {4} \nSize: {5} \nSerialNumber: {6}",
                Caption, DeviceID, InterfaceType, Manufacturer, Model, Size, SerialNumber);
        }


    }
}


//Console.WriteLine("DeviceID: {0}; InterfaceType: {1}; Manufacturer: {2}; Model: {3}; SerialNumber: {4}; Size: {5} Gb", queryObj["DeviceID"],
//                    queryObj["InterfaceType"],
//                    queryObj["Manufacturer"],
//                    queryObj["Model"],
//                    queryObj["SerialNumber"],
//                    Math.Round(System.Convert.ToDouble(queryObj["Size"]) / 1024 / 1024 / 1024, 2));
//                Console.WriteLine("-----");
//            }