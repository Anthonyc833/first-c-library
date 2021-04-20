using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_library
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// this sets framworks to make sure it is connsistent so it can not be faulted
        /// </summary>
        private OrganiseG[] game = new OrganiseG[10];
        private OrganiseG SAVEDGAME;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save(object sender, EventArgs e)
        {
         
        }

        private void Savepre_Click(object sender, EventArgs e)
        {
            // establishes the symbol of being a string or a letter
            int NUMid = (int)NUMID.Value;
            string Game = textboxgame.Text;
            string console = textBoxConsole.Text;
            string hardcopy = hc.Text;
            // all details from the OrganiseG class into the form 1 class and then print it
            SAVEDGAME = new OrganiseG((int)NUMid, Game, console, hardcopy);
            SAVEDGAME.Print();
            

        }

        // sets the value of set game in the form 1 
        private void setgame()
        {
            SAVEDGAME = new OrganiseG((int)NUMID.Value, textboxgame.Text, textboxgame.Text, HardCopy.Text);
        }

        /* goes through all the data stored the OrganiseG and prints
         * in tandum of there are any other ids with info and prints those aswell*/
        
        private void PrintAllGames()
        {
            Console.WriteLine("printing all games");
            foreach (OrganiseG Game in game)
            {
                if(Game != null)
                {
                    Game.Print();
                }
                else
                {
                    Console.WriteLine("there is nothing on this line");
                }


            }
        }

        // prints the info in OrganiseG and puts it in a view with all id with the code abouve
        private void Arrayview_Click(object sender, EventArgs e)
        {
            SAVEDGAME.setgame();
            game[SAVEDGAME.NUMID] = SAVEDGAME;
            SAVEDGAME.Print();
            if (game[SAVEDGAME.NUMID]!= null)
            {
                return;
            }
            game[SAVEDGAME.NUMID] = SAVEDGAME;
            
        }

        private void arrayveiwing(object sender, EventArgs e)
        {
            SAVEDGAME.setgame();
            game[SAVEDGAME.NUMID] = SAVEDGAME;
            PrintAllGames();
        }
        // prints all the data in organiseG
        private void savinggamelibrary(object sender, EventArgs e)
        {
            int NUMid = (int)NUMID.Value;
            string Game = textboxgame.Text;
            string console = textBoxConsole.Text;
            string hardcopy = hc.Text;

            SAVEDGAME = new OrganiseG((int)NUMid, Game, console, hardcopy);
            SAVEDGAME.Print();

        }
    }

}

