using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    class RamInfo: SysInfo
    {
         public string BankLabel { get; set; }
         public double Capacity { get; set; }
         public int Speed { get; set; }

        public RamInfo(string bankLabel, int capacity, int speed)
        {
            BankLabel = bankLabel;
            Capacity = capacity;
            Speed = speed;
        }

        public RamInfo()
        {
        }

        //public IEnumerator<ISysInfo> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

        

        public override void GetInfo()
        {
            Console.WriteLine("BankLabel = {0}, Capacity = {1} Speed = {2}", BankLabel, Capacity, Speed);
        }

        public override string ToString()
        {
            return string.Format("BankLabel = {0}, Capacity = {1} Speed = {2}", BankLabel, Capacity, Speed);
        }
    }
}



//Console.WriteLine("BankLabel: {0} ; Capacity: {1} Gb; Speed: {2} ", queryObj["BankLabel"],
//Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024, 2),
//queryObj["Speed"]);