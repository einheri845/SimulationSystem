using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.Model
{
    static class StatChar
    {
        static public double Average(List<double[]> varRowData, bool secDegree = false, bool Rayleigh = false)
        {
            double averageVal = 0;
            int countElem = 0;
            for(int i = 0; i < varRowData.Count; i++)
            {
                countElem += (int)varRowData[i][1];
                if(secDegree == true || Rayleigh == true)
                {
                    averageVal += Math.Pow(varRowData[i][0], 2) * varRowData[i][1];
                }
                else
                {
                    averageVal += varRowData[i][0] * varRowData[i][1];
                }
            }
            if(Rayleigh == true)
            {
                averageVal /= countElem * 2;
                return Math.Sqrt(averageVal);
            }
            else
            {
                averageVal /= countElem;
                return averageVal;
            }
        }

        static public double Dispersion (List<double[]> varRowData)
        {
            double dispersion = 0;
            int countElem = 0;
            double average = Average(varRowData);
            for(int i = 0; i < varRowData.Count; i++)
            {
                dispersion += Math.Pow(varRowData[i][0] - average, 2) * varRowData[i][1];
                countElem += (int)varRowData[i][1];
            }
            return dispersion / countElem;
        }

        static public double Dispersion (List<double[]> varRowData, double average)
        {
            double dispersion = 0;
            int countElem = 0;
            for (int i = 0; i < varRowData.Count; i++)
            {
                dispersion += Math.Pow(varRowData[i][0] - average, 2) * varRowData[i][1];
                countElem += (int)varRowData[i][1];
            }
            return dispersion / countElem;
        }

        static public double StandardDeviation(List<double[]> varRowData)
        {
            return Math.Sqrt(Dispersion(varRowData));
        }

        static public double StandardDeviation(List<double[]> varRowData, double average)
        {
            return Math.Sqrt(Dispersion(varRowData, average));
        }
    }
}
