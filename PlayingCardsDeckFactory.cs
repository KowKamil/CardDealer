using CardDealer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CardDealer
{
    public class PlayingCardsDeckFactory : DeckFactory
    {
        private readonly String cardPath = "/CardsImages/";
        private readonly String blackJokerName = "black_joker.png";
        private readonly String redJokerName = "red_joker.png";

        public override Deck MakeDeck()
        {
            IEnumerable<int> ranksTwoToAce = Enumerable.Range(2, 12); 
            IEnumerable<int> frenchSuits = Enumerable.Range(1, 4);

            List<Card> cards = new List<Card>();

            foreach (int rank in ranksTwoToAce)
            {
                foreach (int suit in frenchSuits)
                {
                    cards.Add(new FrenchPlayingCard((FrenchPlayingCard.Suits)suit, rank, cardResourceName(cardPath, rank, suit)));
                }
            }

            cards.Add(new FrenchPlayingCard(FrenchPlayingCard.Suits.Misc, 15, cardResourceName(cardPath, blackJokerName))); //black joker
            cards.Add(new FrenchPlayingCard(FrenchPlayingCard.Suits.Misc, 15, cardResourceName(cardPath, redJokerName))); //red joker

            return new Deck(cards);
        }

        private String cardResourceName(string prefix, string cardString)
        {
            return prefix + cardString;
        }

        private String cardResourceName(string prefix, int cardRank, int cardSuit)
        {
            return prefix + $"{cardRank}_{cardSuit}.png";
        }

    }
}
