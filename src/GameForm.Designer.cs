using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnEDif = new System.Windows.Forms.Button();
            this.btnMDif = new System.Windows.Forms.Button();
            this.btnHDif = new System.Windows.Forms.Button();
            this.lblDifChoice = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDif = new System.Windows.Forms.Label();
            this.btnDecreaseDif = new System.Windows.Forms.Button();
            this.btnIncreaseDif = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.tbInstr = new System.Windows.Forms.TextBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.picCanvas.Location = new System.Drawing.Point(198, 125);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(561, 456);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraphics);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPlayAgain.Location = new System.Drawing.Point(784, 125);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(161, 107);
            this.btnPlayAgain.TabIndex = 1;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnQuit.Location = new System.Drawing.Point(784, 518);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(161, 107);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblScore.Location = new System.Drawing.Point(194, 98);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(80, 24);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score: 0";
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblHighscore.Location = new System.Drawing.Point(662, 98);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(117, 24);
            this.lblHighscore.TabIndex = 6;
            this.lblHighscore.Text = "Highscore: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.UpdateGame);
            // 
            // btnEDif
            // 
            this.btnEDif.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDif.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEDif.Location = new System.Drawing.Point(149, 325);
            this.btnEDif.Name = "btnEDif";
            this.btnEDif.Size = new System.Drawing.Size(161, 66);
            this.btnEDif.TabIndex = 7;
            this.btnEDif.Text = "Easy";
            this.btnEDif.UseVisualStyleBackColor = false;
            this.btnEDif.Click += new System.EventHandler(this.btnEDif_Click);
            // 
            // btnMDif
            // 
            this.btnMDif.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnMDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMDif.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnMDif.Location = new System.Drawing.Point(410, 325);
            this.btnMDif.Name = "btnMDif";
            this.btnMDif.Size = new System.Drawing.Size(159, 66);
            this.btnMDif.TabIndex = 8;
            this.btnMDif.Text = "Medium";
            this.btnMDif.UseVisualStyleBackColor = false;
            this.btnMDif.Click += new System.EventHandler(this.btnMDif_Click);
            // 
            // btnHDif
            // 
            this.btnHDif.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnHDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDif.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHDif.Location = new System.Drawing.Point(646, 325);
            this.btnHDif.Name = "btnHDif";
            this.btnHDif.Size = new System.Drawing.Size(157, 66);
            this.btnHDif.TabIndex = 9;
            this.btnHDif.Text = "Hard";
            this.btnHDif.UseVisualStyleBackColor = false;
            this.btnHDif.Click += new System.EventHandler(this.btnHDif_Click);
            // 
            // lblDifChoice
            // 
            this.lblDifChoice.AutoSize = true;
            this.lblDifChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifChoice.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblDifChoice.Location = new System.Drawing.Point(249, 201);
            this.lblDifChoice.Name = "lblDifChoice";
            this.lblDifChoice.Size = new System.Drawing.Size(503, 73);
            this.lblDifChoice.TabIndex = 10;
            this.lblDifChoice.Text = "Choose difficulty";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStart.Location = new System.Drawing.Point(43, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(221, 64);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start Game ";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(407, 466);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 108);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Snake";
            // 
            // lblDif
            // 
            this.lblDif.AutoSize = true;
            this.lblDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDif.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblDif.Location = new System.Drawing.Point(421, 98);
            this.lblDif.Name = "lblDif";
            this.lblDif.Size = new System.Drawing.Size(59, 24);
            this.lblDif.TabIndex = 13;
            this.lblDif.Text = "Mode";
            // 
            // btnDecreaseDif
            // 
            this.btnDecreaseDif.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnDecreaseDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseDif.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDecreaseDif.Location = new System.Drawing.Point(31, 518);
            this.btnDecreaseDif.Name = "btnDecreaseDif";
            this.btnDecreaseDif.Size = new System.Drawing.Size(161, 107);
            this.btnDecreaseDif.TabIndex = 16;
            this.btnDecreaseDif.Text = "Decrease Difficulty";
            this.btnDecreaseDif.UseVisualStyleBackColor = false;
            this.btnDecreaseDif.Click += new System.EventHandler(this.btnDecreaseDif_Click);
            // 
            // btnIncreaseDif
            // 
            this.btnIncreaseDif.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnIncreaseDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseDif.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIncreaseDif.Location = new System.Drawing.Point(31, 126);
            this.btnIncreaseDif.Name = "btnIncreaseDif";
            this.btnIncreaseDif.Size = new System.Drawing.Size(161, 107);
            this.btnIncreaseDif.TabIndex = 17;
            this.btnIncreaseDif.Text = "Increase Difficulty";
            this.btnIncreaseDif.UseVisualStyleBackColor = false;
            this.btnIncreaseDif.Click += new System.EventHandler(this.btnIncreaseDif_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblInstructions.Location = new System.Drawing.Point(328, 25);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(361, 73);
            this.lblInstructions.TabIndex = 18;
            this.lblInstructions.Text = "Instructions";
            // 
            // tbInstr
            // 
            this.tbInstr.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.tbInstr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInstr.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.tbInstr.Location = new System.Drawing.Point(112, 277);
            this.tbInstr.Multiline = true;
            this.tbInstr.Name = "tbInstr";
            this.tbInstr.ReadOnly = true;
            this.tbInstr.Size = new System.Drawing.Size(772, 316);
            this.tbInstr.TabIndex = 19;
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReady.Location = new System.Drawing.Point(354, 652);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(231, 66);
            this.btnReady.TabIndex = 20;
            this.btnReady.Text = "I\'m ready!";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblWinner.Location = new System.Drawing.Point(71, 126);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(864, 108);
            this.lblWinner.TabIndex = 21;
            this.lblWinner.Text = "You are the GOAT!";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.tbInstr);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnIncreaseDif);
            this.Controls.Add(this.btnDecreaseDif);
            this.Controls.Add(this.lblDif);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDifChoice);
            this.Controls.Add(this.btnHDif);
            this.Controls.Add(this.btnMDif);
            this.Controls.Add(this.btnEDif);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.picCanvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.Resize += new System.EventHandler(this.GameForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        /// <summary>
        /// Displays the first view the player sees.
        /// </summary>
        private void StartGameView()
        {
            CenterTitleLabel();
            CenterStartButton();

            btnEDif.Enabled = false;
            btnEDif.Visible = false;

            btnMDif.Enabled = false;
            btnMDif.Visible = false;

            btnHDif.Enabled = false;
            btnHDif.Visible = false;

            btnPlayAgain.Enabled = false;
            btnPlayAgain.Visible = false;

            btnQuit.Enabled = false;
            btnQuit.Visible = false;

            btnDecreaseDif.Enabled = false;
            btnDecreaseDif.Visible = false;

            btnIncreaseDif.Enabled = false; 
            btnIncreaseDif.Visible = false;

            btnReady.Enabled = false;
            btnReady.Visible = false;

            picCanvas.Enabled = false;
            picCanvas.Visible = false;

            lblScore.Enabled = false;
            lblScore.Visible = false;

            lblHighscore.Enabled = false;
            lblHighscore.Visible = false;

            lblDif.Enabled = false;
            lblDif.Visible = false;

            lblDifChoice.Enabled = false;
            lblDifChoice.Visible = false;

            lblInstructions.Enabled = false;
            lblInstructions.Visible = false;

            lblWinner.Enabled = false;
            lblWinner.Visible = false;

            tbInstr.Enabled = false;
            tbInstr.Visible = false;
        }

        /// <summary>
        /// Displays the rules/instructions of the game.
        /// </summary>
        private void RulesView()
        {
            CenterTextBox();
            CenterInstructionsLabel();
            CenterReadyButton();

            SetInstructions();

            lblTitle.Enabled = false;
            lblTitle.Visible = false;

            btnStart.Enabled = false;
            btnStart.Visible = false;

            lblInstructions.Enabled = true;
            lblInstructions.Visible = true;

            lblWinner.Enabled = false;
            lblWinner.Visible = false;

            btnQuit.Enabled = false;
            btnQuit.Visible = false;

            btnPlayAgain.Enabled = false;
            btnPlayAgain.Visible = false;

            tbInstr.Enabled = true;
            tbInstr.Visible = true;

            btnReady.Enabled = true;
            btnReady.Visible = true;
        }

        /// <summary>
        /// Displays options regarding the difficulty of the game. 
        /// </summary>
        private void ChooseDifficultyView()
        {
            CenterMediumButton();
            CenterEasyButton();
            CenterHardButton();

            CenterCDLabel();

            btnEDif.Enabled = true;
            btnEDif.Visible = true;

            btnMDif.Enabled = true;
            btnMDif.Visible = true;

            btnHDif.Enabled = true;
            btnHDif.Visible = true;

            btnReady.Enabled = false;
            btnReady.Visible = false;

            btnQuit.Enabled = false;
            btnQuit.Visible = false;

            lblDifChoice.Enabled = true;
            lblDifChoice.Visible = true;

            lblInstructions.Enabled = false;
            lblInstructions.Visible = false;

            lblWinner.Enabled = false;
            lblWinner.Visible = false;

            tbInstr.Enabled = false;
            tbInstr.Visible = false;
        }

        /// <summary>
        /// Displays the main view which contains the game.
        /// </summary>
        private void GameView()
        {
            CenterCanvas();
            PlaceScoreLabel();
            PlaceHighscoreLabel();
            PlaceDifLabel();

            PlacePlayAgainButton();
            PlaceQuitButton();
            PlaceDecreaseDifButton();
            PlaceIncreaseDifButton();

            btnEDif.Enabled = false;
            btnEDif.Visible = false;

            btnMDif.Enabled = false;
            btnMDif.Visible = false;

            btnHDif.Enabled = false;
            btnHDif.Visible = false;

            lblDifChoice.Enabled = false;
            lblDifChoice.Visible = false;

            picCanvas.Enabled = true;
            picCanvas.Visible = true;

            lblScore.Enabled = true;
            lblScore.Visible = true;

            lblHighscore.Enabled = true;
            lblHighscore.Visible = true;

            lblDif.Enabled = true;
            lblDif.Visible = true;
        }

        /// <summary>
        /// Displays the message for the winner and options to play again or quit.
        /// </summary>
        private void WinningView()
        {
            CenterWinningLabel();
            PlaceWinningViewButtons();

            picCanvas.Enabled = false;
            picCanvas.Visible = false;

            lblScore.Enabled = false;
            lblScore.Visible = false;

            lblHighscore.Enabled = false;
            lblHighscore.Visible = false;

            lblDif.Enabled = false;
            lblDif.Visible = false;

            lblWinner.Enabled = true;
            lblWinner.Visible = true;

            btnStart.Text = "Play Again";
            btnStart.Enabled = true;
            btnStart.Visible = true;

            btnQuit.Enabled = true;
            btnQuit.Visible = true;
        }

        /// <summary>
        /// Displays the game view after the game has been restarted.
        /// </summary>
        private void RestartGameView()
        {
            btnPlayAgain.Enabled = false;
            btnPlayAgain.Visible = false;
            btnPlayAgain.Text = "Play Again";

            btnQuit.Enabled = false;
            btnQuit.Visible = false;

            btnDecreaseDif.Enabled = false;
            btnDecreaseDif.Visible = false;

            btnIncreaseDif.Enabled = false;
            btnIncreaseDif.Visible = false;
        }

        /// <summary>
        /// Displays the game view when the game is stopped.
        /// </summary>
        private void GameStoppedView()
        {
            btnPlayAgain.Enabled = true;
            btnPlayAgain.Visible = true;

            btnQuit.Enabled = true;
            btnQuit.Visible = true;

            btnDecreaseDif.Enabled = true;
            btnDecreaseDif.Visible = true;

            btnIncreaseDif.Enabled = true;
            btnIncreaseDif.Visible = true;
        }

        /// <summary>
        /// Adds the set of instructions to the text box from the rules view. 
        /// </summary>
        private void SetInstructions()
        {
            tbInstr.Text = "1. The goal of the game is to grow your snake as much as possible@" +
                "2. To do that you have to point the head of the snake towards the food@" +
                "3. You can do that by using the arrows@" +
                "4. There are three difficulties available (the higher the difficulty the higher the speed of the snake)@" +
                "5. There is a highscore for each difficulty@" +
                "6. You lose the game once the snake bumps into the frame or in itself@" +
                "7. You can pause the game any time by pressing the spacebar (and unpause it using the same method)@" +
                "8. You are also able to change the difficulty after you start playing";
            tbInstr.Text = tbInstr.Text.Replace("@", System.Environment.NewLine);
        }

        /// <summary>
        /// Places the start game button in the middle of the screen.
        /// </summary>
        private void CenterStartButton()
        {
            btnStart.Left = (this.ClientSize.Width - btnStart.Width) / 2;
            btnStart.Top = (this.ClientSize.Height - btnStart.Height) / 2;
        }

        /// <summary>
        /// Places the title of the game in the middle of the screen, right 
        /// above the start game button.
        /// </summary>
        private void CenterTitleLabel()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            lblTitle.Top = (this.ClientSize.Height - lblTitle.Height) / 2 - lblTitle.Height;
        }

        /// <summary>
        /// Places the text box that contains the rules in the middle of the screen.
        /// </summary>
        private void CenterTextBox()
        {
            tbInstr.Left = (this.ClientSize.Width - tbInstr.Width) / 2;
            tbInstr.Top = (this.ClientSize.Height - tbInstr.Height) / 2 + 30;
        }

        /// <summary>
        /// Places the instruction label in the middle of the screen,
        /// right on top of the text box.
        /// </summary>
        private void CenterInstructionsLabel()
        {
            lblInstructions.Left = (this.ClientSize.Width - lblInstructions.Width) / 2;
            lblInstructions.Top = tbInstr.Top - lblInstructions.Height - 10;
        }

        /// <summary>
        /// Places the ready button in the middle of the screen, 
        /// just below the text box.
        /// </summary>
        private void CenterReadyButton()
        {
            btnReady.Left = (this.ClientSize.Width -btnReady.Width) / 2;
            btnReady.Top = tbInstr.Top + tbInstr.Height + 10;
        }

        /// <summary>
        /// Places the medium difficulty button in the center of the screen.
        /// </summary>
        private void CenterMediumButton()
        {
            btnMDif.Left = (this.ClientSize.Width - btnMDif.Width) / 2;
            btnMDif.Top = (this.ClientSize.Height - btnMDif.Height) / 2;
        }


        /// <summary>
        /// Places the easy difficulty button in the middle of the screen, 
        /// right to the left of the medium difficulty button.
        /// </summary>
        private void CenterEasyButton()
        {
            btnEDif.Left = btnMDif.Left - btnEDif.Width - 50;
            btnEDif.Top = btnMDif.Top;
        }

        /// <summary>
        /// Places the hard difficulty button in the middle of the screen, 
        /// exactly to the right of the medium difficulty button.
        /// </summary>
        private void CenterHardButton()
        {
            btnHDif.Left = btnMDif.Left + btnHDif.Width + 50;
            btnHDif.Top = btnMDif.Top;
        }

        /// <summary>
        /// Places the choose difficulty label in the middle of the screen,
        /// right on top of the medium difficulty button.
        /// </summary>
        private void CenterCDLabel()
        {
            lblDifChoice.Left = (this.ClientSize.Width - lblDifChoice.Width) / 2;
            lblDifChoice.Top = (this.ClientSize.Height - lblDifChoice.Height) / 2 - btnMDif.Height - 50;
        }

        /// <summary>
        /// Places the game canvas in the middle of the screen.
        /// </summary>
        private void CenterCanvas()
        {
            picCanvas.Left = (this.ClientSize.Width - picCanvas.Width) / 2;
            picCanvas.Top = (this.ClientSize.Height - picCanvas.Height) / 2;
        }

        /// <summary>
        /// Places the score label above the top left corner of the game canvas.
        /// </summary>
        private void PlaceScoreLabel()
        {
            lblScore.Left = picCanvas.Left;
            lblScore.Top = picCanvas.Top - lblScore.Height - 5;
        }

        /// <summary>
        /// Places the highscore label above the top right corner of the game canvas.
        /// </summary>
        private void PlaceHighscoreLabel()
        {
            lblHighscore.Left = picCanvas.Left + picCanvas.Width - lblHighscore.Width;
            lblHighscore.Top = picCanvas.Top - lblHighscore.Height - 5;
        }

        /// <summary>
        /// Places the difficulty label in the middle of the screen above the game canvas.
        /// </summary>
        private void PlaceDifLabel()
        {
            lblDif.Left = (lblHighscore.Left + lblScore.Left) / 2;
            lblDif.Top = picCanvas.Top - lblDif.Height - 5;
        }

        /// <summary>
        /// Places the play again button next to the top right corner of the game canvas.
        /// </summary>
        private void PlacePlayAgainButton()
        {
            btnPlayAgain.Left = picCanvas.Left + picCanvas.Width + 10;
            btnPlayAgain.Top = picCanvas.Top;
        }

        /// <summary>
        /// Places the quit game button next to the bottom right corner of the game canvas.
        /// </summary>
        private void PlaceQuitButton()
        {
            btnQuit.Left = picCanvas.Left + picCanvas.Width + 10;
            btnQuit.Top = picCanvas.Top + picCanvas.Height - btnQuit.Height; 
        }

        /// <summary>
        /// Places the increase difficulty button next to the top left corner of the game canvas.
        /// </summary>
        private void PlaceIncreaseDifButton()
        {
            btnIncreaseDif.Left = picCanvas.Left - btnIncreaseDif.Width - 10;
            btnIncreaseDif.Top = picCanvas.Top;
        }

        /// <summary>
        /// Places the decrease difficulty button next to the bottom left corner of the game canvas.
        /// </summary>
        private void PlaceDecreaseDifButton()
        {
            btnDecreaseDif.Left = picCanvas.Left - btnIncreaseDif.Width - 10;
            btnDecreaseDif.Top = picCanvas.Top + picCanvas.Height - btnDecreaseDif.Height;
        }

        /// <summary>
        /// Places the winning label in the middle of the screen.
        /// </summary>
        private void CenterWinningLabel()
        {
            lblWinner.Left = (this.ClientSize.Width -  lblWinner.Width) / 2;
            lblWinner.Top = (this.ClientSize.Height - lblWinner.Height) / 2 - 115;
        }

        /// <summary>
        /// Places the play again and quit buttons in the middle of the screen just under 
        /// the winning label in the winning view.
        /// </summary>
        private void PlaceWinningViewButtons()
        {
            btnStart.Height = btnQuit.Height;
            btnStart.Width = btnQuit.Width;

            btnQuit.Left = (this.ClientSize.Width - btnQuit.Width) / 2 + btnQuit.Width;
            btnQuit.Top = lblWinner.Top + lblWinner.Height + 30;
            
            btnStart.Left = (this.ClientSize.Width - btnStart.Width) / 2 - btnStart.Width;
            btnStart.Top = lblWinner.Top + lblWinner.Height + 30;
        }

        /// <summary>
        /// Keeps the ui elements in the same position relative 
        /// to the borders of the frame when resizing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Resize(object sender, EventArgs e)
        {
            // Start game view
            CenterTitleLabel();
            CenterStartButton();

            // Rules view
            CenterTextBox();
            CenterInstructionsLabel();
            CenterReadyButton();

            // Change Difficulty view
            CenterMediumButton();
            CenterEasyButton();
            CenterHardButton();
            CenterCDLabel();

            // Game view
            CenterCanvas();
            PlaceScoreLabel();
            PlaceHighscoreLabel();
            PlaceDifLabel();

            PlacePlayAgainButton();
            PlaceQuitButton();
            PlaceIncreaseDifButton();
            PlaceDecreaseDifButton();

            // Winning view
            CenterWinningLabel();
            PlaceWinningViewButtons();
        }

        /// <summary>
        /// Paints the game canvas according to the current game state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < _snake.Count; i++)
            {
                snakeColour = Brushes.DarkOliveGreen;

                g.FillEllipse(snakeColour, new Rectangle(
                    _snake[i].X * _cellSize,
                    _snake[i].Y * _cellSize,
                    _cellSize,
                    _cellSize
                ));
            }

            Brush foodColour = Brushes.Red;

            g.FillEllipse(foodColour, new Rectangle(
                _food.X * _cellSize,
                _food.Y * _cellSize,
                _cellSize,
                _cellSize
            ));
        }

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button btnEDif;
        private System.Windows.Forms.Button btnMDif;
        private System.Windows.Forms.Button btnHDif;
        private System.Windows.Forms.Label lblDifChoice;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitle;
        private Label lblDif;
        private Button btnDecreaseDif;
        private Button btnIncreaseDif;
        private Label lblInstructions;
        private TextBox tbInstr;
        private Button btnReady;
        private Label lblWinner;
    }
}