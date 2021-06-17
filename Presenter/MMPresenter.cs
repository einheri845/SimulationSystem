using Simulation_System.Model;
using Simulation_System.Model.Generators;
using Simulation_System.View;
using System;
using System.Collections.Generic;

namespace Simulation_System.Presenter
{
    class MMPresenter
    {
        IParser parser;
        IMainMenu servicesMM;
        IDisIdent identification;
        IGenerator generator;
        ISimulation simulation;

        public MMPresenter(IMainMenu sMM)
        {
            identification = new Idetification();
            parser = new CSVParser();
            simulation = new WorkSystem();
            servicesMM = sMM;
            servicesMM.GetVariables += FileToVariables;
            servicesMM.GetDataParse += MakeDataParse;
            servicesMM.StartDraw += StartDraw;
            servicesMM.Generate += Generate;
            servicesMM.SimulationSystem += StartSystem;
        }

        private List<double[]> varRowData;
        private double[] responceTime;

        void FileToVariables(object sender, EventArgs e)
        {
            string[] variables = parser.GetVariables(servicesMM.GetFile(parser.FilesFilter));
            if (variables != null)
            {
                servicesMM.SetVariables(variables);
                servicesMM.SecondState(true);
            }
            else
            {
                servicesMM.ErrorMessage(String.Format("Can`t read this file.\nProblems:\n - file is opening in other programm;\n - this file`s structure not supported."));
            }
        } 

        void MakeDataParse(object sender, EventArgs e)
        {
            int valuePos = servicesMM.ValuePosition();
            if(valuePos >= 0)
            {
                double[] dataParse = parser.Parse(servicesMM.GetFile(parser.FilesFilter), valuePos);
                if(dataParse != null)
                {
                    servicesMM.ThirdState(true);
                }
                else
                {
                    servicesMM.ErrorMessage("Variable not true! Choose another variable.");
                }
            }
            else
            {
                servicesMM.ErrorMessage("Choose need variable and try again.");
            }
        }

        void StartDraw(object sender, EventArgs e)
        {
            double[] data = parser.GetNeedValues();
            if (data != null)
            {
                List<double[]> dataForHistogram = identification.DataForHistogram(data, servicesMM.GetCountClasses(), out List<double[]> varData, servicesMM.GetDelAbnormalValues());
                varRowData = varData;
                servicesMM.ShowVarRange(varRowData);
                servicesMM.ShowClasses(dataForHistogram);
                servicesMM.ViewHistogram(dataForHistogram);
                servicesMM.FourthState(true);
            }
            else
            {
                servicesMM.ErrorMessage("Choose need value and try again.");
            }
        }

        void Generate(object sender, EventArgs e)
        {
            string distribution = servicesMM.GetDistribution();
            int quantityVal = servicesMM.GetQuantityRandValue();
            if (distribution != null)
            {
                switch (distribution)
                {
                    case "Exponential": 
                        generator = new Exponential();
                        break;
                    case "Normal":
                        generator = new Normal();
                        break;
                    case "Rayleigh":
                        generator = new Rayleigh();
                        break;
                    case "Uniform":
                        generator = new Uniform();
                        break;
                    default:
                        servicesMM.ErrorMessage("This distribution not supported.");
                        break;
                }
            }
            else
            {
                servicesMM.ErrorMessage("Distribution not chosen.");
            }
            if (generator != null)
            {
                if(varRowData != null)
                {
                    responceTime = generator.Generate(varRowData, quantityVal);
                    servicesMM.CreateRandTable(responceTime);
                    servicesMM.ViewHistogram(identification.DataForHistogram(responceTime, 0, out List<double[]> varData, true), true);
                }
                else
                {
                    servicesMM.ErrorMessage("Finish other step and try again.");
                }
            }
        }

        void StartSystem(object sender, EventArgs e)
        {
            if(responceTime != null)
            {
                servicesMM.ShowResult(simulation.StartSystem(responceTime));
            }
            else
            {
                servicesMM.ErrorMessage(String.Format("System can`t start!\nFinish other step and try again.\nP.S. Maybe the system is tired and doesn`t want to work, leave it alone..."));
            }
        }
    }
}
