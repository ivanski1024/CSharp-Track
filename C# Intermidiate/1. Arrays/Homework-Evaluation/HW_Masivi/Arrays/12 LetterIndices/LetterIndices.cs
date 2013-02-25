using System;

class LetterIndices
{
    static void Main(string[] args)
    {
        char[] alphabet = new char[26];

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char) ('\u0041' + i); // capital letters as requested by the assignment
        }

        Console.WriteLine("Write a word: ");
        string word = Console.ReadLine();

        foreach (char symbol in word)
        {
            for (int i = 0; i < 26; i++)
            {
                if (symbol == alphabet[i])
                {
                    Console.WriteLine("Charachter {0} corresponds to number {1}", symbol, i);
                    break;
                }
            }           
        }
    }
}

