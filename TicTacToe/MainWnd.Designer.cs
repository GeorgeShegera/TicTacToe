namespace TicTacToe
{
    partial class MainWnd
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
            this.btnRules = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnVsPlayer = new System.Windows.Forms.Button();
            this.btnVsBot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRules
            // 
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRules.Location = new System.Drawing.Point(27, 15);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(203, 53);
            this.btnRules.TabIndex = 0;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOptions.Location = new System.Drawing.Point(27, 74);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(203, 53);
            this.btnOptions.TabIndex = 0;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnVsPlayer
            // 
            this.btnVsPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVsPlayer.Location = new System.Drawing.Point(27, 133);
            this.btnVsPlayer.Name = "btnVsPlayer";
            this.btnVsPlayer.Size = new System.Drawing.Size(203, 53);
            this.btnVsPlayer.TabIndex = 0;
            this.btnVsPlayer.Text = "Vs player";
            this.btnVsPlayer.UseVisualStyleBackColor = true;
            this.btnVsPlayer.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnVsBot
            // 
            this.btnVsBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVsBot.Location = new System.Drawing.Point(27, 192);
            this.btnVsBot.Name = "btnVsBot";
            this.btnVsBot.Size = new System.Drawing.Size(203, 53);
            this.btnVsBot.TabIndex = 0;
            this.btnVsBot.Text = "Vs bot";
            this.btnVsBot.UseVisualStyleBackColor = true;
            this.btnVsBot.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 264);
            this.Controls.Add(this.btnVsBot);
            this.Controls.Add(this.btnVsPlayer);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnRules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnVsPlayer;
        private System.Windows.Forms.Button btnVsBot;
    }
}

