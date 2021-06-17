using Simulation_System.Model.Generators;
using System;
using System.Collections.Generic;

namespace Simulation_System.Model
{
    class Rayleigh : IGenerator
    {
        public double[] Generate(List<double[]> varRowData, int quantity)
        {
            Random rndm = new Random();
            double[] randomRange = new double[quantity];
            double paramEstimate = StatChar.Average(varRowData, false, true);
            for(int i = 0; i < quantity; i++)
            {
                randomRange[i] = paramEstimate * Math.Sqrt(-2 * Math.Log(1 - rndm.NextDouble()));
            }
            return randomRange;
        }
    }
}
