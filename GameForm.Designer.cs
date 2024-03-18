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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new Snake.GamePanel();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.Transparent;
            this.backgroundPanel.Location = new System.Drawing.Point(130, 53);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(420, 420);
            this.backgroundPanel.TabIndex = 1;
            this.backgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundPanel_Paint);
            // 
            // gamePanel
            // 
            this.gamePanel.CellSize = 20;
            this.gamePanel.CurrentDirection = Snake.Direction.Left;
            this.gamePanel.Food = new System.Drawing.Point(0, 0);
            this.gamePanel.GridSize = new System.Drawing.Size(20, 20);
            this.gamePanel.Location = new System.Drawing.Point(140, 62);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(400, 400);
            this.gamePanel.Snake = ((System.Collections.Generic.List<System.Drawing.Point>)(resources.GetObject("gamePanel.Snake")));
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(127, 22);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 24);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 541);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.backgroundPanel);
            this.Controls.Add(this.gamePanel);
            this.Name = "GameForm";
            this.Text = "Snake";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
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

        private GamePanel gamePanel;
        private Panel backgroundPanel;
        private Label lblScore;
    }
}