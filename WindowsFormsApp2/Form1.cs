using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //Scene number and track where person is at
        int scene = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int lakeoptions

            Random randgen = new Random();
            lakeoptions = randgen.Next(1, 11);

            if (e.KeyCode == Keys.M)       //red button press
            {
               if (scene == 33)
                {
                    this.Close();
                }


                if (scene == 0) 
                {
                    scene = 1;
                }

                if (scene == 1)
                {
                    scene = 15;
                }

            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 33)
                {
                    scene = 0;
                }

                if (scene == 0)
                {
                    scene = 9;
                }

                if (scene == 1)
                {
                    if (lakeoptions == 1)
                    {
                        scene = 2;
                    }
                    else
                    {
                        scene = 3;
                    }
                }
            }
            else if (e.KeyCode == Keys.Space) //green button press
            {
                if (scene == 0)
                {
                    scene = 4;
                }

                if (scene == 2 || scene ==15)
                {
                    scene = 33;
                }
            }

            //shows options and text based on what scene you are on
            switch (scene)
            {
                case 0:  //start scene 
                    outputLabel.Text = "It is Friday the 13th of October, 1980 You decide to go camping with your friends, Ethan, Jacob, and Ryan. You guys realize that you're the only ones there at the camp. You decide a place to start setting up. Ethan starts building the tent, Jacob goes to the lake to get some water, and Ryan goes to find some fire wood. What do you want to do? ";
                    blueLabel.Text = "Help Ethan with the tent";
                    redLabel.Text = "Help Jacob grab some water";
                    greenLabel.Text = "Help Ryan find some fire wood";
                    break;
                case 1:
                    outputLabel.Text = "You catch up to Jacob and help him out grab some water but as you do you see some ripples in the distance. You ask yourself if you should check out what it could be";
                    blueLabel.Text = "Check it out";
                    redLabel.Text = "Ignore it";
                    greenLabel.Text = "";
                    break;
                case 2:
                    outputLabel.Text = "You look closer into the water and Jason grabs you and drowns you";
                    greenLabel.Text = "Continue";
                    redLabel.Text = "";
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:

                    break;
                case 12:

                    break;
                case 13:

                    break;
                case 14:

                    break;
                case 15:
                    outputLabel.Text = "You ignore the ripples. You see that Jacob is taking forever collecting water so you start heading back. As you do your leg gets caught in a bear trap. You scream for help but no one hears you. Jason approches you with his machete and decapitates you.";
                    greenLabel.Text = "Continue";
                    redLabel.Text = "";
                    break;
                case 16:

                    break;
                case 17:

                    break;
                case 18:

                    break;
                case 19:

                    break;
                case 20:

                    break;
                case 21:

                    break;
                case 22:

                    break;
                case 23:

                    break;
                case 24:

                    break;
                case 25:

                    break;
                case 26:

                    break;
                case 27:

                    break;
                case 28:

                    break;
                case 29:

                    break;
                case 30:

                    break;
                case 31:

                    break;
                case 32:

                    break;
                case 33:
                    outputLabel.Text = "You Died\n Want to play again?";
                    blueLabel.Text = "Yes";
                    redLabel.Text = "No";
                    break;
                case 34:

                    break;
                case 35:

                    break;



            }
        }
    }
}
