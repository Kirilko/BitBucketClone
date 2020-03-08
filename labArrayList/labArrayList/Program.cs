using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(3.14);
            list.Add(256);
            list.AddRange(new string[] { "Hello", "world", "!" });
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();
            list.RemoveAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }
    }
}
