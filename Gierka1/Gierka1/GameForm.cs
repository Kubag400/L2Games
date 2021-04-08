using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gierka1
{
    public partial class GameForm : Form
    {
        Random _rnd = new Random();
        int speed = 8;
        int gravity = 10;
        int score = 0;
        public GameForm()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            pipeBottom.Left -= speed;
            pipeTop.Left -= speed;
            if(pipeBottom.Left <-40)
            {
                //TODO: changing height in pipes 
                pipeBottom.Left = _rnd.Next(800,900);
                score++;
            }
            if(pipeTop.Left<-40)
            {
                pipeTop.Left = _rnd.Next(800, 900);
                score++;
            }
            scoreLabel.Text = $"Score:{score.ToString()}";
            endGame();
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up)
            {
                gravity = -10;
            }
            if(e.KeyCode==Keys.Space)
            {
                this.Close();
                e.Handled = true;
            }
        }
        private void GameKeyeUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = 10;
            }
        }
        private void endGame()
        {
            if (Bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                Bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                Bird.Bounds.IntersectsWith(ground.Bounds) ||
                Bird.Top < -25)
            {
                gameTimer.Stop();
                scoreLabel.Text += " !!GAME OVER!! ";
            }
        }
    }
}
