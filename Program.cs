using System;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Code-Ap203";
            Console.WriteLine((searchname(name)));
        }
        static bool searchname(string name)
        {
            bool isUpperLetter = false;
            bool isLowerLetter = false;
            bool isDigit = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsUpper(name[i]))
                {
                    isUpperLetter = true;
                }
                if (Char.IsLower(name[i]))
                {
                    isLowerLetter = true;
                }
                if (Char.IsDigit(name[i]))
                {
                    isDigit = true;
                }
            }
            return isDigit && isUpperLetter && isLowerLetter ;
        }
    }

}
