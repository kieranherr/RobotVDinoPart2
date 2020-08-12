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
        Dinosaur Velo;
        Dinosaur Tri;
        Dinosaur Indo;
        public List<Dinosaur> dinosaurs;
        public Herd()
        {
            
            Velo = new Dinosaur("Velociraptor", 100, 12, weapon);
            Tri = new Dinosaur("Triceratops", 150, 7, weapon);
            Indo = new Dinosaur("Indominus Rex", 200, 5, weapon);
            dinosaurs = new List<Dinosaur>();
            dinosaurs.Add(Velo);
            dinosaurs.Add(Tri);
            dinosaurs.Add(Indo);
        }
    }
}
