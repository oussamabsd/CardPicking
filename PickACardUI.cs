using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPicking
{
    
    class PickACardUI
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int nbr = random.Next(1, 5);
            if (nbr == 1) return "Spades";
            if (nbr == 2) return "Hearts";
            if (nbr == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int nbr = random.Next(1, 14);
            if (nbr == 1) return "Ace";
            if (nbr == 11) return "Jack";
            if (nbr == 12) return "Queen";
            if (nbr == 13) return "King";
            return nbr.ToString();
        }
    }
}
