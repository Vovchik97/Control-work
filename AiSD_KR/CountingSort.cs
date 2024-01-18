using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_KR
{
    internal class Counting_Sort
    {
        public static int[] CountingSort(int[] array, ref int comparisonsCount, ref int swapsCount)
        {
            int minValue = array[0];
            int maxValue = array[0];
            int size = array.Length;

            for (int i = 1; i < size; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    comparisonsCount++;
                }

                else if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    comparisonsCount++;
                    comparisonsCount++;
                }

                else
                {
                    comparisonsCount++;
                    comparisonsCount++;
                }
            }

            int range = maxValue - minValue + 1;
            int[] count = new int[range];

            for (int i = 0; i < size; i++)
            {
                count[array[i] - minValue]++;
            }

            for (int i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }

            int[] output = new int[size];

            for (int i = size - 1; i >= 0; i--)
            {
                output[count[array[i] - minValue] - 1] = array[i];
                count[array[i] - minValue]--;
                swapsCount++;
            }

            for (int i = 0; i < size; i++)
            {
                array[i] = output[i];
            }

            return array;
        }


        public static int[] CountingSort(int[] array)
        {
            int minValue = array[0];
            int maxValue = array[0];
            int size = array.Length;

            for (int i = 1; i < size; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }

                else if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            int range = maxValue - minValue + 1;
            int[] count = new int[range];

            for (int i = 0; i < size; i++)
            {
                count[array[i] - minValue]++;
            }

            for (int i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }

            int[] output = new int[size];

            for (int i = size - 1; i >= 0; i--)
            {
                output[count[array[i] - minValue] - 1] = array[i];
                count[array[i] - minValue]--;
            }

            for (int i = 0; i < size; i++)
            {
                array[i] = output[i];
            }

            return array;
        }
    }
}
