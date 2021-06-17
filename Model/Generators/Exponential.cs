using Simulation_System.Model.Generators;
using System;
using System.Collections.Generic;

namespace Simulation_System.Model
{
    class Exponential : IGenerator
    {
        public double[] Generate(List<double[]> varRowData, int quantity)
        {
            Random rndm = new Random();
            double average = StatChar.Average(varRowData);
            double[] randomRange = new double[quantity];
            for(int i = 0; i < quantity; i++)
            {
                randomRange[i] = -(1 / (1 / average) * Math.Log(1 - rndm.NextDouble()));
            }
            return randomRange;
        }
    }
}
