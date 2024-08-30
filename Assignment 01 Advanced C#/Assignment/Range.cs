using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Range<T> where T : IComparable<T>
    {
        public T Minimum { get; }
        public T Maximum { get; }

        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum value must be less than or equal to the maximum value.");
            }

            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }

        public T Length()
        {
            dynamic min = Minimum;
            dynamic max = Maximum;
            return max - min;
        }
    }
}
