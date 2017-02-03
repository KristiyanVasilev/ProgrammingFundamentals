namespace HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HandsOfCards
    {
        static void Main()
        {
            var input = "";
            var totalCards = new Dictionary<string, string>();
            while (input != "JOKER")
            {
                input = Console.ReadLine();
                var cardsRow = input
                    .Split(new char[] { ':', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                for (int i = 1; i < cardsRow.Count; i++)
                {
                    var playerName = cardsRow[0];
                    var currentCard = cardsRow[i];
                    if (!totalCards.ContainsKey(playerName))
                    {
                        totalCards[playerName] = currentCard;
                        
                    }
                    else if (!totalCards[playerName].Contains(currentCard))
                    {
                        totalCards[playerName] += currentCard + " ";
                    }
                }
            }
            var cardRow = new List<string>();
            foreach (var row in totalCards.Values)
            {
                cardRow.Add(row);
            }


        }
        public static int Sum(char num1, char num2)
        {
            int firstNumber = 0;
            int secondNumber = 0;                    
            switch (num1)
            {
                case '2':
                    firstNumber = 2;
                    break;
                case '3':
                    firstNumber = 3;
                    break;
                case '4':
                    firstNumber = 4;
                    break;
                case '5':
                    firstNumber = 5;
                    break;
                case '6':
                    firstNumber = 6;
                    break;
                case '7':
                    firstNumber = 7;
                    break;
                case '8':
                    firstNumber = 8;
                    break;
                case '9':
                    firstNumber = 9;
                    break;
                case '1':
                    firstNumber = 10;
                    break;
                case 'J':
                    firstNumber = 11;
                    break;
                case 'D':
                    firstNumber = 12;
                    break;
                case 'K':
                    firstNumber = 13;
                    break;
                case 'A':
                    firstNumber = 14;
                    break;
            }

            switch (num2)
            {

                case 'S':
                    secondNumber = 4;
                    break;
                case 'H':
                    secondNumber = 3;
                    break;
                case 'D':
                    secondNumber = 2;
                    break;
                case 'C':
                    secondNumber = 1;
                    break;               
            }
            int result = firstNumber * secondNumber;
            return result;
        }
    }
}
