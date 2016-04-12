/*

Description

We are given an integer number N (read from the console), a bit value v (read from the console as well) (v = 0 or 1) 
and a position P (read from the console). Write a sequence of operators (a few lines of C# code) that modifies N to 
hold the value v at the position P from the binary representation of N while preserving all other bits in N. 
Print the resulting number on the console.

Input

The input will consist of exactly 3 lines containing the following:
First line - the integer number N.
Second line - the position P.
Third line - the bit value v.
Output

Output a single line containing the value of the number N with the modified bit.

*/

using System;

class ModifyBit
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        ulong v = ulong.Parse(Console.ReadLine());

        if (v == 1)
        {
            n = n | (1UL << p);
        }
        else
        {
            n = n & ~(1UL << p);
        }

        Console.WriteLine(n);




















        //{
        //    if (v == 0)
        //    {
        //        ulong mask = ~(1UL << p);
        //        ulong result = mask & n;
        //        Console.WriteLine(result);
        //    }
        //    else
        //    {
        //        ulong mask = (1UL << p);
        //        ulong result = mask | n;
        //        Console.WriteLine(result);
        //    }
        //}
    }
}