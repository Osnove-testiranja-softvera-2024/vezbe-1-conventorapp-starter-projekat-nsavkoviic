using OTS2023_ConventorApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    public class Money : IConvert
    {
        public double Convert(double number)
        {
            return number * 117.5;
        }
        public double ConvertArray(string numbers)
        {
            string[] values = numbers.Split(',');

            double number = 0;
            for (int i = 0; i < values.Length; i++)
            {
                number += Convert(Double.Parse(values[i]));
            }

            return number;
        }
    }
}