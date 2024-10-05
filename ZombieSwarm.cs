using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateZombieSchoolSuvival
{
    internal class ZombieSwarm : Zombie
    {
        private List<Zombie> zombies;

        public ZombieSwarm()
        {
            zombies = new List<Zombie>();
        }

        public void AddZombie(Zombie zombie) 
        {
            zombies.Add(zombie);

        }

        public void Display()
        {
            foreach (Zombie zombie in zombies)
            {
                Console.WriteLine(zombie.Name);
            }
        }


    }
}
