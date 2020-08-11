using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Robot
    {
        public string roboName = "";
        public int energy = 0;
        public int roboHealth = 0;
        Weapon weapon;
        public Robot(string roboName, int energy, int roboHealth, Weapon weapon)
        {
            this.roboName = roboName;
            this.energy = energy;
            this.roboHealth = roboHealth;
            this.weapon = weapon;
        }
        public int PassRoboHealth()
        {
            return roboHealth;
        }
    }
}
