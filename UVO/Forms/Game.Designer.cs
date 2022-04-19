namespace UVO.Forms
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.AutoSize = true;
            this.buttonPlay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlay.Location = new System.Drawing.Point(693, 178);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(426, 106);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play!";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(693, 306);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(426, 106);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1794, 594);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlay);
            this.Name = "Game";
            this.Text = "Ukrainian soldiers versus Orcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonPlay;
        private Button buttonExit;
    }
}