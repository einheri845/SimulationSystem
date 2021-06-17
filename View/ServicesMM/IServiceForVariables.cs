using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.View
{
    interface IServiceForVariables
    {
        void SetVariables(string[] variablesArray);
        event EventHandler GetVariables;
    }
}
