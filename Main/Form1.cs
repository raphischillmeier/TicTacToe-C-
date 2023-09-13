using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int playerOne = 1;
        int playerTwo = 0;
        int i = 0;

        public void changePlayer()
        {
            Console.WriteLine(playerTwo);
            if ( i == 1)
            {
                playerOne = 0;
                playerTwo = 1;
            }
            else
            {
                playerOne = 1;
                playerTwo = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playerOne ==1 )
            {
                button1.Text = "O";
                i++;
                changePlayer();
            }
            else
            {
                button1.Text = "X";
                i--;
                changePlayer();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (playerOne == 1)
            {
                button2.Text = "O";
                i++;
                changePlayer();
            }
            else
            {
                button2.Text = "X";
                i--;
                changePlayer();
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (playerOne == 1)
            {
                button3.Text = "O";
                i++;
                changePlayer();
            }
            else
            {
                button3.Text = "X";
                i--;
                changePlayer();
            }


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (playerOne == 1)
            {
                button4.Text = "O";
                i++;
                changePlayer();
            }
            else
            {
                button4.Text = "X";
                i--;
                changePlayer();
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (playerOne == 1)
            {
                button5.Text = "O";
                i++;
                changePlayer();
            }
            else
            {
                button5.Text = "X";
                i--;
                changePlayer();
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (playerOne == 1)
            {
                button6.Text = "O";
                i++;
                changePlayer();
            }
            else
            {
                button6.Text = "X";
                i--;
                changePlayer();
            }

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (playerOne == 1)
            {
                button7.Text = "O";
                i++;
                changePlayer();
            }
            else
            {
                button7.Text = "X";
                i--;
                changePlayer();
            }

        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            if (playerOne == 1)
            {
                button8.Text = "O";
                i++;
                changePlayer();
            }
            else
            {
                button8.Text = "X";
                i--;
                changePlayer();
            }

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (playerOne == 1)
            {
                button9.Text = "O";
                i++;
                changePlayer();
            }
            else
            {
                button9.Text = "X";
                i--;
                changePlayer();
            }
        }
    }
}
