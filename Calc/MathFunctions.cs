using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using org.mariuszgromada.math.mxparser;

namespace Calc
{
    public class MathFunctions
    {

        static double mem = 0, lastResult = 0;
 

        /// <summary>
        /// Return the percent to be userd base on 'N'
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double Percent(double n)
        {
            return n / 100;
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
        public static void AddToMem(double n)
        {
            Mem = ProcessResult(Mem + "+" + n);
        }

        /// <summary>
        /// Subtract 'N' from the memory value
        /// </summary>
        /// <param name="n"></param>
        public static void SubFromMem(double n)
        {
            Mem = ProcessResult(Mem + "-" + n);
        }

        /// <summary>
        /// Clear the memory value
        /// </summary>
        public static void MemClear()
        {
            Mem = 0;
        }


        public static void ClearResult()
        {
            lastResult = 0;
        }

        public static double ProcessResult(string equation)
        {
            Expression exp = new Expression(equation);
            

            return lastResult = exp.calculate();
        }

        /// <summary>
        /// Convert a decimal-degree angle to DMS
        /// </summary>
        /// <param name="deg"></param>
        /// <returns></returns>
        public static string DMS(string deg)
        {
            string result;
            try
            {
                decimal decimalNumber = Convert.ToDecimal(deg);
                decimal degrees, minutes, seconds;

                degrees = Convert.ToInt32(Math.Truncate(decimalNumber));
                minutes = Convert.ToInt32(Math.Truncate((decimalNumber - degrees) * 60));
                seconds = (((decimalNumber - degrees) * 60) - minutes) * 60;
                result = degrees + "." + minutes.ToString() + "" + (seconds).ToString();
            }
            catch
            {
                result = "NaN";
            }

            return result;
        }


        /// <summary>
        /// Convert DMS angle to decimal-degree
        /// </summary>
        /// <param name="dms"></param>
        /// <returns></returns>
        public static string DEG(string dms)
        {
            string result;

            try
            {
                // angle or bearing in degrees, minutes and seconds
                double angle = Convert.ToDouble(dms);

                //degrees, minutes and seconds
                double degminsec = angle;
                // decimal seconds
                double decsec = (degminsec * 100 - Math.Truncate(degminsec * 100)) / .6;
                //degrees and minutes
                double degmin = (Math.Truncate(degminsec * 100) + decsec) / 100;
                //degrees
                double deg = Math.Truncate(degmin);
                //decimal degrees
                double decdeg = deg + (degmin - deg) / .6;

                result = decdeg.ToString();
            }
            catch
            {
                result = "NaN";
            }

            return result;
        }

    
    }
}
