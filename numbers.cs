using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimun(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }  
        }
        public int FindMinimun(int number1, int number2, float number3)
        {
            if (number1 < number2)
            {
                if (number1 < number3)
                {
                    return number1;
                }
                else
                {
                    return (int)number3;
                }
            }
            else
            {
                if (number2 < number3)
                {
                    return number2;
                }
                else
                {
                    return (int)number3;
                }
            }
        }
        public int FindMaximun(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number2;
            }
            else
            {
                return number1;
            }
        }
        public int FindMaximun(int number1, int number2, float number3)
        {
            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    return number1;
                }
                else
                {
                    return (int)number3;
                }
            }
            else
            {
                if (number2 > number3)
                {
                    return number2;
                }
                else
                {
                    return (int)number3;
                }
        }   }
    }  
}
