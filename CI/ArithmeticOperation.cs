using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CI
{
    public static class ArithmeticOperation
    {
        public static double Addition(double number1, double number2)
        {
            return number1 + number2;
        }

        public static string GetEmployeeName(int empId)
        {
            string name;
            if (empId == 1)
            {
                name = "Dhruv";
            }
            else if (empId == 2)
            {
                name = "Abhir";
            }
            else
            {
                name = "Aayush";
            }
            return name;
        }
    }
}
