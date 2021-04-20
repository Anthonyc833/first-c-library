using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_library
{
    class OrganiseG
    {
        // set the array for organisation
        private OrganiseG[] game = new OrganiseG[10];
        private OrganiseG SAVEDGAME;



        public int NUMID { get; set; }
        public string Game { get; set; }
        public string console { get; set; }
        public string HardCopy { get; set; }

       // sets the variablein a get set value  and in a variable

        public OrganiseG(int NUMid, string game, string consoleg, string hardcopy)
        {
            NUMID = NUMid;
            Game = game;
            console = consoleg;
            HardCopy = hardcopy;


        }
        // sets a all values into a method and checks if the id assosiated with the 
        public void setgame()
        {
            SAVEDGAME = new OrganiseG((int)NUMID, Game, console, HardCopy);
        }


        // prints it all to the output board

        public void Print()
        {
            Console.WriteLine("ID" + NUMID);
            Console.WriteLine(Game + " on the " + console);
            Console.WriteLine("IS or Not a Hard Copy: " + HardCopy);

        }

        //Printer everything in the array for the button
        public void PrintAllGames()
        {
           
            Console.WriteLine("printing all games");
            foreach (OrganiseG GAME in game)
            {
                if (GAME != null)
                {
                    GAME.Print();
                }
                else
                {
                    Console.WriteLine("there is nothing on this line");
                }


            }


        }
        private void Arrayview_Click(object sender, EventArgs e)
        {
            SAVEDGAME.setgame();
            game[SAVEDGAME.NUMID] = SAVEDGAME;
            SAVEDGAME.Print();
            if (game[SAVEDGAME.NUMID] != null)
            {
                return;
            }
            game[SAVEDGAME.NUMID] = SAVEDGAME;
            PrintAllGames();
        }
    }
}

