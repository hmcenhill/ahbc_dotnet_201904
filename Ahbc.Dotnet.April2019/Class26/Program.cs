using System;
using System.Collections.Generic;

namespace Class26
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsorted = new List<int> {8, 72, 37, 16, 2, 24};
            Console.WriteLine(string.Join(", ", unsorted));
            
            var sorted = MergeSort(unsorted); //Sort(unsorted);
            Console.WriteLine(string.Join(", ", sorted));

            Console.WriteLine(LinearSearch(sorted.ToArray(), 16));

            //var unsortedStrings = new[] {"a", "z", "b", "t", "A"};
            //Console.WriteLine(string.Join(", ", Sort(unsortedStrings)));
        }

        private static T[] Sort<T>(T[] unsorted) where T:IComparable
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = i + 1; j < unsorted.Length; j++)
                {
                    if (unsorted[i].CompareTo(unsorted[j]) >= 0)
                    {
                        var temp = unsorted[j];
                        unsorted[j] = unsorted[i];
                        unsorted[i] = temp;
                    }
                }
            }

            return unsorted;
        }

        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            var middle = unsorted.Count / 2;
            var left = new List<int>();
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            var right = new List<int>();
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            var merged = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])
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

        private static bool LinearSearch(int[] inputArray, int key)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (key == inputArray[i])
                {
                    return true;
                }
                else if (key < inputArray[i])
                {
                    return false;
                }
            }

            return false;
        }

        private static bool BinarySearch(int[] inputArray, int key)
        {
            var min = 0;
            var max = inputArray.Length;
            while (min <= max)
            {
                var middle = (min + max) / 2;
                if (inputArray[middle] == key)
                {
                    return true;
                }
                else if (inputArray[middle] < key)
                {
                    min = middle + 1;
                }
                else
                {
                    max = middle - 1;
                }
            }

            return false;
        }
    }
}
