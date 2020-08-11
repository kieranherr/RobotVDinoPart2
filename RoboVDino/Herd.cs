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
        public Dinosaur Velo;
        public Dinosaur Tri;
        public Dinosaur Indo;
        public Herd()
        {
            Velo = new Dinosaur("Velociraptor", 100, 12, weapon);
            Tri = new Dinosaur("Triceratops", 150, 7, weapon);
            Indo = new Dinosaur("Indominus Rex", 200, 5, weapon);
        }
    }
}
