using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> x = new Dictionary<string, string>(5);
            x.Add("Samara", "Самара");
            x.Add("Самара", "Samara");
            x.Add("Smr", "Sam");
            x.Add("Sss", "Samar");
            foreach (KeyValuePair<string, string> keyValue in x)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            string coutry = x["Smr"];
            x["Smr"] = "Spain";
            x.Remove("Sss");
            Console.WriteLine();
            foreach (KeyValuePair<string, string> keyValue in x)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.ReadLine();
        }
    }
}
