using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.Model
{
    interface IDisIdent
    {
        List<double[]> DataForHistogram(double[] dataIdent, int countClass, out List<double[]> variationData, bool abnormalValues);
    }
}
