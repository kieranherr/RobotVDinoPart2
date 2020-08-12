using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Battlefield
    {
        public Fleet fleet = new Fleet();
        public Herd herd = new Herd();

        public void PlayGame()
        {
            //fleet.robots[0].Attack(herd.dinosaurs[0]);
            //herd.dinosaurs[0].Attack(fleet.robots[0]);







            while (fleet.robots.Count > 0 || herd.dinosaurs.Count > 0)
            {
                while (fleet.robots[0].roboHealth > 0 || herd.dinosaurs[0].dinoHealth > 0)
                {

                    fleet.robots[0].Attack(herd.dinosaurs[0]);
                    herd.dinosaurs[0].Attack(fleet.robots[0]);
                }
                if (herd.dinosaurs[0].dinoHealth == 0 && fleet.robots[0].roboHealth > 0)
                {
                    herd.dinosaurs.RemoveAt(0);
                    Console.WriteLine(fleet.robots[0].roboName + " won this match!");
                    Console.ReadLine();
                }
                else
                {
                    fleet.robots.RemoveAt(0);
                    Console.WriteLine(herd.dinosaurs[0].dinoName + " won this match!");
                    Console.ReadLine();
                }
            }
            
        }
    }
}