using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeEulerizer_Library
{
    public class Problem1
    {
        private static TraceSource _source = new TraceSource(typeof(Problem1).FullName);

        public long Calculate(int upperBound)
        {
            if (upperBound <= 1)
            {
                throw new ArgumentOutOfRangeException("upperBound", upperBound,
                    "the upperBound parameter must be greater than one");
            }
            _source.TraceEvent(TraceEventType.Start, 0, "beginning calculation with upperBound: {0}", upperBound);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long result = Enumerable.Range(1, upperBound - 1)
                .Where(value => (value % 3 == 0 || value % 5 == 0))
                .Sum();
            sw.Stop();
            _source.TraceEvent(TraceEventType.Stop, 0, "finished calculation with upperBound: {0}, result {1} ({2} ms)", upperBound, result, sw.Elapsed);
            return result;
        }
    }
}