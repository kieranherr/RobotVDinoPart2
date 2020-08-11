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
        public Robot robo1;
        public Robot robo2;
        public Robot robo3;
        public Fleet()
        {

            robo1 = new Robot("PlaceHolder", 0, 0, weapon);
            robo2 = new Robot("PlaceHolder", 0, 0, weapon);
            robo3 = new Robot("PlaceHolder", 0, 0, weapon);
        }
    }
}

