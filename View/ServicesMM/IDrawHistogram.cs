using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.View
{
    interface IDrawHistogram
    {
        void ViewHistogram(List<double[]> xy, bool generator = false);
        event EventHandler StartDraw;
    }
}
