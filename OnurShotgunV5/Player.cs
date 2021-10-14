using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnurShotgunV5
{
    public class Player
    {
        public int Ammo { get; set; }
        public string Action { get; set; }

        public Player()
        {
            Ammo = 0;
            Action = "";
        }

        public void Choice(Player player)
        {
            if(player.Action == "Shoot")
            {
                player.Ammo--;
            }
            else if (player.Action == "Reload")
            {
                player.Ammo++;
            }
            else if(player.Action == "Shotgun")
            {
                player.Ammo = 0;
            }
        }
    }
}
