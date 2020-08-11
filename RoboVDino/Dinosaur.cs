using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Dinosaur
    {
        public string dinoName = "";
        public int dinoHealth = 0;
        public int energy = 0;
        public int attackPower = 0;

        public Dinosaur(string dinoName, int dinoHealth, int energy, int attackPower)
        {
            this.dinoName = dinoName;
            this.dinoHealth = dinoHealth;
            this.energy = energy;
            this.attackPower = attackPower;
        }
        public void Attack(Robot robot)
        {
            robot.roboHealth -= attackPower;
            energy--;
            Console.WriteLine("The health of "+robot.roboName+" is "+robot.roboHealth+" HP.");
            Console.ReadLine();
        }
    }
}
