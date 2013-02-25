using System;

class ArrayInitializer
{
    static void Main()
    {
        int[] array = new int[20];

        for (int i = 0; i < 20; i++)
        {
            array[i] = i * 5;
        }

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("array[{0}] = {1}", i, array[i]);
        }
    }
}
