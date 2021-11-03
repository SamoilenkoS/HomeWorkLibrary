using System;

namespace HomeWorkLibrary
{
    public class VariableHelper
    {
        public static double Task1(double a, double b)
        {
            return a * b;
        }

        public static void Task2(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
    }
}
