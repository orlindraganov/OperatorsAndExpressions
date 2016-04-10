﻿/*
Write an expression that calculates rectangle’s area and perimeter by given width and height.The width and height should be read from the console.

Input


The input will consist of 2 lines:
On the first line, you will receive a floating-point number that will represent the width of the rectangle.
On the second line, you will receive another floating-point number that will represent the height of the rectangle.
Output

Output a single line - the rectangle's area and perimeter, separated by a whitespace.
Print the area and perimeter values with exactly 2-digits precision after the floating point
*/


using System;
using System.Globalization;
using System.Threading;



    class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine((width * height).ToString("F") + " " + ((width + height) * 2).ToString("F"));
    }
}
