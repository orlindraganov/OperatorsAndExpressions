/*

Description

Write a program that reads an integer N (which will always be less than 100 or equal) and uses an expression 
to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).

Note: You should check if the number is positive

*/

using System;


class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if ((number <= 0) || (number == 1))
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; Math.Pow(i, 2) <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        Console.WriteLine(isPrime ? "true" : "false");
    }
}
