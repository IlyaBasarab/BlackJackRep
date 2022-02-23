using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class CpuPlayer : Player
    {
        private List<Card> cards = new List<Card>();
        Deck deck;


        public CpuPlayer(Deck deck)
        {
            this.deck = deck;
        }

        public override void GetCard(Card card)
        {
            cards.Add(card);

        }

        public override int GetSum()
        {
            int sum = 0;
            foreach (var card in cards)
            {
                sum += card.GetTitle();
            }
            return sum;
        }

        public override void ShowCards()
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card.GetTitle() + " " + card.GetSuit());
            }
        }


        public int PlayGame()
        {
            int sum = 0;
            bool cpuFlag = true;
            while (cpuFlag)
            {
                if (sum <= 15)
                {
                    Card nextCard= deck.GetNextCard();
                    GetCard(nextCard);
                    sum += nextCard.GetTitle(); 
                }
                else if (sum > 18)
                    cpuFlag = false;



            }
            return sum;
        }
        
    }
}
