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
            if (upperBound == 0)
            {
                throw new ArgumentOutOfRangeException("upperBound", upperBound,
                    "the upperBound parameter must be greater than zero");
            }
            this.upperBound = upperBound;
        }

        public long calculate()
        {
            return Enumerable.Range(1, upperBound - 1)
                .Where(value => (value % 3 == 0 || value % 5 == 0))
                .Sum();
        }
    }
}