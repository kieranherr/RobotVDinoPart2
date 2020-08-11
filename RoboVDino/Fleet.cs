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
        public Robot Terminator;
        public Robot RoboCop;
        public Robot C3;
        public Fleet()
        {
            Terminator = new Robot("Terminator", 200, 7, weapon);
            RoboCop = new Robot("RoboCop", 150, 10, weapon);
            C3 = new Robot("C3", 100, 12, weapon);
        }

    }
}
