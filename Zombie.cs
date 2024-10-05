using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateZombieSchoolSuvival
{
    internal class Zombie
    {
        public string Name {  get; set; }
        public string Description { get; set; }

        public Position CurrPosition { get; set; }

        public Zombie(string name, string description) 
        { 
            Name = name; Description = description;
        }

        public Zombie() { }
    }
}
