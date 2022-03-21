using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubbitSimulation
{
    public class Rubbit : Animal
    {
        public override double CalculatePopulationCount(int monthlyCycle)
        {
            return RecursiveFibonacci(monthlyCycle);
        }

        public double RecursiveFibonacci(int monthlyCycle)
        {
            // f(n) = f(n-1) + f(n-2)
            if (monthlyCycle <= 1)
            {
                return monthlyCycle;
            }
            else
            {
                return RecursiveFibonacci(monthlyCycle - 1) + RecursiveFibonacci(monthlyCycle - 2);
            }
        }

        public double FormulaFibonacci(int monthlyCycle)
        {
            // Fn = {[(√5 + 1)/2] ^ n} / √5
            double phi = (1 + Math.Sqrt(5)) / 2;
            return (int)Math.Round(Math.Pow(phi, monthlyCycle) / Math.Sqrt(5));
        }

        public double MultiThreadFibonacci(int monthlyCycle)
        {
            var worker = new RubbitWorker(monthlyCycle);
            return worker.Calculate();
        }

    }

    public class RubbitWorker
    {
        internal static readonly EventWaitHandle AllWorkersCompleted = new EventWaitHandle(false, EventResetMode.AutoReset);
        private static int numberOfWorkers = 0;
        private readonly int nthNumber;

        public RubbitWorker(int nthNumber)
        {
            Interlocked.Increment(ref numberOfWorkers);
            this.nthNumber = nthNumber;
        }

        public double Calculate()
        {
            var result = Fibonacci(nthNumber);
            if (Interlocked.Decrement(ref numberOfWorkers) == 0)
            {
                AllWorkersCompleted.Set();
            }
            return result;
        }
        internal static double Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
