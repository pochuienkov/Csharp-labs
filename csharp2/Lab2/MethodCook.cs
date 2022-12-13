using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal static class MethodCook
    {
        public static void Cook(this Campus campus)
        {
            campus.income += campus.income / 100 * 20;
            campus.staff = campus.staff + 5;
        }
    }
}