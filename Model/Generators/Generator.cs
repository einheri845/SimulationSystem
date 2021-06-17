using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.Model.Generators
{
    class Generator
    {
        public double[] Generate(int quantity)
        {
            double[] randNumbers = new double[quantity];
            Random rnd = new Random();
            for (int i = 0; i < quantity; i++)
            {
                randNumbers[i] = rnd.Next();
            }
            return randNumbers;
        }

        public int[] Generate(int quantity, int min, int max)
        {
            int[] randNumbers = new int[quantity];
            Random rnd = new Random();
            for (int i = 0; i < quantity; i++)
            {
                randNumbers[i] = rnd.Next(min, max);
            }
            return randNumbers;
        }
    }
}
