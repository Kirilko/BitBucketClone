using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue x = new Queue();
            x.Enqueue(6);
            x.Enqueue("Hello");
            x.Enqueue(",");
            x.Enqueue("world");
            Console.WriteLine(x.Peek());
            Console.WriteLine("---");
            while (x.Count > 0)
            {
                Console.WriteLine(x.Dequeue());
            }
            Console.ReadLine();
        }
    }
}
