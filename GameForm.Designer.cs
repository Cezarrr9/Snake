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
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.gamePanel = new Snake.GamePanel();
            this.btnResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.Transparent;
            this.backgroundPanel.Location = new System.Drawing.Point(189, 112);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(420, 420);
            this.backgroundPanel.TabIndex = 1;
            this.backgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundPanel_Paint);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(185, 75);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(80, 24);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(536, 75);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(73, 24);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time: 0";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(627, 112);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(166, 103);
            this.btnPlayAgain.TabIndex = 4;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Enabled = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(627, 431);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(166, 101);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Visible = false;
            this.btnQuit.Enabled = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(627, 266);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(166, 101);
            this.btnPause.TabIndex = 6;
            this.btnPause.TabStop = false;
            this.btnPause.Text = "Pause Game";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // gamePanel
            // 
            //this.gamePanel.CellSize = 20;
            this.gamePanel.CountTimer = null;
            this.gamePanel.CurrentDirection = Snake.Direction.Left;
            this.gamePanel.Food = new System.Drawing.Point(0, 0);
            //this.gamePanel.GridSize = new System.Drawing.Size(20, 20);
            this.gamePanel.Location = new System.Drawing.Point(199, 121);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(400, 400);
            this.gamePanel.Snake = ((System.Collections.Generic.List<System.Drawing.Point>)(resources.GetObject("gamePanel.Snake")));
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.Location = new System.Drawing.Point(12, 266);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(162, 101);
            this.btnResume.TabIndex = 7;
            this.btnResume.Text = "Resume Game";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            this.btnResume.Visible = false;
            this.btnResume.Enabled = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 591);
            this.Controls.Add(this.backgroundPanel);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.gamePanel);
            this.Name = "GameForm";
            this.Text = "Snake";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Resize += new System.EventHandler(this.GameForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private void CenterGamePanel()
        {
            gamePanel.Left = (this.ClientSize.Width - gamePanel.Width) / 2;
            gamePanel.Top = (this.ClientSize.Height - gamePanel.Height) / 2;
        }

        private void CenterBackgroundPanel()
        {
            backgroundPanel.Left = (this.ClientSize.Width - backgroundPanel.Width) / 2;
            backgroundPanel.Top = (this.ClientSize.Height - backgroundPanel.Height) / 2;
        }

        private void CenterScoreLabel()
        {
            lblScore.Left = backgroundPanel.Left;
            lblScore.Top = backgroundPanel.Top - lblScore.Height - 10;
        }

        private void CenterTimeLabel()
        {
            lblTime.Left = backgroundPanel.Left + 400 - lblTime.Width;
            lblTime.Top = backgroundPanel.Top - lblTime.Height - 10;
        }

        private void CenterPlayAgainButton()
        {
            btnPlayAgain.Left = backgroundPanel.Left + 430;
            btnPlayAgain.Top = backgroundPanel.Top;
        }

        private void CenterQuitGameButton()
        {
            btnQuit.Left = backgroundPanel.Left + 430;
            btnQuit.Top = backgroundPanel.Top + 420 - btnQuit.Height;
        }

        private void CenterPauseGameButton()
        {
            btnPause.Left = backgroundPanel.Left + 430;
            btnPause.Top = (this.ClientSize.Height - btnPause.Height) / 2; 
        }

        private void CenterResumeGameButton()
        {
            btnResume.Left = backgroundPanel.Left - btnResume.Width - 30;
            btnResume.Top = btnPause.Top;
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var segment in gamePanel.Snake)
            {
                g.FillRectangle(Brushes.Green, segment.X * GamePanel.CELL_SIZE, segment.Y * GamePanel.CELL_SIZE,
                    GamePanel.CELL_SIZE, GamePanel.CELL_SIZE);
            }

            g.FillRectangle(Brushes.Red, gamePanel.Food.X * GamePanel.CELL_SIZE, gamePanel.Food.Y * GamePanel.CELL_SIZE,
                GamePanel.CELL_SIZE, GamePanel.CELL_SIZE);
        }

        private void backgroundPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Customize your border style
            int thickness = 10;
            Color borderColor = Color.Black;

            // For having the borders of the same thickness
            float offsetThickness = thickness / 2f;

            using (Pen pen = new Pen(borderColor, thickness))
            {
                // Drawing just inside the bounds to avoid clipping
                g.DrawRectangle(pen, offsetThickness, offsetThickness, backgroundPanel.Width - thickness,
                    backgroundPanel.Height - thickness);
            }
        }

        private void GamePanel_ScoreChanged(int newScore)
        {
            lblScore.Text = $"Score: {newScore}";
        }

        private void GamePanel_TimeChanged(int newTime)
        {
            lblTime.Text = $"Time: {newTime}";
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            CenterBackgroundPanel();
            CenterGamePanel();
            CenterScoreLabel();
            CenterTimeLabel();
            CenterPlayAgainButton();
            CenterQuitGameButton();
            CenterPauseGameButton();
            CenterResumeGameButton();
        }

        private GamePanel gamePanel;
        private Panel backgroundPanel;
        private Label lblScore;
        private Label lblTime;
        private Button btnPlayAgain;
        private Button btnQuit;
        private Button btnPause;
        private Button btnResume;
    }
}