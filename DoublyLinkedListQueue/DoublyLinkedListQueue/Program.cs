using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Queue<int>();

            a.AddLast(123);
            a.AddLast(223);

            Console.WriteLine(a.RemoveFirst());

            Console.ReadLine();
        }
    }
}
