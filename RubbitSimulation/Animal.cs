using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubbitSimulation
{
    public abstract class Animal : IAnimal
    {
        public abstract double CalculatePopulationCount(int monthlyCycle);

    }
}
