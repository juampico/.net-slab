using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLab.Net.Extensions
{
    public static class IntExtensions
    {


        public static double divideByZero(this int i)
        {
            return i / 0;
        }
    }
}
