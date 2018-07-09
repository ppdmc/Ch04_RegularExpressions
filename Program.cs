using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace Ch04_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("너의 나이를 입력해라 : ");
            string input = ReadLine();
            Regex ageChecker = new Regex(@"\d");
            if(ageChecker.IsMatch(input))
            {
                WriteLine("잘했다!");
            }
            else
            {
                WriteLine($"아냐,아냐 {input} 이건 입력방식이 아니야");
            }
        }
    }
}
