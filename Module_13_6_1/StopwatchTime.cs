using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Module_13_6_1
{
    internal class StopwatchTime
    {
        Stopwatch stopWatch;
        public StopwatchTime()
        {
            stopWatch = new Stopwatch();
        }
        public void StartTimer()
        {
            stopWatch.Restart();
        }

        public double TimeWork()
        {           
            stopWatch.Stop();
            
            return stopWatch.Elapsed.TotalMilliseconds;
        }
    }
}
