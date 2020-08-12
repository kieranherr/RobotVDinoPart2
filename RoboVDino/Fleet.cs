using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Fleet
    {

        public Weapon weapon = new Weapon();
        Robot Terminator;
        Robot RoboCop;
        Robot C3;
        public List<Robot> robots;
        public Fleet()
        {
            
            Terminator = new Robot("Terminator", 7, 200, weapon);
            RoboCop = new Robot("RoboCop", 10, 150, weapon);
            C3 = new Robot("C3", 12, 100, weapon);
            robots = new List<Robot>(); 
            robots.Add(Terminator);
            robots.Add(RoboCop);
            robots.Add(C3);
        }

    }
}
