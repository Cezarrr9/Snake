using System;
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

        /// <summary>
        /// Hides the form and creates a game form instead.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Hide();
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        /// <summary>
        /// Centers the start game button and title label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterStartGameButton();
            CenterTitleLabel();
        }
    }
}
