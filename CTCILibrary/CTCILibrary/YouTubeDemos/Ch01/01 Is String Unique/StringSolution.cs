using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.Ch01._01_Is_String_Unique
{
    public class StringSolution
    {
        public static void TestMethod()
        {
            Console.WriteLine("HELLO WORLD - Is Unique? " + IsUnique("HELLO WORLD"));
            Console.WriteLine("WORLD - Is Unique? " + IsUnique("WORLD"));
        }
        public static bool IsUnique(string s)
        {
            bool[] charOccuredFlag = new bool[256];

            foreach (char c in s)
            {
                int asciiValue = (int)c;
                if (charOccuredFlag[asciiValue])
                {
                    return false;
                }
                charOccuredFlag[asciiValue] = true;
            }

            return true;
        }
    }
}
