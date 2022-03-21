using System;
using System.Diagnostics;

namespace RubbitSimulation
{
    public class Program
    {

        static void Main(string[] args)
        {
            var configuration = new ConfigurationService();
            var montlyCycle = configuration.GetMontlyCycle();

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var simulationRubbit = new Simulation<Rubbit>(montlyCycle);
            simulationRubbit.Run();

            Console.WriteLine("total ms: " + stopWatch.ElapsedMilliseconds);
       
            Console.WriteLine("-----------------");

            //var simulationChicken = new Simulation<Chicken>(montlyCycle);
            //simulationChicken.Run();

        }
    }
}