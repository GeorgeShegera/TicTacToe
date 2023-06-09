namespace TicTacToe
{
    partial class OptionsWnd
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
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbPlayO = new System.Windows.Forms.RadioButton();
            this.rbPlayX = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.gbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOptions
            // 
            this.gbOptions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbOptions.Controls.Add(this.rbRandom);
            this.gbOptions.Controls.Add(this.rbPlayO);
            this.gbOptions.Controls.Add(this.rbPlayX);
            this.gbOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbOptions.Location = new System.Drawing.Point(12, 12);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(186, 132);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            // 
            // rbRandom
            // 
            this.rbRandom.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRandom.Location = new System.Drawing.Point(6, 79);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(156, 24);
            this.rbRandom.TabIndex = 0;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Random Selection";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // rbPlayO
            // 
            this.rbPlayO.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlayO.Location = new System.Drawing.Point(6, 49);
            this.rbPlayO.Name = "rbPlayO";
            this.rbPlayO.Size = new System.Drawing.Size(80, 24);
            this.rbPlayO.TabIndex = 0;
            this.rbPlayO.TabStop = true;
            this.rbPlayO.Text = "Play O";
            this.rbPlayO.UseVisualStyleBackColor = true;
            // 
            // rbPlayX
            // 
            this.rbPlayX.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlayX.Location = new System.Drawing.Point(6, 19);
            this.rbPlayX.Name = "rbPlayX";
            this.rbPlayX.Size = new System.Drawing.Size(80, 24);
            this.rbPlayX.TabIndex = 0;
            this.rbPlayX.TabStop = true;
            this.rbPlayX.Text = "Play X";
            this.rbPlayX.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(12, 164);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(186, 42);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // OptionsWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 218);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gbOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OptionsWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsWnd_Load);
            this.gbOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbPlayO;
        private System.Windows.Forms.RadioButton rbPlayX;
        private System.Windows.Forms.Button btnApply;
    }
}