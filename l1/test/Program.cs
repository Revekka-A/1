using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        public string Name { get; set; } // имя
        public int Number { get; set; } // номер
    }
    class Team
    {
        Player[] players = new Player[12];

        public Player this[int index]
        {
            get { return players[index]; }
            set { players[index] = value; }
        }
    }
    class Programm
    {
        static void Main()
        {
            Team players = new Team();
            players[0] = new Player { Name = "Tom", Number = 0 };
            players[1] = new Player { Name = "Bob", Number = 1 };
            players[2] = new Player { Name = "Karl", Number = 2 };

            players[3] = new Player { Name = "Alex", Number = 3 };

            players[4] = new Player { Name = "Terr", Number = 4 };

            players[5] = new Player { Name = "Carr", Number = 5 };

            players[6] = new Player { Name = "Steven", Number = 6 };
            players[7] = new Player { Name = "Sasha", Number = 7 };
            players[8] = new Player { Name = "Evgen", Number = 8 };
            players[9] = new Player { Name = "Sam", Number = 9 };
            players[10] = new Player { Name = "Will", Number = 10 };
            players[11] = new Player { Name = "Karler", Number = 11 };



            Console.WriteLine(players[0].Name + "," + players[0].Number);
            Console.WriteLine(players[1].Name + "," + players[1].Number);
            Console.WriteLine(players[2].Name + "," + players[2].Number);
            Console.WriteLine(players[3].Name + "," + players[3].Number);
            Console.WriteLine(players[4].Name + "," + players[4].Number);
            Console.WriteLine(players[5].Name + "," + players[5].Number);
            Console.WriteLine(players[6].Name + "," + players[6].Number);
            Console.WriteLine(players[7].Name + "," + players[7].Number);
            Console.WriteLine(players[8].Name + "," + players[8].Number);
            Console.WriteLine(players[9].Name + "," + players[9].Number);
            Console.WriteLine(players[10].Name + "," + players[10].Number);
            Console.WriteLine(players[11].Name + "," + players[11].Number);


            Console.ReadLine();
        }


    }
}