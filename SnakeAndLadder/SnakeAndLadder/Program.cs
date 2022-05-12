using System;
//UC1 StartPosition
namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PlayerPosition = 0;
            Random random = new Random();
            int die = random.Next(1, 7);
            {
                Console.WriteLine("welcome to Snake And Ladder Programe");
                Console.WriteLine("Starting Position is " + PlayerPosition);
                Console.WriteLine("Dice roll: " + die);
            }
        }
    }
}
