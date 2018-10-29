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

            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) 
                {
                    scene = 1;
                }

            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {

            }
            else if (e.KeyCode == Keys.Space) //green button press
            {

            }

            //shows options and text based on what scene you are on
            switch (scene)
            {
                case 0:  //start scene 
                    outputLabel.Text = "It is Friday the 13th of October, 1980 You decide to go camping with your friends ";
                    break;
                case 1:

                    break;
                case 2:

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

                    break;
                case 34:

                    break;



            }
        }
    }
}
