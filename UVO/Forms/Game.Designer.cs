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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pictureSoldierPos1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrc = new System.Windows.Forms.PictureBox();
            this.pictureBoxFireSold1 = new System.Windows.Forms.PictureBox();
            this.progressBarOrc = new System.Windows.Forms.ProgressBar();
            this.labelOrcHP = new System.Windows.Forms.Label();
            this.labelSoldier1HP = new System.Windows.Forms.Label();
            this.progressBarSoldier1 = new System.Windows.Forms.ProgressBar();
            this.buttonBuyArmor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBuyStrenght = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            this.labelStrenght = new System.Windows.Forms.Label();
            this.labelArmor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoldierPos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFireSold1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSoldierPos1
            // 
            this.pictureSoldierPos1.BackColor = System.Drawing.Color.Transparent;
            this.pictureSoldierPos1.Image = ((System.Drawing.Image)(resources.GetObject("pictureSoldierPos1.Image")));
            this.pictureSoldierPos1.Location = new System.Drawing.Point(-148, 104);
            this.pictureSoldierPos1.Name = "pictureSoldierPos1";
            this.pictureSoldierPos1.Size = new System.Drawing.Size(484, 418);
            this.pictureSoldierPos1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSoldierPos1.TabIndex = 1;
            this.pictureSoldierPos1.TabStop = false;
            // 
            // pictureBoxOrc
            // 
            this.pictureBoxOrc.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOrc.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrc.Image")));
            this.pictureBoxOrc.Location = new System.Drawing.Point(778, 92);
            this.pictureBoxOrc.Name = "pictureBoxOrc";
            this.pictureBoxOrc.Size = new System.Drawing.Size(484, 418);
            this.pictureBoxOrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrc.TabIndex = 1;
            this.pictureBoxOrc.TabStop = false;
            // 
            // pictureBoxFireSold1
            // 
            this.pictureBoxFireSold1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFireSold1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFireSold1.Image")));
            this.pictureBoxFireSold1.Location = new System.Drawing.Point(224, 274);
            this.pictureBoxFireSold1.Name = "pictureBoxFireSold1";
            this.pictureBoxFireSold1.Size = new System.Drawing.Size(122, 100);
            this.pictureBoxFireSold1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFireSold1.TabIndex = 3;
            this.pictureBoxFireSold1.TabStop = false;
            this.pictureBoxFireSold1.Visible = false;
            // 
            // progressBarOrc
            // 
            this.progressBarOrc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBarOrc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBarOrc.Location = new System.Drawing.Point(969, 115);
            this.progressBarOrc.Name = "progressBarOrc";
            this.progressBarOrc.Size = new System.Drawing.Size(200, 46);
            this.progressBarOrc.TabIndex = 4;
            this.progressBarOrc.Value = 100;
            // 
            // labelOrcHP
            // 
            this.labelOrcHP.AutoSize = true;
            this.labelOrcHP.BackColor = System.Drawing.Color.Transparent;
            this.labelOrcHP.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrcHP.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelOrcHP.Location = new System.Drawing.Point(907, 61);
            this.labelOrcHP.Name = "labelOrcHP";
            this.labelOrcHP.Size = new System.Drawing.Size(129, 51);
            this.labelOrcHP.TabIndex = 5;
            this.labelOrcHP.Text = "label1";
            // 
            // labelSoldier1HP
            // 
            this.labelSoldier1HP.AutoSize = true;
            this.labelSoldier1HP.BackColor = System.Drawing.Color.Transparent;
            this.labelSoldier1HP.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSoldier1HP.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelSoldier1HP.Location = new System.Drawing.Point(-3, 115);
            this.labelSoldier1HP.Name = "labelSoldier1HP";
            this.labelSoldier1HP.Size = new System.Drawing.Size(129, 51);
            this.labelSoldier1HP.TabIndex = 5;
            this.labelSoldier1HP.Text = "label1";
            // 
            // progressBarSoldier1
            // 
            this.progressBarSoldier1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBarSoldier1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBarSoldier1.Location = new System.Drawing.Point(22, 164);
            this.progressBarSoldier1.Name = "progressBarSoldier1";
            this.progressBarSoldier1.Size = new System.Drawing.Size(200, 46);
            this.progressBarSoldier1.TabIndex = 4;
            this.progressBarSoldier1.Value = 100;
            // 
            // buttonBuyArmor
            // 
            this.buttonBuyArmor.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBuyArmor.Location = new System.Drawing.Point(1460, 468);
            this.buttonBuyArmor.Name = "buttonBuyArmor";
            this.buttonBuyArmor.Size = new System.Drawing.Size(150, 114);
            this.buttonBuyArmor.TabIndex = 6;
            this.buttonBuyArmor.Text = "Броня +10";
            this.buttonBuyArmor.UseVisualStyleBackColor = true;
            this.buttonBuyArmor.Click += new System.EventHandler(this.buttonBuyArmor_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1616, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 114);
            this.button1.TabIndex = 6;
            this.button1.Text = "Атаковать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonBuyStrenght
            // 
            this.buttonBuyStrenght.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBuyStrenght.Location = new System.Drawing.Point(1304, 468);
            this.buttonBuyStrenght.Name = "buttonBuyStrenght";
            this.buttonBuyStrenght.Size = new System.Drawing.Size(150, 114);
            this.buttonBuyStrenght.TabIndex = 6;
            this.buttonBuyStrenght.Text = "Атака +10";
            this.buttonBuyStrenght.UseVisualStyleBackColor = true;
            this.buttonBuyStrenght.Click += new System.EventHandler(this.buttonBuyStrenght_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1567, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.Transparent;
            this.labelCoins.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCoins.Location = new System.Drawing.Point(1660, 29);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(103, 60);
            this.labelCoins.TabIndex = 8;
            this.labelCoins.Text = "100";
            // 
            // labelStrenght
            // 
            this.labelStrenght.AutoSize = true;
            this.labelStrenght.BackColor = System.Drawing.Color.Gray;
            this.labelStrenght.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStrenght.Location = new System.Drawing.Point(12, 522);
            this.labelStrenght.Name = "labelStrenght";
            this.labelStrenght.Size = new System.Drawing.Size(150, 60);
            this.labelStrenght.TabIndex = 8;
            this.labelStrenght.Text = "Сила:";
            // 
            // labelArmor
            // 
            this.labelArmor.AutoSize = true;
            this.labelArmor.BackColor = System.Drawing.Color.Gray;
            this.labelArmor.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelArmor.Location = new System.Drawing.Point(280, 522);
            this.labelArmor.Name = "labelArmor";
            this.labelArmor.Size = new System.Drawing.Size(180, 60);
            this.labelArmor.TabIndex = 8;
            this.labelArmor.Text = "Защита";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1794, 594);
            this.Controls.Add(this.labelArmor);
            this.Controls.Add(this.labelStrenght);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBuyStrenght);
            this.Controls.Add(this.buttonBuyArmor);
            this.Controls.Add(this.progressBarSoldier1);
            this.Controls.Add(this.labelSoldier1HP);
            this.Controls.Add(this.labelOrcHP);
            this.Controls.Add(this.progressBarOrc);
            this.Controls.Add(this.pictureBoxFireSold1);
            this.Controls.Add(this.pictureSoldierPos1);
            this.Controls.Add(this.pictureBoxOrc);
            this.Name = "Game";
            this.Text = "Ukrainian soldiers versus Orcs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoldierPos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFireSold1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureSoldierPos1;
        private PictureBox pictureBoxOrc;
        private PictureBox pictureBoxFireSold1;
        private ProgressBar progressBarOrc;
        private Label labelOrcHP;
        private Label labelSoldier1HP;
        private ProgressBar progressBarSoldier1;
        private Button buttonBuyArmor;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button buttonBuyStrenght;
        private PictureBox pictureBox1;
        private Label labelCoins;
        private Label labelStrenght;
        private Label labelArmor;
    }
}