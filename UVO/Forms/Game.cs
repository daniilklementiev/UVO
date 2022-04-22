using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace UVO.Forms
{
    public partial class Game : Form
    {
        private readonly Logger _logger;
        Soldier soldier1;
        Orc orcRus;
        private int bulletCountDown;
        public Game(Logger logger)
        {
            InitializeComponent();
            _logger = logger;
            bulletCountDown = 0;            
            soldier1 = new Soldier
            {
                name = "Азовец",
                HP = 100,
                Strenght = 7,
                Armor = 20
            };
            orcRus = new Orc
            {
                name = "Cтиралкин",
                HP = 100,
                Strenght = 5,
                Armor = 4
            };
        }

        private void Game_Load(object sender, EventArgs e)
        {
            foreach (var pb in Controls)
            {
                if (pb is ProgressBar)
                {
                    var prog = pb as ProgressBar;
                    if (prog == null) continue;
                    prog.Minimum = 0;
                    prog.Maximum = 100;
                    prog.Value = 100;
                }
            }
            timer1.Start();
            

        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            try
            {
                if(progressBarOrc.Value < soldier1.Strenght)
                {
                    progressBarOrc.Value = 0;
                    var res = MessageBox.Show("Вы дали п***ов тупому орку", "Game win", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        Close();
                    }
                    return;
                }
                else
                {
                    progressBarOrc.Value = soldier1.Attack(orcRus);
                    if (soldier1.HP > 0) labelCoins.Text = (int.Parse(labelCoins.Text) + 100).ToString();
                    pictureBoxFireSold1.Visible = true;
                    bulletCountDown = 1; 
                    // pictureBoxFireSold1.Visible = false;
                    progressBarSoldier1.Value = orcRus.Attack(soldier1);
                }
                if (orcRus.HP <= 0 || soldier1.HP <= 0)
                {
                    var res = MessageBox.Show("Вы дали п***ов тупому орку", "Game over", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelOrcHP.Text = $"{orcRus.name}: {progressBarOrc.Value}HP";
            labelSoldier1HP.Text = $"{soldier1.name}: {progressBarSoldier1.Value}HP";
            labelStrenght.Text = $"Сила: {soldier1.Strenght}";
            labelArmor.Text = $"Защита: {soldier1.Armor}";
            soldier1.HP = progressBarSoldier1.Value;
            orcRus.HP = progressBarOrc.Value;
            
            if(bulletCountDown > 0)
            {
                bulletCountDown--;
                if (bulletCountDown == 0)
                {
                    pictureBoxFireSold1.Visible = false;
                }
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void buttonBuyArmor_Click(object sender, EventArgs e)
        {
            if (int.Parse(labelCoins.Text) >= 200)
            {
                soldier1.Armor = soldier1.Armor + 10;
                labelCoins.Text = (int.Parse(labelCoins.Text) - 200).ToString();
            } 
        }

        private void buttonBuyStrenght_Click(object sender, EventArgs e)
        {
            if (int.Parse(labelCoins.Text) >= 200)
            {
                soldier1.Strenght = soldier1.Strenght + 10;
                labelCoins.Text = (int.Parse(labelCoins.Text) - 200).ToString();
            }
        }
    }

    class Soldier
    {
        public String name;
        public int HP { get; set; }
        public int Strenght { get; set; }
        public int Armor { get; set; }

        public Soldier()
        {
            name = String.Empty;
            HP = 100;
            Strenght = 5;
            Armor = 20;
        }

        public int Attack(Orc orc)
        {
            var newHP = orc.HP - Strenght + (orc.Armor / 10);
            return newHP;
        }
    }

    class Orc
    {
        public String name;
        public int HP { get; set; }
        public int Strenght { get; set; }
        public int Armor { get; set; }

        public Orc()
        {
            name = String.Empty;
            HP = 100;
            Strenght = 5;
            Armor = 4;
        }

        public int Attack(Soldier sold)
        {
            var newHP = sold.HP - Strenght + (sold.Armor / 10);
            return newHP;
        }
    }
}
