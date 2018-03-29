using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentPrototype
{
    static class Serializator
    {




        public static bool CheckIfPE()
        {
            string temp;
            string systemDrive;
            string systemRoot;
            string currentUser;
            bool isPE;
            
            var variables = Environment.GetEnvironmentVariables();
            temp = variables["TMP"].ToString();
            systemDrive = variables["SystemDrive"].ToString();
            systemRoot = variables["SystemRoot"].ToString();
            currentUser = variables["USERNAME"].ToString();

            if (systemDrive != "C:" && currentUser == "SYSTEM")
            {
                isPE = true;
            }
            else
            {
                isPE = false;
            }

            return isPE;
        }


        public static void SerializationPreparation()
        {
            // Check PE or not
            if (!CheckIfPE())
            {
                
            }
            else
            {
                Console.WriteLine("Method not implemented");
                //throw NotImplementedException;
            }
        }

        /*
        //variables.Key.Equals("HOMEPATH");

            //Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.System));

            Console.WriteLine();
            Console.WriteLine("GetEnvironmentVariables: ");
            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);

            Console.WriteLine("\n\nHOMEPATH: {0}", variables["HOMEPATH"]);
        
        //foreach (var folders in Enum.GetValues(Environment.SpecialFolder))
        //{

        //}
        */
    }
}
