using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //Scene number and track where person is at
        int scene = 0;

        SoundPlayer player = new SoundPlayer(Properties.Resources.DeathSound);
        SoundPlayer crickets = new SoundPlayer(Properties.Resources.crickets);
        SoundPlayer evilLaugh = new SoundPlayer(Properties.Resources.Evil_Laugh);
        SoundPlayer Cheering = new SoundPlayer(Properties.Resources.Crowd_Cheering);
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "It is Friday the 13th of October, 1980 You decide to go camping with your friends, Ethan, Jacob, and Ryan. You guys realize that you're the only ones there at the camp. You decide a place to start setting up. Ethan starts building the tent, Jacob goes to the lake to get some water, and Ryan goes to find some fire wood. What do you want to do? ";
            blueLabel.Text = "Help Ethan with the tent";
            redLabel.Text = "Help Jacob grab some water";
            greenLabel.Text = "Help Ryan find some fire wood";
            imageBox.BackgroundImage = Properties.Resources.Sign;
            crickets.Play();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int lakeoptions;
            int cabinoptions;

            Random randgen = new Random();
            lakeoptions = randgen.Next(1, 6);
            cabinoptions = randgen.Next(1, 3);

            if (e.KeyCode == Keys.M)       //red button press
            {///////////////////////////////////////////////////
                if (scene == 33 || scene == 34)
                {
                    scene = 99;
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
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    scene = 8;
                }
                else if (scene == 9)
                {
                    scene = 26;
                }
                else if (scene == 26)
                {
                    scene = 32;
                }
                else if (scene == 25 || scene == 27)
                {
                    scene = 35;
                }
                else if (scene == 28)
                {
                    scene = 30;
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
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 9)
                {
                    scene = 25;
                }
                else if (scene == 26)
                {
                    scene = 31;
                }
                else if (scene == 25)
                {
                    scene = 27;
                }
                else if (scene == 27)
                {
                    scene = 28;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
            }////////////////////////////////////////////////////
            else if (e.KeyCode == Keys.Space) //green button press
            {////////////////////////////////////////////////////
                if (scene == 0)
                {
                    scene = 4;
                }
               else if (scene == 2 || scene ==15 || scene == 36 || scene == 10 || scene == 13 || scene == 17 || scene == 22 || scene == 19 || scene == 24 || scene == 7 || scene == 31 || scene == 32 || scene == 30)
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
                else if (scene == 23 || scene == 20 || scene == 29)
                {
                    scene = 34;
                }
                else if (scene == 6 || scene == 8)
                {
                    scene = 35;
                }
            }//////////////////////////////////////////////////////

            if (e.KeyCode != Keys.M && e.KeyCode != Keys.B && e.KeyCode != Keys.Space)
            {
                return;
            }

            //shows options and text based on what scene you are on
            switch (scene)
            {
                case 0:  //start scene 
                    evilLaugh.Stop();
                    Cheering.Stop();
                    outputLabel.Text = "It is Friday the 13th of October, 1980 You decide to go camping with your friends, Ethan, Jacob, and Ryan. You guys realize that you're the only ones there at the camp. You decide a place to start setting up. Ethan starts building the tent, Jacob goes to the lake to get some water, and Ryan goes to find some fire wood. What do you want to do? ";
                    blueLabel.Text = "Help Ethan with the tent";
                    redLabel.Text = "Help Jacob grab some water";
                    greenLabel.Text = "Help Ryan find some fire wood";
                    imageBox.BackgroundImage = Properties.Resources.Sign;
                    crickets.Play();
                    break;
                case 1:
                    crickets.Stop();
                    outputLabel.Text = "You catch up to Jacob and help him out by grabbing some water but as you do you see some ripples in the distance. You ask yourself if you should check out what it could be.";
                    blueLabel.Text = "Check it out";
                    redLabel.Text = "Ignore it";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.Ripples;
                    break;
                case 2:
                    outputLabel.Text = "You look closer into the water and Jason grabs you and drowns you.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Drowned;
                    break;
                case 3:
                    outputLabel.Text = "As you look closer, a fish jumps out. You decide to take the fish with you later for dinner. You can't hold onto the fish very well so you decide to run back to the camp before Jacob.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Fish;
                    break;
                case 4:
                    crickets.Stop();
                    outputLabel.Text = "You catch up to Ryan and start helping him find some firewood. While you do, you see something shining in the distance.";
                    blueLabel.Text = "Go check what it is";
                    redLabel.Text = "Ignore it";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.firewood;
                    break;
                case 5:
                    outputLabel.Text = "As you get closer, you realize its a hockey mask.";
                    blueLabel.Text = "Take it to show your friends";
                    redLabel.Text = "Leave it where you found it";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.JasonMaskjpg;
                    break;
                case 6:
                    outputLabel.Text = "You decide to ignore it head back to the tent since your arms were full of firewood.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Tent;
                    break;
                case 7:
                    outputLabel.Text = "You pick up the mask and turn around where Jason is standing with his machete. He cuts off your arm and takes the mask with him. You fall to the ground and bleed to death.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.BagHeadJason;
                    break;
                case 8:
                    outputLabel.Text = "You decide to leave it there since its not yours and head back to the tent since Ryan was taking too long finding enough firewood.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Tent;
                    break;
                case 9:
                    crickets.Stop();
                    outputLabel.Text = "You stay with Ethan and help him set up the tent. While you do, you spot a cabin in the distance.";
                    blueLabel.Text = "Check it out";
                    redLabel.Text = "Stay with Ethan";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.Cabin;
                    break;
                case 10:
                    outputLabel.Text = "You panic and start running. You are running out of breath and when you turn around, a machete flies into your chest.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 11:
                    outputLabel.Text = "You turn on your phone and realize that there is no internet. You look around and spot a cabin in the distance.";
                    blueLabel.Text = "Search Cabin";
                    redLabel.Text = "Run";
                    greenLabel.Text = "Look for Jacob or Ryan";
                    imageBox.BackgroundImage = Properties.Resources.Phone;
                    break;
                case 12:
                    outputLabel.Text = "You look through the cabin for anything useful and find a hatchet and a LAN line. You look out the window and see Jason looking for you.";
                    blueLabel.Text = "Fight Jason with the hatchet";
                    redLabel.Text = "Call 911 with the LAN line";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.HatchetandLAN;
                    break;
                case 13:
                    outputLabel.Text = "You find Jason outside and whack him in the head. The hatchet gets stuck on his head but it seems to have no effect on him. Jason rips the hatchet off his head and hits you with it through the skull.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.HeadwithHatchet;
                    break;
                case 14:
                    outputLabel.Text = "You call the cops and tell them about the trouble you are in. They tell you they will arrive at the camp in 5 minutes. After you put down the phone, Jason starts breaking the windows in your cabin.";
                    blueLabel.Text = "Hide somewhere in the cabin";
                    redLabel.Text = "Search the cabin more incase you missed something";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources._911;
                    break;
                case 15:
                    outputLabel.Text = "You ignore the ripples. You see that Jacob is taking forever collecting water so you start heading back. As you do your leg gets caught in a bear trap. You scream for help but no one hears you. Jason approches you with his machete and decapitates you.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Beartrap;
                    break;
                case 16:
                    outputLabel.Text = "You see a empty cabinet near by so you decide to jump in but while you are hiding inside you hear Jacob yelling your name as if he was searching for you.";
                    blueLabel.Text = "Stay hidden in the cabinet";
                    redLabel.Text = "Go outside to warn Jacob about Jason";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.Yelling;
                    break;
                case 17:
                    outputLabel.Text = "You look around and find nothing. Jason breaks through the door and chokes you.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.choking;
                    break;
                case 18:
                    outputLabel.Text = "You decide to stay hidden and hear Jacob being killed outside.";
                    blueLabel.Text = "Make a run";
                    redLabel.Text = "Stay hidden";
                    greenLabel.Text = "";
                    player.Play();
                    break;
                case 19:
                    outputLabel.Text = "You jump out of the cabinet and run to outside to go warn Jacob but then your foot gets stuck in a bear trap right in front of the door. Jason kills Jacob in front of you, then grabs you and burns you alive in the fireplace located inside the cabin.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Fireplace;
                    break;
                case 20:
                    player.Stop();
                    outputLabel.Text = "You start running while Jason is distracted. You find your way to the cops and they escort you to safety. Ryan was never found.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Cops;
                    break;
                case 21:
                    outputLabel.Text = "You look around and find a fully loaded pump shotgun underneath a table.";
                    blueLabel.Text = "Hide somewhere";
                    redLabel.Text = "Go fight Jason";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.shotgun;
                    break;
                case 22:
                    outputLabel.Text = "You look for a hiding spot but its too late. Jason breaks through and stabs you in the stomach with his machete.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 23:
                    outputLabel.Text = "You shoot Jason in the head which stuns him. This gives you enough time to make a run and you manage to run right into the cops. They escort you to safety. Jacob and Ryan are later found by the cops.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Cops;
                    break;
                case 24:
                    player.Stop();
                    outputLabel.Text = "You decide to stay hidden but you start getting nervous. Jason hears you breathing heavily and lunges at the cabinet with his machete. It pierces thourght your neck.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 25:
                    outputLabel.Text = "You see a car parked outside of the cabin. Inside the cabin you find some fuel and the car keys to the car but you can't use it since it doesn't have a battery.";
                    blueLabel.Text = "Go search for the battery";
                    redLabel.Text = "Head back to the tent";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.GasandKeys;
                    break;
                case 26:
                    outputLabel.Text = "You stay with Ethan since the cabin doesn't belong to you. Out of no where, you here Ryan yelling for help.";
                    blueLabel.Text = "Stay at the tent";
                    redLabel.Text = "Go find Ryan";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.Yelling;
                    break;
                case 27:
                    outputLabel.Text = "You search the cabin even more but don't find the battery. As you look out the window, you spot a different cabin in the distance.";
                    blueLabel.Text = "Check the other cabin";
                    redLabel.Text = "Head back to the tent";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.Cabin;
                    break;
                case 28:
                    outputLabel.Text = "You search the new cabin and find the battery and decide to head back to the car. When you arrive, you see Ethan hung up to the first cabin you found yelling for help.";
                    blueLabel.Text = "Drive away";
                    redLabel.Text = "Help Ethan";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.Hung;
                    break;
                case 29:
                    outputLabel.Text = "You decide to quickly get in the car, leave Ethan to die, and drive away to safety. Jacob and Ryan were never found.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.car;
                    break;
                case 30:
                    outputLabel.Text = "You help Ethan by getting him on the ground as you do, Jason grabs on to you and hangs you up instead. Ethan takes the battery, fuel, and car keys then ditches you and drives away. You run out of oxygen and suffocate.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    player.Play();
                    break;
                case 31:
                    outputLabel.Text = "Ethan thinks you are scared so he goes by himself looking for Ryan. While you watch him go, Jason sneaks up behind you and stabs you in the spine.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 32:
                    outputLabel.Text = "You go on the search for Ryan but instead fall into a ditch that was camouflaged by the leaves. You look up and see Jason standing there and he throws his machete right into your lungs.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 33:
                    player.Stop();
                    outputLabel.Text = "You Died.\nWant to play again?";
                    blueLabel.Text = "Yes";
                    redLabel.Text = "No";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.Deathjpeg;
                    evilLaugh.Play();
                    break;
                case 34:
                    outputLabel.Text = "You escaped!\nWant to play again?";
                    blueLabel.Text = "Yes";
                    redLabel.Text = "No";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.YouEscaped;
                    Cheering.Play();
                    break;
                case 35:
                    outputLabel.Text = "As you rush back out of breath you call for Ethan but he doesn't answer. You think he's pulling a prank on you but when you check the tent you see his dead body.";
                    blueLabel.Text = "Call 911";
                    redLabel.Text = "Run";
                    greenLabel.Text = "Look for Jacob or Ryan";
                    imageBox.BackgroundImage = Properties.Resources.DeadBody;
                    break;
                case 36:
                    outputLabel.Text = "As you go on the search for your friends, your leg falls into a beartrap. You start yelling but no one hears you. Jason approaches you and decapitates you.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Continue";
                    imageBox.BackgroundImage = Properties.Resources.Beartrap;
                    break;
                case 99:
                    evilLaugh.Stop();
                    Cheering.Stop();
                    outputLabel.Text = "Thank you for playing.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.ThankYou;
                    Refresh();
                    Thread.Sleep(2500);
                    this.Close();
                    break;
            }
        }
    }
}
