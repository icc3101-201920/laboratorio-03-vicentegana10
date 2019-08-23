using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Console.WriteLine(player1.Id + 1);
            Console.WriteLine(player2.Id + 1);
            Console.ReadKey();
        }
    }
}
