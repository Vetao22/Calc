using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class MathFunctions
    {

        static double mem = 0;
        /// <summary>
        /// Add a to b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtract a from b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Sub(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiply a by b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divide a by b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Divide(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// Return the percent to be userd base on 'N'
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public double Percent(double n)
        {
            return n / 100;
        }

        /// <summary>
        /// Return the Square Root of 'N'
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public double Sqrt(double n)
        {
            if(n > 0)
            {
                return Math.Sqrt(n);
            }
            return 0;
        }

        /// <summary>
        /// Return 'N' raised to the power of 2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public double PowerOfTwo(double n)
        {
            if(n > 0)
            {
                return Math.Pow(n, 2);
            }
            return 0;
        }

        /// <summary>
        /// Divide '1' by 'n'
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public double OneDividedByN(double n)
        {
            if(n > 0)
            {
                return Divide(1, n);
            }
            return 0;
        }

        /// <summary>
        /// Set and Get the memory value
        /// </summary>
        public static double Mem
        {
            get { return mem; }
            set { mem = value; }
        }

        /// <summary>
        /// Add 'N' to the memory value
        /// </summary>
        /// <param name="n"></param>
        public void AddToMem(double n)
        {
            Add(Mem, n);
        }

        /// <summary>
        /// Subtract 'N' from the memory value
        /// </summary>
        /// <param name="n"></param>
        public void SubFromMem(double n)
        {
            Sub(Mem, n);
        }

        /// <summary>
        /// Clear the memory value
        /// </summary>
        public void MemClear()
        {
            Mem = 0;
        }
    }
}
