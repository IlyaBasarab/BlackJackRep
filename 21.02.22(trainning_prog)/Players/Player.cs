using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    abstract class Player
    {
        public abstract void GetCard(Card card);
        public abstract void ShowCards();

        public abstract int GetSum();
    }
}
