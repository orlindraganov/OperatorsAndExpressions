using System;

class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int thirdDigit;
        if (number < 100)
        {
            Console.WriteLine("false 0");
        }
        else
        {
            thirdDigit = ((number / 100) % 10);
            Console.WriteLine(thirdDigit == 7 ? "true" : "false " + thirdDigit);
        }
    }
}
