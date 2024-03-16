using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterStartGameButton();
        }

        private void InitializeGame()
        {
            btnStartGame.Enabled = false;
            btnStartGame.Hide();
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterStartGameButton();
        }
    }
}
