using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnurShotgunV5
{
    public partial class frmShotgun : Form
    {
        public frmShotgun()
        {
            InitializeComponent();
            btnShoot.Enabled = false;
            btnShotgun.Enabled = false;
        }

        Player player = new Player();
        Computer cpu = new Computer();

        string winner = "";

        public string TheWinner()
        {
            if (player.Action == "Shoot" && cpu.Action == "Reload")
            {
                return "player";
            }
            else if(cpu.Action == "Shoot" && player.Action == "Reload")
            {
                return "cpu";
            }
            else if (player.Action == "Shotgun" && cpu.Action != "Shotgun")
            {
                return "player";
            }
            else if (player.Action != "Shotgun" && cpu.Action == "Shotgun")
            {
                return "cpu";
            }
            return "";
        }

        public void Interface()
        {
            lblPlayerMove.Text = player.Action;
            lblComputerMove.Text = cpu.Action;
            lblPlayerAmmo.Text = "Ammo: " + player.Ammo.ToString();
            lblComputerAmmo.Text = "Ammo: " + cpu.Ammo.ToString();

            if(player.Ammo <= 0)
            {
                btnShoot.Enabled = false;
                btnShotgun.Enabled = false;
            }
            else
            {
                btnShoot.Enabled = true;
                if(player.Ammo >= 3)
                {
                    btnShotgun.Enabled = true;
                }
                else
                {
                    btnShotgun.Enabled = false;
                }
            }
        }

        public void DisableButtons()
        {
            btnShoot.Enabled = false;
            btnReload.Enabled = false;
            btnBlock.Enabled = false;
            btnShotgun.Enabled = false;
        }

        public void EnableButtons()
        {
            btnShoot.Enabled = true;
            btnReload.Enabled = true;
            btnBlock.Enabled = true;
            btnShotgun.Enabled = true;
        }

        public void TheGame(Player player, Computer cpu, string playerMove)
        {
            cpu.Action = cpu.RandomCPU(cpu);
            player.Action = playerMove;
            player.Choice(player);
            Interface();
            winner = TheWinner();
            if (winner == "player")
            {
                MessageBox.Show("U won!");
                DisableButtons();
            }
            else if(winner == "cpu")
            {
                MessageBox.Show("Cpu won!");
                DisableButtons();
            }
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            TheGame(player, cpu, "Shoot");
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            TheGame(player, cpu, "Block");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            TheGame(player, cpu, "Reload");
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            TheGame(player, cpu, "Shotgun");
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            EnableButtons();
            player.Ammo = 0;
            cpu.Ammo = 0;
            player.Action = "";
            cpu.Action = "";
            Interface();
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
