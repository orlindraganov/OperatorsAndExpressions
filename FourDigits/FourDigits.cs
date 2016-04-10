/*
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:

Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
Puts the last digit in the first position: dabc (in our example 1201) and prints the result.
Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.
*/

using System;


class FourDigits
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int firstDigit = (inputNumber / 1000) % 10;
        int secondDigit = (inputNumber / 100) % 10;
        int thirdDigit = (inputNumber / 10) % 10;
        int fourthDigit = inputNumber % 10;
        Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("{3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
    }
}
