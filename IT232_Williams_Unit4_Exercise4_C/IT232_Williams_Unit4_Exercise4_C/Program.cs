using System;
using System.Collections.Generic;
using System.Linq;

namespace IT232_Williams_Unit4_Exercise4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> newStack = new Stack<int>();

            newStack.Push(10);
            newStack.Push(24);
            newStack.Push(31);
            newStack.Push(45);
            newStack.Push(19);
            newStack.Push(76);

            Console.WriteLine("There are {0} items.", newStack.Count());

            newStack.Pop();
            newStack.Pop();
            newStack.Pop();

            Console.WriteLine("There are {0} items.", newStack.Count());
            Console.WriteLine("{0} is the next item to be popped.", newStack.Peek());
        }
    }
}
