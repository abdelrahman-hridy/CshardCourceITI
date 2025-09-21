using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshardCourceITI
{
    public class Day6
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }

        public class Range<T> where T : IComparable<T>
        {
            private T min;
            private T max;

            public Range(T min, T max)
            {
                if (min.CompareTo(max) > 0)
                {
                    throw new ArgumentException("Min cannot be greater than Max");
                }
                this.min = min;
                this.max = max;
            }
            public bool IsInRange(T value)
            {
                return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
            }
            public dynamic Length()
            {
                return (dynamic)max - (dynamic)min;
            }

        }

        static void ReverseArrayList(ArrayList list)
        {
           int left = 0, right = list.Count - 1;
           while (left < right)
           {
               var temp = list[left];
               list[left] = list[right];
               list[right] = temp;
               left++;
               right--;
           }
        }

        static List<int> FindEvenNumber(List<int> numbers)
        {
            List<int> evens = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0) evens.Add(num);
            }
            return evens;
        }

        public class FixedList<T>
        {
            private T[] items;
            private int count = 0;
            public FixedList(int capacity)
            {
                if (capacity <= 0)
                {
                    throw new ArgumentException("Capacity must be > 0");
                }
                items = new T[capacity];
            }
            public void Add(T item)
            {
                if (count >= items.Length)
                {
                    throw new InvalidOperationException("List is full!");
                }
                items[count++] = item;
            }
            public T Get(int index)
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Invalid index!");
                }
                return items[index];
            }
        }

        static int FindFirstNonRepeatedChar(string s)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                }
                else freq[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (freq[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}