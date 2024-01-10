using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird1  
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void gameTimer(object sender, EventArgs e)
        {

            pictureBoxBird.Top += gravity;
            pictureBoxBottom.Left -= pipeSpeed;
            pictureBoxTop.Left -= pipeSpeed;
            label1.Text = "SCORE: " + score;

            if (pictureBoxBottom.Left < -150)
            {
                pictureBoxBottom.Left = 800;
                score++;
            }
            if (pictureBoxTop.Left < -150)
            {
                pictureBoxTop.Left = 800;
                score++;
            }
            if (pictureBoxBird.Bounds.IntersectsWith(pictureBoxBottom.Bounds) ||
                pictureBoxBird.Bounds.IntersectsWith(pictureBoxTop.Bounds) ||
                pictureBoxBird.Bounds.IntersectsWith(pictureBoxGround.Bounds) || pictureBoxBird.Top < -25)
            {
                EndGame();
            }
        }
        public void EndGame()
        {
            timerGameControl.Stop();
            label1.Text = "GAME OVER!";
        }

        private void gameDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }  
        }

        private void gameUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
    }
}