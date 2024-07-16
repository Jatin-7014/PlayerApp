using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Models
{
    internal class Player
    {
        static int MIN_AGE = 18;
        public int Id { get; }
        public string Name { get; }
        public int Age { get; } = MIN_AGE;

        public Player(int id,string name) 
        {
            Id = id;
            Name = name;
        }
        public Player(int id, string name,int age):this(id,name)
        {
            Age = age;
        }

        public override string ToString()
        {
            return $"Name:{Name}\nAge:{Age}\nId:{Id}\n";
        }

        public static Player WhoIsElder(Player[] players)
        {
            int maxAge = MIN_AGE;
            Player eldestPlayer = null;
            foreach (Player player in players)
            {
                if (player.Age > maxAge)
                {
                    maxAge = player.Age;
                    eldestPlayer = player;
                }
            }
            return eldestPlayer;
        }
    }
}
