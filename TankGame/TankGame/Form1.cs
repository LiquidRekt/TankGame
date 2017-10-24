using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankGame
{
    public partial class TankGame : Form
    {
        public TankGame()
        {
            InitializeComponent();
            landBar.Hide();
            playerTank.Hide();
        }


        private void gameArea_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(150,255,150);
            
        }

        private void startBtn_Paint(object sender, PaintEventArgs e)
        {
            startBtn.BackColor = Color.FromArgb(0, 0, 255);
            startBtn.ForeColor = Color.White;
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            // Initialize Content
            Panel mainGame = new Panel();
            mainGame.Size = gameArea.Size;
            mainGame.AutoSize = true;
            mainGame.BackColor = Color.White;
            mainGame.Location = new System.Drawing.Point(0, 0);
            gameArea.Controls.Add(mainGame);
            startBtn.Hide();
            gameTitle.Hide();
            //

            // Background settings
            landBar.Show();
            playerTank.Show();
            //
        }

        private void TankGame_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    playerTank.Left -= 3;
                    break;
                case Keys.Right:
                    playerTank.Left += 3;
                    break;
            }
        }
    }
}
