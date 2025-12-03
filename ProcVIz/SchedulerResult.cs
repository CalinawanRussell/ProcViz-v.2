using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcVIz
{
    public class SchedulerResult
    {
        public double AvgWaiting { get; set; }
        public double AvgTurnaround { get; set; }
        public double Throughput { get; set; }
    }
}
