using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oskar_Polymorfism
{
    class Player
    {
        public virtual void Attack()
        {
            Console.WriteLine("A Player attacks!");
        }
    }
    //test test
    class Mage : Player
    {
        public override void Attack()
        {
            Console.WriteLine("A Mage attacks with a fireball!");
        }
    }

    class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("A Warrior attacks with a sword!");
        }
    }
    //testing
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player());
            players.Add(new Mage());
            players.Add(new Warrior());

            foreach (Player p in players)
            {
                p.Attack();
            }
            Console.ReadKey();
        }
    }
}
