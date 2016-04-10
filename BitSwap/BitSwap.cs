/*

Description

Write a program first reads 3 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console.

Input

On the only four lines of the input you will receive the integers n, p, q and k in this order.
Output

Output a single value - the value of n after the bit swaps.

*/

using System;



class BitSwap
{
    static void Main()
    {
        uint nInput = uint.Parse(Console.ReadLine());
        int pInput = int.Parse(Console.ReadLine());
        int qInput = int.Parse(Console.ReadLine());
        int kInput = int.Parse(Console.ReadLine());

        for (int i = 0; i < (kInput); i++)
        {
            if (((nInput >> pInput) & 1u) != ((nInput >> qInput) & 1u))
            {
                nInput = nInput ^ (1u << pInput);
                nInput = nInput ^ (1u << qInput);
            }
            pInput++;
            qInput++;
        }
        Console.WriteLine(nInput);
    }
}
