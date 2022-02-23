using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        private List<Card> cards = new List<Card>(52);
        int indx = 0;
        public Deck()
        {
            AddCards();
            ShuffleCards();

        }

        public void AddCards()
        {
            for (int i = 0; i < 52; i++)
            {
                cards.Add( new Card(8 + i));
                
            }
        }

        public void ShuffleCards()
        {

            Random rand = new Random();

            for (int i = 0; i < cards.Count; i++)
            {
                int idx1 = i;
                int idx2 = rand.Next(0, cards.Count);

                Card temp = cards[idx1];
                cards[idx1] = cards[idx2];
                cards[idx2] = temp;
            }

            for (int i = 0; i < cards.Count; i++)
            {
                //Console.WriteLine(numbers[i]);

                Card num = cards[i];

                //Console.WriteLine(num.GetTitle() + " " + num.GetSuit());

            }

        }

        public void DeleteCard(int indx)
        {
            cards.RemoveAt(indx);

        }

        public Card GetNextCard()
        {
            if(indx<cards.Count)
            {
                Card card = cards[0];
                DeleteCard(0);
                
                return card;
            } 
            

            return null;
        }



    }
}
