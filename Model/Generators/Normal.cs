using Simulation_System.Model.Generators;
using System;
using System.Collections.Generic;

namespace Simulation_System.Model
{
    class Normal : IGenerator
    {
        public double[] Generate(List<double[]> varRowData, int quantity)
        {
            Random rndm = new Random();
            double average = StatChar.Average(varRowData);
            double standDev = StatChar.StandardDeviation(varRowData, average);
            double[] randomRange = new double[quantity];
            for (int i = 0; i < quantity; i++)
            {
                randomRange[i] = 0;
                for (int j = 0; j < 12; j++)
                {
                    randomRange[i] += rndm.NextDouble();
                }
                randomRange[i] = average + ((randomRange[i] - 6) * standDev);
            }
            return randomRange;
        }
    }
}
