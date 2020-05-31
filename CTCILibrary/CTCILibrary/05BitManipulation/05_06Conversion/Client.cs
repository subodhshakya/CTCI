using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._05BitManipulation._05_06Conversion
{
    public static class Client
    {
        public static void Run()
        {
            Console.WriteLine(Conversion.BitSwapRequired1(29, 15));
            Console.WriteLine(Conversion.BitSwapRequired2(29, 15));
        }
    }
}
