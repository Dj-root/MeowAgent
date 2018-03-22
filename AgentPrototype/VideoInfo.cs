using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    class VideoInfo : SysInfo
    {
        public string VideoProcessor { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public double AdapterRAM { get; set; }

        public VideoInfo(string videoProcessor, string description, string caption, double adapterRam)
        {
            VideoProcessor = videoProcessor;
            Description = description;
            Caption = caption;
            AdapterRAM = adapterRam;
        }

        public VideoInfo()
        {
        }


        public override void GetInfo()
        {
            Console.WriteLine("----------- Win32_VideoController instance -----------");
            Console.WriteLine("VideoProcessor: {0}", VideoProcessor);
            Console.WriteLine("Description: {0}", Description);
            Console.WriteLine("Caption: {0}", Caption);
            Console.WriteLine("AdapterRAM: {0}", AdapterRAM);
        }

        public override string ToString()
        {
            return string.Format("VideoProcessor: {0} \nDescription: {1} \nCaption: {2} \nAdapterRAM: {3} ",
                VideoProcessor, Description, Caption, AdapterRAM);
        }
    }
}



//Console.WriteLine("AdapterRAM: {0} GB", Math.Round(System.Convert.ToDouble(queryObj["AdapterRAM"]) / 1024 / 1024 / 1024, 2));
//Console.WriteLine("Caption: {0}", queryObj["Caption"]);
//Console.WriteLine("Description: {0}", queryObj["Description"]);
//Console.WriteLine("VideoProcessor: {0}", queryObj["VideoProcessor"]);
