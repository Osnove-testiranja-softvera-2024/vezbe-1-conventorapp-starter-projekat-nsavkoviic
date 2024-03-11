using OTS2023_ConventorApp.Interface;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Classes
{
    public class Time : ITime
    {
        public double ConvertHours(double days)
        {
            return days * 24;
        }
        public double ConvertMinutes(double days)
        {
            return days * 24 * 60;
        }
        public double ConvertSeconds(double days)
        {
            double pom = 1;
            for(int i=0; i<2; i++)
            {
                pom = pom * 60;
            }
            return days * 24 * pom;
        }
    }
}
