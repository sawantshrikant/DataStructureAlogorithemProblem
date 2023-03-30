using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithmProblems
{
    internal class CustomizeString
    {
        public void customize()
        {
            string line = "Hello <<name>>, we have your full name as <<full name>> in our system";
            line = line.Replace("<<name>>", "Shrikant");
            line = line.Replace("<<full name>>", "Shrikant sawant");
            line = line.Replace("91-xxxxxxxxx", "91-1234567890");
            Console.WriteLine(line);
        }
    }
}
