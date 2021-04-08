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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            GameForm newGame = new GameForm();
            newGame.Show();
            
        }

        private void scoreBtn_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                playBtn_Click(sender, new EventArgs());
                e.Handled = true;
            }
            if(e.KeyCode==Keys.Escape)
            {
                exitBtn_Click(sender, new EventArgs());
                e.Handled = true;
            }
        }
    }
}
