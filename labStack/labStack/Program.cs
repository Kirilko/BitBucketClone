using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack x = new Stack();
            x.Push("Самара");
            x.Push("Samara");
            x.Push(341);
            Console.WriteLine(x.Peek());
            Console.WriteLine(x.Pop());
            Console.WriteLine(x.Pop());
            Console.WriteLine(x.Pop());
            try
            {
                Console.WriteLine(x.Pop());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
