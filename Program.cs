using System;
using PlayerApp.Models;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[] {new Player(101,"Jatin",22),
                new Player(102,"Anil"),
                new Player(103,"Saroj",23),
                new Player(104,"XyZ"),
                new Player(105,"ABC",30)};

            Player Eldest=Player.WhoIsElder(players);
            Console.WriteLine("===========Eldest Player===========");
            Console.WriteLine(Eldest);
        }
    }
}
