using System;

class NthBit
{
    static void Main()
    {
        ulong p = ulong.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        Console.WriteLine(((p >> n) & 1) == 1 ? 1 : 0);
    }
}
