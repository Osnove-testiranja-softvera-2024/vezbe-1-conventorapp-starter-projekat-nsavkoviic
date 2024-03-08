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
    }
}