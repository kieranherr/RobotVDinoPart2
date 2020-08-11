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
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.dinoHealth -= weapon.ChooseAttackRobo();
            energy--;
            Console.WriteLine("The health of " + dinosaur.dinoName + " is " + dinosaur.dinoHealth + " HP.");
            Console.ReadLine();
        }
    }
}
