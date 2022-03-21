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

        public float MaximumYas => (float)MontlyCycle / 12;


        public void Run()
        {
            Console.WriteLine("Maximum Population Sayisi : " + Animal.CalculatePopulationCount(MontlyCycle) + "\n");
            Console.WriteLine("Maximum Age : " + MaximumYas.ToString("0.0") + "\n");
        }
    }
}
