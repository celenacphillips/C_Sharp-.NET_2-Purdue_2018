using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT232_Williams_Unit3_Exercise4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            String [,] nameAndGrades = new String[,] {{ "Ron", "A"}, { "Bob", "B"}, { "Craig", "C",}};

            Console.WriteLine("Results by test number");

            Console.WriteLine("Test 1:");
            Console.WriteLine("{0} scored {1}", nameAndGrades[0,0], nameAndGrades[0,1]);
            Console.WriteLine("{0} scored {1}", nameAndGrades[1, 0], nameAndGrades[1, 1]);
            Console.WriteLine("{0} scored {1}", nameAndGrades[2, 0], nameAndGrades[2, 1]);

            Console.WriteLine("\nTest 2:");
            Console.WriteLine("{0} scored {1}", nameAndGrades[0, 0], nameAndGrades[1, 1]);
            Console.WriteLine("{0} scored {1}", nameAndGrades[1, 0], nameAndGrades[1, 1]);
            Console.WriteLine("{0} scored {1}", nameAndGrades[2, 0], nameAndGrades[2, 1]);

            Console.WriteLine("\nTest 3:");
            Console.WriteLine("{0} scored {1}", nameAndGrades[0, 0], nameAndGrades[0, 1]);
            Console.WriteLine("{0} scored {1}", nameAndGrades[1, 0], nameAndGrades[2, 1]);
            Console.WriteLine("{0} scored {1}", nameAndGrades[2, 0], nameAndGrades[1, 1]);

            Console.WriteLine("\nTest 4:");
            Console.WriteLine("{0} scored {1}", nameAndGrades[0, 0], nameAndGrades[1, 1]);
            Console.WriteLine("{0} scored {1}", nameAndGrades[1, 0], nameAndGrades[1, 1]);
            Console.WriteLine("{0} scored {1}", nameAndGrades[2, 0], nameAndGrades[2, 1]);

            Console.WriteLine("\n\nResults by student number");
            Console.WriteLine("Student 1:");
            Console.WriteLine("{0} scored {1} on test 1", nameAndGrades[0,0], nameAndGrades[0,1]);
            Console.WriteLine("{0} scored {1} on test 2", nameAndGrades[0, 0], nameAndGrades[1, 1]);
            Console.WriteLine("{0} scored {1} on test 3", nameAndGrades[0, 0], nameAndGrades[0, 1]);
            Console.WriteLine("{0} scored {1} on test 4", nameAndGrades[0, 0], nameAndGrades[1, 1]);

            Console.WriteLine("\nStudent 2:");
            Console.WriteLine("{0} scored {1} on test 1", nameAndGrades[1, 0], nameAndGrades[1, 1]);
            Console.WriteLine("{0} scored {1} on test 2", nameAndGrades[1, 0], nameAndGrades[1, 1]);
            Console.WriteLine("{0} scored {1} on test 3", nameAndGrades[1, 0], nameAndGrades[2, 1]);
            Console.WriteLine("{0} scored {1} on test 4", nameAndGrades[1, 0], nameAndGrades[1, 1]);

            Console.WriteLine("\nStudent 3:");
            Console.WriteLine("{0} scored {1} on test 1", nameAndGrades[2, 0], nameAndGrades[2, 1]);
            Console.WriteLine("{0} scored {1} on test 2", nameAndGrades[2, 0], nameAndGrades[2, 1]);
            Console.WriteLine("{0} scored {1} on test 3", nameAndGrades[2, 0], nameAndGrades[1, 1]);
            Console.WriteLine("{0} scored {1} on test 4", nameAndGrades[2, 0], nameAndGrades[2, 1]);

            Console.WriteLine("\n\nResults of student names");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(nameAndGrades[i, 0]);
            }
        }
    }
}
