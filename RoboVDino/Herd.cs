using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Herd
    {
        public Weapon weapon = new Weapon();
        public Dinosaur dino1;
        public Dinosaur dino2;
        public Dinosaur dino3;
        public Herd()
        {
            dino1 = new Dinosaur("PlaceHolder", 0, 0, 0);
            dino2 = new Dinosaur("PlaceHolder", 0, 0, 0);
            dino3 = new Dinosaur("PlaceHolder", 0, 0, 0);
        }
    }
}
