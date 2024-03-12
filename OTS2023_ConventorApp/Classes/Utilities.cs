using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Classes
{
    class Utilities
    {
        public static double[] ConvertArray(List<String> array)
        {
            int nums = array.Count;
            double[] numbers = new double[nums];
            for (int i = 0; i < nums; i++)
            {
                numbers[i] = Double.Parse(array[0]);
                array.RemoveAt(0);
            }
            return numbers;
        }
    }
}