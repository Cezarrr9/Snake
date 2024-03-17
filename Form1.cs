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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            CenterStartGameButton();
            CenterTitleLabel();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Hide();
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterStartGameButton();
            CenterTitleLabel();
        }
    }
}
