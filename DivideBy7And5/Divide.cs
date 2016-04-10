/*
 * Write a program that does the following:
 *
 * Reads an integer number from the console.
 * Stores in a variable if the number can be divided by 7 and 5 without remainder.
 * Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5. Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.
 *
*/
using System;

class Divide
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isDividible;
        if ((number % 7 == 0) && (number % 5 == 0))
        {
            isDividible = true;
        }
        else
        {
            isDividible = false;
        }
        Console.WriteLine(isDividible ? "true " + number : "false " + number);
    }
}
