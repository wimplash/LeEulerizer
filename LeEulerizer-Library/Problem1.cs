using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeEulerizer_Library
{
    public class Problem1
    {
        private int upperBound;

        public Problem1(int upperBound)
        {
            this.upperBound = upperBound;
        }

        public long calculate()
        {
            return Enumerable.Range(0, upperBound)
                .SkipWhile(value => (value % 3 != 0 || value % 5 != 0))
                .Sum();
        }
    }
}