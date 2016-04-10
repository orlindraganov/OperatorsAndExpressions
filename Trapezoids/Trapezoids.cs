/*
 
Description

Write an expression that calculates trapezoid's area by given sides a and b and height h. The three values should be read from the console in the order shown below. All three value will be floating-point numbers.

Input

The input will consist of exactly 3 lines:
The side a on the first line.
The side b on the second line.
The height h on the third line.
Output

Output a single line containing a single value - the area of the trapezoid. Output the area with exactly 7-digit precision after the floating point.

*/

using System;
using System.Globalization;
using System.Threading;

class Trapezoids
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = (sideA + sideB) * height * 0.5;
        Console.WriteLine(area.ToString("F7"));
    }
}
