using Simulation_System.Model.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_System.Model
{
    class WorkSystem : ISimulation
    {
        public List<string[]> StartSystem(double[] responseTime)
        {
            DateTime[] arrivalTimes = GenerateTime(responseTime.Length);
            List<string[]> resultWorkSystem = new List<string[]>();
            DateTime tempEndRequest = arrivalTimes[0];
            for (int i = 0; i < responseTime.Length; i++)
            {
                string[] request = new string[6];
                request[0] = TimeString(arrivalTimes[i]);
                request[1] = Convert.ToString((int)responseTime[i]);
                if (tempEndRequest <= arrivalTimes[i])
                {
                    tempEndRequest = arrivalTimes[i];
                }
                request[2] = TimeString(tempEndRequest);
                DateTime timeEnd = tempEndRequest.AddMilliseconds((int)responseTime[i]);
                request[3] = TimeString(timeEnd);
                var timeQueue = tempEndRequest.Subtract(arrivalTimes[i]);
                request[4] = Convert.ToString(timeQueue.TotalMilliseconds);
                var allTime = timeEnd.Subtract(arrivalTimes[i]);
                if (allTime.TotalSeconds <= 60)
                {
                    request[5] = "+";
                }
                else
                {
                    request[5] = "-";
                }
                tempEndRequest = timeEnd;
                resultWorkSystem.Add(request);
            }
            return resultWorkSystem;
        }

        private DateTime[] GenerateTime(int count)
        {
            Generator generator = new Generator();
            List<DateTime> dateTimes = new List<DateTime>();
            int[] hhs = generator.Generate(count, 0, 23);
            int[] mms = generator.Generate(count, 0, 59);
            int[] sss = generator.Generate(count, 0, 59);
            int[] mss = generator.Generate(count, 10, 999);
            for (int i = 0; i < count; i++)
            {
                dateTimes.Add(new DateTime(1999, 07, 08, hhs[i], mms[i], sss[i], mss[i]));
            }
            dateTimes.Sort();
            return dateTimes.ToArray();
        }

        private string TimeString(DateTime time)
        {
            return String.Format("{0:HH:mm:ss:fff}", time);
        }


    }
}
