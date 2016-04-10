/*
 * 
 * Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y) 
 * if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 * 
 * 
 * */

using System;
using System.Globalization;
using System.Threading;


class PointCircleRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double distanceCircle = Math.Sqrt(Math.Pow((x-1), 2.0) + Math.Pow((y-1), 2.0));
        bool isInCircle = (distanceCircle <= 1.5);
        bool isInRectangle = ((x >= -1) && (x <= 5) && (y <= 1) && (y >= -1));
        Console.WriteLine((isInCircle ? "inside circle" : "outside circle") + " " + (isInRectangle ? "inside rectangle" : "outside rectangle"));
    }
}
