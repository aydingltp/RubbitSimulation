using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubbitSimulation
{
    public class Simulation<TEntity> where TEntity : Animal, new()
    {
        private Animal Animal { get; set; }
        private int MontlyCycle { get; set; }

        public Simulation(int montlyCycle)
        {
            MontlyCycle = montlyCycle;
            Animal = new TEntity();
        }

        private float MaximumAge => (float)MontlyCycle / 12;
        private double MaximumPopulation { get; set; }

        public void Run()
        {
            MaximumPopulation = Animal.CalculatePopulationCount(MontlyCycle);

            Console.WriteLine("Montly Cycle : " + MontlyCycle + "\n");
            Console.WriteLine("Maximum Population : " + MaximumPopulation + "\n");
            Console.WriteLine("Maximum Age : " + MaximumAge.ToString("0.0") + "\n");
            Console.WriteLine("Number of male/female animals: ~" + (int)MaximumPopulation / 2 + "\n");
        }
    }
}
