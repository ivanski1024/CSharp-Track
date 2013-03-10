using System;
class DeckOfCards
{
    static void Main()
    {
        for (int color = 1; color <= 4; color++)
        {
            for (int card = 14; card >= 2; card--)
            {
                switch (card)
                {
                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;
                    case 4:
                        Console.Write("Four ");
                        break;
                    case 5:
                        Console.Write("Five ");
                        break;
                    case 6:
                        Console.Write("Six ");
                        break;
                    case 7:
                        Console.Write("Seven ");
                        break;
                    case 8:
                        Console.Write("Eight ");
                        break;
                    case 9:
                        Console.Write("Nine ");
                        break;
                    case 10:
                        Console.Write("Ten ");
                        break;
                    case 11:
                        Console.Write("Jack ");
                        break;
                    case 12:
                        Console.Write("Queen ");
                        break;
                    case 13:
                        Console.Write("King ");
                        break;
                    case 14:
                        Console.Write("Ace ");
                        break;
                }
                switch (color)
                {
                    case 1:
                        Console.Write("of Spades");
                        break;
                    case 2:
                        Console.Write("of Hearts");
                        break;
                    case 3:
                        Console.Write("of Diamonds");
                        break;
                    case 4:
                        Console.Write("of Clubs");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
