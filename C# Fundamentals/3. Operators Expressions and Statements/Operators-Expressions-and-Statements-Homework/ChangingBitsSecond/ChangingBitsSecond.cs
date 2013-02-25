using System;
class ChangingBitsSecond
{
    static void Main()
    {
        Console.Write("n=");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("p=");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q=");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        uint boofBit1, boofBit2;
        for (int i = 0; i < k; i++)
        {
            //Swapping the p+i bit and the q+i bit


            boofBit1 = ((n & (uint)(1 << p + i)) >> p + i); // Getting the bit on p+i position
            boofBit2 = ((n & (uint)(1 << q + i)) >> q + i); // Getting the bit on q+i position

            if      (boofBit1 == 1) n |= (uint)(1 << q + i);  // Changing the bit on q+i position
            else if (boofBit1 == 0) n &= (uint)~(1 << q + i); // with the one on p+i position

            if      (boofBit2 == 1) n |= (uint)(1 << p + i);  // Changing the bit on q+i position
            else if (boofBit2 == 0) n &= (uint)~(1 << p + i); // with the one on p+i position
        }
        Console.WriteLine(n);
    }
}