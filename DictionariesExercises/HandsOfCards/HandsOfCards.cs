namespace HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HandsOfCards
    {
        static void Main()
        {            
            var cardPowers = GetCardPower();
            var cardTypes = GetCardType();
            var cards = new Dictionary<string, HashSet<int>>();
            var input = Console.ReadLine();

            while (input != "JOKER")
            {
                var tokens = input.Split(':');
                var name = tokens[0];
                var playerCards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);
                    var sum = cardPowers[cardPower] * cardTypes[cardType];

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }
                    cards[name].Add(sum);
                }
                input = Console.ReadLine();
            }
            
            foreach (var pair in cards)
            {
                var name = pair.Key;
                var cardsSum = pair.Value.Sum();
                Console.WriteLine($"{name}: {cardsSum}");
            }
        }

        public static Dictionary<string, int> GetCardType()
        {
            var cardType = new Dictionary<string, int>();
            cardType["S"] = 4;
            cardType["H"] = 3;
            cardType["D"] = 2;
            cardType["C"] = 1;
            return cardType;
        }

        public static Dictionary<string, int> GetCardPower()
        {
            var powers = new Dictionary<string, int>();
            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;
            }
            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;
            return powers;
        }
    }
}
