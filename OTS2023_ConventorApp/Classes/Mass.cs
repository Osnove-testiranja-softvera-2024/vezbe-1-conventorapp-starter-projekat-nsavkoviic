﻿using OTS2023_ConventorApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Classes
{
    public class Mass : IConvert
    {
        public double Convert(double number)
        {
            return Math.Round(number / 2.2, 3);
        }
        public double ConvertArray(string array)
        {
            string[] values = array.Split(',');

            double number = 0;
            for(int i=0; i<values.Length; i++)
            {
                number += Double.Parse(values[i]);
            }
            return Convert(number);
        }
    }
}
