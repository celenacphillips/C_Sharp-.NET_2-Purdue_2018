using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit4_Exercise5_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> newQueue = new Queue<int>();

            newQueue.Enqueue(10);
            newQueue.Enqueue(24);
            newQueue.Enqueue(31);
            newQueue.Enqueue(45);
            newQueue.Enqueue(19);
            newQueue.Enqueue(76);

            Console.WriteLine("There are {0} items in the queue.", newQueue.Count());

            newQueue.Dequeue();
            newQueue.Dequeue();

            Console.WriteLine("{0} is the next item that will be dequeued.", newQueue.Peek());
            Console.WriteLine("There are {0} items in the queue.", newQueue.Count());
        }
    }
}
