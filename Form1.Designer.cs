using System;
using System.Windows.Forms;

namespace Snake
{
    partial class Form1
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(296, 241);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(200, 100);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(274, 131);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 73);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SNAKE";
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(145, 47);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(504, 439);
            this.gamePanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 541);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStartGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Snake";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void CenterStartGameButton()
        {
            btnStartGame.Left = (this.ClientSize.Width - btnStartGame.Width) / 2;
            btnStartGame.Top = (this.ClientSize.Height - btnStartGame.Height) / 2;
        }

        private void CenterTitleLabel()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            lblTitle.Top = (this.ClientSize.Height - lblTitle.Height) / 2 - btnStartGame.Height;
        }

        private void CenterGamePanel()
        {
            gamePanel.Left = (this.ClientSize.Width - gamePanel.Width) / 2;
            gamePanel.Top = (this.ClientSize.Height - gamePanel.Height) / 2;
        }

        private void DisableGamePanel()
        {
            gamePanel.Enabled = false;
            gamePanel.Hide();
        }

        private void EnableGamePanel()
        {
            gamePanel.Enabled = true;
            gamePanel.Show();
        }

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel gamePanel;
    }
}

