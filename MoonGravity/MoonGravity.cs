/*
 * The gravitational field of the Moon is approximately 17% of that on the Earth.

Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
The weight W should be read from the console.

*/

using System;
using System.Globalization;
using System.Threading;

class MoonGravity
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double weight = double.Parse(Console.ReadLine());
        double moonGravity = 0.17;
        double weightOnMoon = weight * moonGravity;
        Console.WriteLine(weightOnMoon.ToString("F3"));
    }
}
