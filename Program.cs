using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human player1=new Human("player1");
            Human player2 = new Human("player2");

            player1.attack(player2);
            Console.WriteLine(player2.ToString());
            Console.WriteLine(player1.ToString());
            player1.attack("sss");
        }
    }
}
