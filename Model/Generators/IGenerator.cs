using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.Model.Generators
{
    public interface IGenerator
    {
        double[] Generate(List<double[]> varRowData, int quantity);
    }
}
