using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class HumanPlayer:Player
    {

        private List<Card> cards = new List<Card>();

        public string name;

        public HumanPlayer(string name)
        {
            this.name = name;
        }


        public override void GetCard(Card card)
        {
            cards.Add(card);

        }


        public override void ShowCards()
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card.GetTitle() + " " + card.GetSuit());
            }
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
    }
}
