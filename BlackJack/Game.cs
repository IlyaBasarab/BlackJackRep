using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Game
    {
        Deck deck = new Deck();

        HumanPlayer human = new HumanPlayer("player");
        bool humanFlag= true;

        

        public void Start()
        {
            Console.WriteLine("BalackJack STARTS" + '\n');

            human.GetCard(deck.GetNextCard());
            human.ShowCards();
            int hSum = human.GetSum();
            Console.WriteLine("You have:  "+ hSum + '\n');
            while (humanFlag)
            {
                Console.WriteLine("Do you need more cards? \n "
                    +"1. Get card \n" +
                    "2. Stop");

                int value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if (value == 1)
                {
                    human.GetCard(deck.GetNextCard());
                    human.ShowCards();
                    hSum= human.GetSum();
                    Console.WriteLine("You have:  " + hSum + '\n');
                }
                else if (value == 2)
                {

                    Console.WriteLine("\n Dealer turn \n");
                    humanFlag= false;
                }
            }

            CpuPlayer cpuPlayer = new CpuPlayer(deck);
            int cpuSum = cpuPlayer.PlayGame();
            Console.WriteLine("Dealer have: " + cpuSum);


            if (hSum > cpuSum && hSum < 22|| cpuSum>21)
                Console.WriteLine("You win!");
            else if (hSum < cpuSum && hSum < 22)
                Console.WriteLine("You loose!  Dealer got: "+ cpuSum);
            else if (hSum==cpuSum&& hSum<22&& cpuSum<22|| hSum>21&& cpuSum >21)
                Console.WriteLine("Draw!"); 



        }


    }
}
