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
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.picCanvas.Location = new System.Drawing.Point(198, 125);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(581, 501);
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
            this.btnStart.Location = new System.Drawing.Point(347, 34);
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(984, 761);
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
            this.Name = "GameForm";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.Resize += new System.EventHandler(this.GameForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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

            picCanvas.Enabled = false;
            picCanvas.Visible = false;

            lblScore.Enabled = false;
            lblScore.Visible = false;

            lblHighscore.Enabled = false;
            lblHighscore.Visible = false;

            lblDifChoice.Enabled = false;
            lblDifChoice.Visible = false;
        }

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

            lblDifChoice.Enabled = true;
            lblDifChoice.Visible = true;

            lblTitle.Enabled = false;
            lblTitle.Visible = false;

            btnStart.Enabled = false;
            btnStart.Visible = false;
        }

        private void GameView()
        {
            CenterCanvas();
            PlaceScoreLabel();
            PlaceHighscoreLabel();

            PlacePlayAgainButton();
            PlaceQuitButton();

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
        }

        private void CenterStartButton()
        {
            btnStart.Left = (this.ClientSize.Width - btnStart.Width) / 2;
            btnStart.Top = (this.ClientSize.Height - btnStart.Height) / 2;
        }

        private void CenterTitleLabel()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            lblTitle.Top = (this.ClientSize.Height - lblTitle.Height) / 2 - lblTitle.Height;
        }

        private void CenterMediumButton()
        {
            btnMDif.Left = (this.ClientSize.Width - btnMDif.Width) / 2;
            btnMDif.Top = (this.ClientSize.Height - btnMDif.Height) / 2;
        }

        private void CenterEasyButton()
        {
            btnEDif.Left = btnMDif.Left - btnEDif.Width - 50;
            btnEDif.Top = btnMDif.Top;
        }

        private void CenterHardButton()
        {
            btnHDif.Left = btnMDif.Left + btnHDif.Width + 50;
            btnHDif.Top = btnMDif.Top;
        }
        private void CenterCDLabel()
        {
            lblDifChoice.Left = (this.ClientSize.Width - lblDifChoice.Width) / 2;
            lblDifChoice.Top = (this.ClientSize.Height - lblDifChoice.Height) / 2 - btnMDif.Height - 50;
        }

        private void CenterCanvas()
        {
            picCanvas.Left = (this.ClientSize.Width - picCanvas.Width) / 2;
            picCanvas.Top = (this.ClientSize.Height - picCanvas.Height) / 2;
        }

        private void PlaceScoreLabel()
        {
            lblScore.Left = picCanvas.Left;
            lblScore.Top = picCanvas.Top - lblScore.Height - 5;
        }

        private void PlaceHighscoreLabel()
        {
            lblHighscore.Left = picCanvas.Left + picCanvas.Width - lblHighscore.Width;
            lblHighscore.Top = picCanvas.Top - lblHighscore.Height - 5;
        }

        private void PlacePlayAgainButton()
        {
            btnPlayAgain.Left = picCanvas.Left + picCanvas.Width + 10;
            btnPlayAgain.Top = picCanvas.Top;
        }

        private void PlaceQuitButton()
        {
            btnQuit.Left = picCanvas.Left + picCanvas.Width + 10;
            btnQuit.Top = picCanvas.Top + picCanvas.Height - btnQuit.Height; 
        }

        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < _snake.Count; i++)
            {
                snakeColour = Brushes.DarkOliveGreen;

                g.FillEllipse(snakeColour, new Rectangle(
                    _snake[i].X * Settings.CellSize,
                    _snake[i].Y * Settings.CellSize,
                    Settings.CellSize,
                    Settings.CellSize
                ));
            }

            Brush foodColour = Brushes.Red;

            g.FillEllipse(foodColour, new Rectangle(
                _food.X * Settings.CellSize,
                _food.Y * Settings.CellSize,
                Settings.CellSize,
                Settings.CellSize
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
    }
}