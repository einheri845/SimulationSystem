using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.Model
{
    interface ISimulation
    {
        List<string[]> StartSystem(double[] responseTime);
    }
}
