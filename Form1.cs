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
            CenterTitleLabel();
        }

        private void ClearForm()
        {
            btnStartGame.Enabled = false;
            btnStartGame.Hide();

            lblTitle.Enabled = false;
            lblTitle.Hide();
        }

        private void CreateGamePane()
        {

        }

        private void InitializeGame()
        {
            
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterStartGameButton();
            CenterTitleLabel();
        }
    }
}
