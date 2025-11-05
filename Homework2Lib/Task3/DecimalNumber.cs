using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Homework2Lib
{
    public struct DecimalNumber
    {
        private int decimalInteger;

        public int DecimalInteger
        {
            get { return decimalInteger; }
            set
            {
                if (value == int.MaxValue)
                    throw new InvalidDataException("Value cannot be equal to int.MaxValue.");
                decimalInteger = value;
            }
        }

        public DecimalNumber(int value)
        {
            DecimalInteger = value;
        }

        public string ToBinary()
        {
            string result = decimalInteger >= 0
                ? Convert.ToString(decimalInteger, 2)
                : "-" + Convert.ToString(Math.Abs(decimalInteger), 2);

            string output = string.Format("View of {0} when the base is 2: {1}", decimalInteger, result);
            return output;
        }

        public string ToOctal()
        {
            string result = decimalInteger >= 0
                ? Convert.ToString(decimalInteger, 8)
                : "-" + Convert.ToString(Math.Abs(decimalInteger), 8);

            string output = string.Format("View of {0} when the base is 8: {1}", decimalInteger, result);
            return output;
        }

        public string ToHex()
        {
            string result = decimalInteger >= 0
                ? Convert.ToString(decimalInteger, 16).ToUpper()
                : "-" + Convert.ToString(Math.Abs(decimalInteger), 16).ToUpper(); // Якщо у записі числа є літери
                                                                                  // - переводимо їх у великі

            string output = string.Format("View of {0} when the base is 16: {1}", decimalInteger, result);
            return output;
        }
    }
}
