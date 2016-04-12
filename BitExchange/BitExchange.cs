/*
 * 
 *
 Description

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).

Input

On the only input line you will receive the unsigned integer number whose bits you must exchange.
Output

On the only output line print the value of the integer with the exchanged bits.
 * 
 * 
 */

using System;


class BitExchange
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());

        byte position1 = 3;
        byte position2 = 24;
        byte positionsCount = 3;

        for (int i = 1; i <= positionsCount; i++)
        {
            if (((number >> position1) & 1UL) != ((number >> position2) & 1UL))
            {
                number = number ^ (1UL << position1);
                number = number ^ (1UL << position2);
            }
            position1++;
            position2++;
        }
        Console.WriteLine(number);
    }
}
