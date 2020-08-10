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
        public int attackPower = 0;
        Weapon weapon;
        public Robot(string roboName, int energy, int attackPower, Weapon weapon)
        {
            this.roboName = roboName;
            this.energy = energy;
            this.attackPower = attackPower;
            this.weapon = weapon;
        }
    }
}
