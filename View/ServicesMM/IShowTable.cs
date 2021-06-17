using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.View
{
    interface IShowTable
    {
        void ShowVarRange(List<double[]> vaRData);
        void ShowClasses(List<double[]> classesData);
    }
}
