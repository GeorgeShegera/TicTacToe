namespace TicTacToe
{
    partial class RulesWnd
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
            this.lbRules = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRules
            // 
            this.lbRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRules.Location = new System.Drawing.Point(11, 9);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(394, 264);
            this.lbRules.TabIndex = 0;
            this.lbRules.Text = "Rules";
            // 
            // RulesWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 282);
            this.Controls.Add(this.lbRules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RulesWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rules";
            this.Load += new System.EventHandler(this.RulesWnd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbRules;
    }
}