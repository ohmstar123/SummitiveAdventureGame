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
            outputLabel.Text = "It is Friday the 13th of October, 1980 You decide to go camping with your friends, Ethan, Jacob, and Ryan. You guys realize that you're the only ones there at the camp. You decide a place to start setting up. Ethan starts building the tent, Jacob goes to the lake to get some water, and Ryan goes to find some fire wood. What do you want to do? ";
            blueLabel.Text = "Help Ethan with the tent";
            redLabel.Text = "Help Jacob grab some water";
            greenLabel.Text = "Help Ryan find some fire wood";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int lakeoptions;
            int cabinoptions;

            Random randgen = new Random();
            lakeoptions = randgen.Next(1, 11);
            cabinoptions = randgen.Next(1, 3);

            if (e.KeyCode == Keys.M)       //red button press
            {///////////////////////////////////////////////////
                if (scene == 33 || scene == 34)
                {
                    this.Close();
                }
                else if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 15;
                }
                else if (scene == 35 || scene == 11)
                {
                    scene = 10;
                }
                else if (scene == 12)
                {
                    scene = 14;
                }
                else if (scene == 14)
                {
                    if (cabinoptions == 1)
                    {
                        scene = 17;
                    }
                    else if (cabinoptions == 2)
                    {
                        scene = 21;
                    }
                }
                else if (scene == 21)
                {
                    scene = 23;
                }
                else if (scene == 16)
                {
                    scene = 19;
                }
                else if (scene == 18)
                {
                    scene = 24;
                }
            }///////////////////////////////////////////////////
            else if (e.KeyCode == Keys.B)  //blue button press
            {///////////////////////////////////////////////////
                if (scene == 33 || scene == 34)
                {
                    scene = 0;
                }
                else if (scene == 0)
                {
                    scene = 9;
                }
                else if (scene == 1)
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
                else if (scene == 35)
                {
                    scene = 11;
                }
                else if (scene == 11)
                {
                    scene = 12;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 14)
                {
                    scene = 16;
                }
                else if (scene == 21)
                {
                    scene = 22;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 20;
                }

            }////////////////////////////////////////////////////
            else if (e.KeyCode == Keys.Space) //green button press
            {////////////////////////////////////////////////////
                if (scene == 0)
                {
                    scene = 4;
                }
               else if (scene == 2 || scene ==15 || scene == 36 || scene == 10 || scene == 13 || scene == 17 || scene == 22 || scene == 19 || scene == 24)
                {
                    scene = 33;
                }
               else if (scene == 3)
                {
                    scene = 35;
                }
                else if (scene == 35 || scene == 11)
                {
                    scene = 36;
                }
                else if (scene == 23 || scene == 20)
                {
                    scene = 34;
                }
            }//////////////////////////////////////////////////////

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
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    break;
                case 3:
                    outputLabel.Text = "As you look closer, a fish jumps out. You decide to take the fish with you later for dinner. You can't hold onto the fish very well so you decide to run back to the camp before Jacob";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
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
                    outputLabel.Text = "You panic and start running. You are running out of breath and when you turn around, a machete flies into your chest";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    break;
                case 11:
                    outputLabel.Text = "You turn on your phone and realize that there is no internet. You look around and spot a cabin in the distance";
                    blueLabel.Text = "Search Cabin";
                    redLabel.Text = "Run";
                    greenLabel.Text = "Look for Jacob or Ryan";
                    break;
                case 12:

                    break;
                case 13:

                    break;
                case 14:

                    break;
                case 15:
                    outputLabel.Text = "You ignore the ripples. You see that Jacob is taking forever collecting water so you start heading back. As you do your leg gets caught in a bear trap. You scream for help but no one hears you. Jason approches you with his machete and decapitates you.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
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
                    greenLabel.Text = "";
                    break;
                case 34:

                    break;
                case 35:
                    outputLabel.Text = "As you rush back out of breath you call for Ethan but he doesn't answer. You think he's pulling a prank on you but when you check the tent you see his dead body";
                    blueLabel.Text = "Call 911";
                    redLabel.Text = "Run";
                    greenLabel.Text = "Look for Jacob or Ryan";
                    break;
                case 36:
                    outputLabel.Text = "As you go on the search for your friends, your leg falls into a beartrap. You start yelling but no one hears you. Jason approaches you and decapitates you";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    break;



            }
        }
    }
}
