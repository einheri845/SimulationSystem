using Simulation_System.Model.Generators;
using System;
using System.Collections.Generic;

namespace Simulation_System.Model
{
    class Uniform : IGenerator
    {
        public double[] Generate(List<double[]> varRowData, int quantity)
        {
            Random rndm = new Random();
            double[] randomRage = new double[quantity];
            double average = StatChar.Average(varRowData);
            double secDegAver = StatChar.Average(varRowData, true);
            double paramA = average - Math.Sqrt(3 * (secDegAver - Math.Pow(average, 2)));
            double paramB = average + Math.Sqrt(3 * (secDegAver - Math.Pow(average, 2)));
            for (int i = 0; i < quantity; i++)
            {
                randomRage[i] = paramA + rndm.NextDouble() * (paramB - paramA);
            }
            return randomRage;
        }
    }
}
