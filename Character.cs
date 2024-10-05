using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateZombieSchoolSuvival
{
    internal class Character
    {
        public string Name;

        public int Health;

        public int Power;

        public Character(string Name, int Health, int Power) 
        {
            /*
            Debug.Log("Name:" + Name);
            Debug.Log("Power:" + Power);
            Debug.log("Healtth:" + Health);
            */

            this.Name = Name;
            this.Health = Health;
            this.Power = Power;

        }
        
         
    }
}
     