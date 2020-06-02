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
            var a = new LinkedQueue<int>();

            var b = new LinkedQueue<int>(5);

            b.Enqueue(12342);
            

            Console.WriteLine(b.Dequeue());

            Console.ReadLine();

            a.Enqueue(123);
            a.Enqueue(223);

            Console.WriteLine(a.Dequeue());

            Console.ReadLine();
        }
    }
}
