using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.Model
{
    class Idetification : IDisIdent
    {
        public List<double[]> DataForHistogram(double[] data, int countClass, out List<double[]> variationData, bool abnormalValues) 
        {
            int nClass = countClass;
            int nElem = data.Length; // count elements in start sample
            List<double> dataList = data.ToList();
            variationData = VariationRange(dataList); // built variation range
            List<double[]> classesData = Clustering(variationData, nElem, nClass); // clustering data from variation range
            if (abnormalValues == true)
            {
                return FindAbnormalElements(dataList, classesData, variationData, nClass);
            }
            else
            {
                return classesData;
            }            
        }

        private List<double[]> VariationRange (List<double> data)
        {
            data.Sort(); // sort start sample
            List<double[]> variationData = new List<double[]>(); // variation range : [0] - numeric; [1] - count element in sample
            for(int i = 0; i < data.Count; i++)
            {
                
                double[] newElem = new double[2]; // variation range : [0] - numeric; [1] - count element in sample
                newElem[0] = data[i]; // add new element from start sample to variation range
                int countElem = 1; // start count of element
                if(i < data.Count - 1)
                {
                    for (int y = i + 1; (y < data.Count) && (data[y] == newElem[0]); y++) // count element
                    {
                        countElem++;
                    }
                }
                newElem[1] = countElem; // add count element in variation element
                variationData.Add(newElem); // add new variation element
                if(countElem > 1) // position next new element
                {
                    i += countElem - 1; 
                }
            }
            return variationData;
        }

        private List<double[]> Clustering(List<double[]> variationData, int nElem, int nClass)
        {
            if(nClass < 2)
            {
                nClass = NClass(nElem); // count class
            }
            double minElem = variationData[0][0]; // min element variation range
            double maxElem = variationData[variationData.Count - 1][0]; // max element
            double hClass = (maxElem - minElem) / nClass; // width class
            double[] tempClass = new double[3]; // boundaries prev class
            tempClass[0] = minElem; // boundaries next class
            tempClass[1] = minElem + hClass; // boundaries next class
            tempClass[2] = 0; //start frequency
            int tempPosition = 0; // position count 
            List<double[]> classesData = new List<double[]>(); // class : [0] - min boundaries; [1] - max boundaries; [2] - count; [3] - frequency
            for (int c = 1; c <= nClass; c++)
            {
                double[] variationCLass = new double[4]; // tempclass : [0] - min boundaries; [1] - max boundaries; [2] - count; [3] - frequency
                if (c == nClass) // add boundaries
                {
                    variationCLass[0] = tempClass[0];
                    variationCLass[1] = maxElem;
                    variationCLass[2] = variationData[variationData.Count - 1][1]; // add last element`s count
                }
                else
                {
                    tempClass.CopyTo(variationCLass, 0);
                    // new boundaries for next class 
                    tempClass[0] = variationCLass[1]; 
                    tempClass[1] = tempClass[0] + hClass;
                }

                for(;  variationData[tempPosition][0] >= variationCLass[0] && variationData[tempPosition][0] < variationCLass[1]; tempPosition++) // count and add frequency
                {
                    variationCLass[2] += variationData[tempPosition][1];
                }

                if(variationCLass[2] != 0) // frequency class
                {
                    variationCLass[3] = variationCLass[2] / nElem;
                }
                classesData.Add(variationCLass);  // add data for class                             
            }
            return classesData;
        }

        private int NClass(int nElem) // count classes
        {
            if(nElem < 100)
            {
                return Convert.ToInt32(1 + 3.32 * Math.Log10(nElem));
            }
            else
            {
                return Convert.ToInt32(1 + 1.44 * Math.Log(nElem));
            }
        }

        private List<double[]> FindAbnormalElements(List<double> dataList, List<double[]> classesData, List<double[]> variationData, int nClass)
        {
            for (int c = 0; (c < classesData.Count) && (nClass < variationData.Count); c++) // start find abnormal values
            {
                if (classesData[c][3] == 0) // find variation class with zero frequency
                {
                    double frequencyLeftClasses = 0;
                    bool tail = false; // position abnormal data in tail
                    double abnormalBoundariesMin; // class`s min boundaries with abnormal values
                    double abnormalBoundariesMax; // class`s max boundaries with abnormal values
                    for (int i = 0; i < c; i++) // count frequency left classes
                    {
                        frequencyLeftClasses += classesData[i][3];
                    }
                    if ((1 - frequencyLeftClasses) >= frequencyLeftClasses) // find classes with abnormal values and take their boundaries
                    {
                        abnormalBoundariesMin = classesData[0][0];
                        abnormalBoundariesMax = classesData[c - 1][1];
                    }
                    else
                    {
                        abnormalBoundariesMin = classesData[c + 1][0];
                        abnormalBoundariesMax = classesData[classesData.Count - 1][1];
                        tail = true;
                    }
                    // recursion with new data
                    return DataForHistogram(DelAbnormalElements(dataList, abnormalBoundariesMin, abnormalBoundariesMax, tail), nClass, out variationData, true);
                }
            }
            return classesData;
        }

        private double[] DelAbnormalElements(List<double> dataList, double min, double max, bool tail)
        {
            if (tail) // check position abnormal data : if position in tail - true
            {
                dataList.RemoveAll(elem =>
                {
                    if (elem >= min && elem <= max) return true;
                    else return false;
                });
                return dataList.ToArray();
            }
            else
            {
                dataList.RemoveAll(elem =>
                {
                    if (elem >= min && elem < max) return true;
                    else return false;
                });
                return dataList.ToArray();
            }
        }
       
    }
}
