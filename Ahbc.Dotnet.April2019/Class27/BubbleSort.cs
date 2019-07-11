using System;
using System.Collections.Generic;
using System.Text;

namespace Class27
{
    public class BubbleSort
    {
        public List<T> Sort<T>(List<T> unsorted) where T:IComparable
        {
            if (unsorted == null || unsorted.Count <= 1)
            {
                return unsorted;
            }

            var middle = unsorted.Count / 2;
            var left = new List<T>();
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            var right = new List<T>();
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        private List<T> Merge<T>(List<T> left, List<T> right) where T:IComparable
        {
            var merged = new List<T>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0].CompareTo(right[0]) <= 0)
                    {
                        merged.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        merged.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    merged.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    merged.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            return merged;
        }
    }
}
