using System;

namespace Open_Lab_03._06
{
    public class Checker
    {
        public bool HasSpaces(string str)
        {
          string str = " n ";
            bool b1 = String.IsNullOrWhiteSpace(str);
            Console.WriteLine(b1);
        }
    }
}
