using System;

namespace Module3HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var task1 = new Task1();
            Console.WriteLine("Task 1:\n");
            task1.Run(5, 5);
            var task2 = new Task2();
            Console.WriteLine("Task 2:\n");
            task2.Run();
        }
    }
}
