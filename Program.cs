using System;

class Program
{
    static void PrintDigitName(int digit)
    {
        string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        Console.WriteLine(digitNames[digit]);
    }

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        string numStr = num.ToString();

        for (int i = numStr.Length - 1; i >= 0; i--)
        {
            int digit = int.Parse(numStr[i].ToString());
            PrintDigitName(digit);
        }
    }
}
