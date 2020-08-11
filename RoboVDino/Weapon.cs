using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVDino
{
    class Weapon
    {
        private int[] attackMovesRobo;
        public int[] attackMovesDino;

        public Weapon()
        {
            attackMovesDino = new int[5] { 12, 15,20, 15, 10};
            attackMovesRobo = new int[5] { 20, 15, 25, 10, 30};
        }
        public int ChooseAttackDino()
        {
            Console.WriteLine("What move would you like this Dinosaur to perform?");
            Console.WriteLine("1: Bite");
            Console.WriteLine("2: Triple Swipe");
            Console.WriteLine("3: Stomp");
            Console.WriteLine("4: Tail Whip");
            Console.WriteLine("5: Headbutt");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;
            switch (choice)
            {
                case 0:
                    Console.WriteLine("You chose Bite!");
                    break;
                case 1:
                    Console.WriteLine("You chose Triple Swipe!");
                    break;
                case 2:
                    Console.WriteLine("You chose Stomp!");
                    break;
                case 3:
                    Console.WriteLine("You chose Tail Whip!");
                    break;
                case 4:
                    Console.WriteLine("You chose Headbutt!");
                    break;
                default:
                    Console.WriteLine("Please choose from one of the listed attacks!");
                    Console.WriteLine("1 = Bite, 2 = Triple Swipe, 3 = Stomp, 4 = Tail Whip, 5 = Headbutt.");
                    break;
            }
            return attackMovesDino[choice];
        }
        public int ChooseAttackRobo()
        {
            Console.WriteLine("What move would you like this Robot to perform?");
            Console.WriteLine("1: P90");
            Console.WriteLine("2: Exaclibur Sword");
            Console.WriteLine("3: Flame Thrower");
            Console.WriteLine("4: Nun Chucks");
            Console.WriteLine("5: Sawed Off Shotgun");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;
            switch (choice)
            {
                case 0:
                    Console.WriteLine("You chose the P90!");
                    break;
                case 1:
                    Console.WriteLine("You chose the Excalibur Sword!");
                    break;
                case 2:
                    Console.WriteLine("You chose the Flame Thrower!");
                    break;
                case 3:
                    Console.WriteLine("You chose the Nun Chucks!");
                    break;
                case 4:
                    Console.WriteLine("You chose the Sawed Off Shotgun!");
                    break;
                default:
                    Console.WriteLine("Please choose from one of the listed attacks!");
                    Console.WriteLine("1 = P90, 2 = Excalibur Sword, 3 = Flame Thrower, 4 = Nun Chucks, 5 = Sawed Off Shotgun.");
                    break;
            }
            return attackMovesRobo[choice];
        }
    }
}
