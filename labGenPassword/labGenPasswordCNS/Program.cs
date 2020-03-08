using labGenPassword.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labGenPasswordCNS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[4];
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                x[i] = int.Parse(Console.ReadLine());    
            }

            Console.WriteLine(Utils.RandomStr(a, (x[0] == 1),
                    (x[1] == 1), (x[2] == 1), (x[3] == 1)));
            Console.ReadLine();
        }
    }
}
