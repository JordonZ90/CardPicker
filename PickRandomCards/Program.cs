using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            CardGame();
        }
        public static void CardGame()
        {
            Console.Write("Enter the number of cards to pick: ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
                // The foreach executes CWL(card) for each element in the array returned by PickSomeCards
            }
            else
            {
                Console.WriteLine("Please enter a valid number ");
                CardGame();
            }
        }
    }
}
