using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.Model
{
    public interface IParser
    {
        string FilesFilter { get; set; }
        double[] GetNeedValues();
        string[] GetVariables(string filePath);
        double[] Parse(string filePath, int numberVariables);
    }
}
