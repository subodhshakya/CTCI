using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._05BitManipulation._05_02BinaryToString
{
    public static class BinaryToString
    {
        /* Binary to string: Given a real number between 0 and 1 (e.g. 0.72) that is 
         * passed in as a double, print the binary representation. If the number cannot
         * be represented accurately in binary with at most 32 characters, pring 'Error'.         
         */
        public static string PrintBinary(double num)
        {
            if (num >= 1 || num <= 0)
            {
                return "Error";
            }

            StringBuilder sbBinary = new StringBuilder();
            sbBinary.Append(".");
            while (num > 0)
            {
                if (sbBinary.Length >= 32)
                {
                    return "Error";
                }

                double r = num * 2;
                if (r >= 1)
                {
                    sbBinary.Append("1");
                    num = r - 1;
                }
                else
                {
                    sbBinary.Append("0");
                    num = r;
                }
            }

            return sbBinary.ToString();
        }
    }
}
