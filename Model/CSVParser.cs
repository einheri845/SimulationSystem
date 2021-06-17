using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Simulation_System.Model
{
    public class CSVParser : IParser
    {
        private string fileFilter = "CSV files (*.csv) |*.csv";
        private double[] needValues;
        private List<string[]> dateTimeRequests = new List<string[]>();

        public string FilesFilter
        {
            get => fileFilter;
            set => fileFilter = value;
        }

        public double[] GetNeedValues()
        {
            return needValues;
        }

        public string[] GetVariables(string filePath)
        {
            try
            {
                using (StreamReader sR = new StreamReader(filePath))
                {
                    string varLine;
                    while ((varLine = sR.ReadLine()) != null)
                    {
                        if (varLine.StartsWith("@"))
                        {
                            varLine = varLine.TrimStart('@');
                            break;
                        }
                    }

                    if (varLine != null)
                    {
                        string[] variables = varLine.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        return variables;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch
            {
                return null;
            }
            
        }

        public double[] Parse(string filePath, int numbVar)
        {
            if (filePath != null)
            {
                List<double> tempNeedValues = new List<double>();
                List<string[]> tempDateTimeR = new List<string[]>();
                using (TextFieldParser parser = new TextFieldParser(filePath))
                {                    
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    int numbRow = 0;
                    while (!parser.EndOfData)
                    {                        
                        string[] column = new string[2];
                        string[] fields = parser.ReadFields();
                        if (numbRow != 0)
                        {
                            column[0] = fields[0];
                            try
                            {
                                string tempS = fields[numbVar];
                                tempS = tempS.Replace('.', ',');
                                tempNeedValues.Add(Convert.ToDouble(tempS) * 1000);
                            }
                            catch
                            {
                                return null;
                            }
                            int startIndex = fields[1].IndexOf('[');
                            if (startIndex >= 0)
                            {
                                column[1] = fields[1].Substring(startIndex + 1, 20);
                                tempDateTimeR.Add(column);
                            }
                        }
                        else
                        {
                            numbRow++;
                        }
      
                    }             
                }
                dateTimeRequests = tempDateTimeR;
                needValues = ListToDouble(tempNeedValues);
                return needValues;
            }
            else
            {
                return null;
            }
        }

        private double[] ListToDouble(List<double> data)
        {
            double[] tempData = new double[data.Count];
            for(int i = 0; i < data.Count; i++)
            {
                tempData[i] = data[i];
            }
            return tempData;
        }

        private List<string[]> DateParse(List<string[]> dTReq)
        {
            return null;
        }
    }
}
