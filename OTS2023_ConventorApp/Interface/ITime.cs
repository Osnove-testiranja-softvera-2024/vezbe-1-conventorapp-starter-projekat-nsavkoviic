using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Interface
{
    internal interface ITime
    {
        double ConvertHours(double days);
        double ConvertMinutes(double days);
        double ConvertSeconds(double days);

    }
}
