using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.View
{
    interface IServiceForGetDataParser
    {
        int ValuePosition();
        event EventHandler GetDataParse;
    }
}
