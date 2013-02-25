using System;
class ChangingBits
{
    static void Main()
    {
        Console.Write("n=");
        uint n = uint.Parse(Console.ReadLine());
        int k;
        uint boofBit, boofBit2;

        //Swapping the 3rd and the 24th bit
        boofBit = ((n & (1 << 3)) >> 3);
        boofBit2 = ((n & (1 << 24)) >> 24);
        k = ~(1 << 24);
        if (boofBit == 1) n |= (1 << 24);
        else if (boofBit == 0) n &= (uint)k;
        k = ~(1 << 3);
        if (boofBit2 == 1) n |= (1 << 3);
        else if (boofBit2 == 0) n &= (uint)k;

        //Swapping the 4th and the 25th bit
        boofBit = ((n & (1 << 4)) >> 4);
        boofBit2 = ((n & (1 << 25)) >> 25);
        k = ~(1 << 25);
        if (boofBit == 1) n |= (1 << 25);
        else if (boofBit == 0) n &= (uint)k;
        k = ~(1 << 4);
        if (boofBit2 == 1) n |= (1 << 4);
        else if (boofBit2 == 0) n &= (uint)k;

        //Swapping the 5th and the 26st bit
        boofBit = ((n & (1 << 5)) >> 5);
        boofBit2 = ((n & (1 << 26)) >> 26);
        k = ~(1 << 26);
        if (boofBit == 1) n |= (1 << 26);
        else if (boofBit == 0) n &= (uint)k;
        k = ~(1 << 5);
        if (boofBit2 == 1) n |= (1 << 5);
        else if (boofBit2 == 0) n &= (uint)k;


        Console.WriteLine(n);
    }
}
