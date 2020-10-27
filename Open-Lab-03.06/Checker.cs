using System;

namespace Open_Lab_03._06
{
    public class Checker
    {
        public bool HasSpaces(string str)
        {
           string str = "Hello People";
            Console.WriteLine(char.IsWhiteSpace(str, 5));
        }
    }
}
