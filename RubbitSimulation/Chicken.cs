﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubbitSimulation
{
    public class Chicken : Animal
    {
        public override double CalculatePopulationCount(int monthlyCycle)
        {
            Console.WriteLine("chicken :");

            return monthlyCycle;
        }
    }
}   
