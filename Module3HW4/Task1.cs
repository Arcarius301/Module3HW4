using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4
{
    public class Task1
    {
        public event Func<int, int, int> SumCompleted;
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int MethodsSum(int x, int y)
        {
            int sum = 0;
            foreach (Func<int, int, int> function in SumCompleted.GetInvocationList())
            {
                sum += function(x, y);
            }

            Console.WriteLine(sum);
            return sum;
        }

        public void TryCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Run(int x, int y)
        {
            SumCompleted += Sum;
            SumCompleted += Sum;
            Console.WriteLine($"Sum({x}, {y})");
            TryCatch(() => MethodsSum(x, y));
        }
    }
}
