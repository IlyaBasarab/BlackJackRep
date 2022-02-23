using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public int number;
        public Card(int num)
        {
            number = num;
        }

        public int GetTitle()
        {
            return number / 4;
        }

        public int GetSuit()
        {
            return number % 4;
        }
    }
}
