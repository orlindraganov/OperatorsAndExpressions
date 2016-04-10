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
        uint input = uint.Parse(Console.ReadLine());

        byte position1 = 3;
        byte position2 = 24;

        uint mask1 = 7U << position1;
        uint mask2 = 7U << position2;

        uint numbers1 = (mask1 & input);
        uint numbers2 = (mask2 & input);
        uint change = (input & ~mask1) & ~mask2;

        uint mask3 = (numbers1 >> position1) << position2;
        uint mask4 = (numbers2 >> position2) << position1;

        uint result = (change | mask3) | mask4;

        Console.WriteLine(result);
    }
}
