using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.View.ServicesMM
{
    public interface IServiceGenerate
    {
        string GetDistribution();
        int GetQuantityRandValue();
        event EventHandler Generate;
    }
}
