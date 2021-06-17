using Simulation_System.View.ServicesMM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.View
{
    interface IMainMenu : IServiceForVariables, 
        IServiceForFile, 
        IServiceForGetDataParser, 
        IDrawHistogram, 
        IControlForm, 
        IShowTable,
        IServiceCustomClasses,
        IServiceGenerate,
        IServiceCreateRandTable,
        IResult

    {
        void FirstState();
        void SecondState(bool enabled);
        void ThirdState(bool enabled);
        void FourthState(bool enabled);
        void FifthState(bool enabled);
    }
}
