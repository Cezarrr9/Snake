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
            this.gamePanel = new Snake.GamePanel();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.CellSize = 20;
            this.gamePanel.Food = new System.Drawing.Point(0, 0);
            this.gamePanel.GridSize = new System.Drawing.Size(20, 20);
            this.gamePanel.Location = new System.Drawing.Point(140, 62);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(400, 400);
            this.gamePanel.Snake = ((System.Collections.Generic.List<System.Drawing.Point>)(resources.GetObject("gamePanel.Snake")));
            this.gamePanel.TabIndex = 0;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 541);
            this.Controls.Add(this.backgroundPanel);
            this.Controls.Add(this.gamePanel);
            this.Name = "GameForm";
            this.Text = "Snake";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Resize += new System.EventHandler(this.GameForm_Resize);
            this.ResumeLayout(false);

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

        private GamePanel gamePanel;
        private Panel backgroundPanel;
    }
}