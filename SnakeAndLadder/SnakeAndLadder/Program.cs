using System;
//UC3 check Position
namespace SnakeAndLadder
{
    internal class Program
    {
        public const int START = 0;
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;

        static void Main(string[] args)
        {
            //Variables
            int position = 0;
            int newposition = 0;
            int PlayerPosition = 0;

            Random random = new Random();
            int dice = random.Next(0, 7);
            int CheckOption = (random.Next() * 3);

            switch (CheckOption)
            {
                case NO_PLAY:
                    newposition = 0;
                    break;
                case LADDER:
                    newposition = dice;
                    break;
                default:
                case SNAKE:
                    newposition = -dice;
                    break;
            }
            position = position + newposition;
            if (position < 0)
            {
                position = 0;
            }
            Console.WriteLine("position : " + position);

            {
                Console.WriteLine("welcome to Snake And Ladder Programe");
                Console.WriteLine("Starting Position is " + PlayerPosition);
                Console.WriteLine("Dice roll: " + dice);
            }
        }
    }
}
