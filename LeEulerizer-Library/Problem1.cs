using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeEulerizer_Library
{
    public class Problem1
    {
        public long calculate(int upperBound)
        {
            if (upperBound == 0)
            {
                throw new ArgumentOutOfRangeException("upperBound", upperBound,
                    "the upperBound parameter must be greater than zero");
            }
            return Enumerable.Range(1, upperBound - 1)
                .Where(value => (value % 3 == 0 || value % 5 == 0))
                .Sum();
        }
    }
}