using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.View.ServicesMM
{
    interface IResult
    {
        event EventHandler SimulationSystem;
        void ShowResult(List<string[]> resultWorkSystem);
    }
}
