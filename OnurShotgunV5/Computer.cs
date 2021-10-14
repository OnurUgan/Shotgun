using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnurShotgunV5
{
    public class Computer
    {
        public int Ammo { get; set; }
        public string Action { get; set; }

        public Computer()
        {
            Ammo = 0;
            Action = "";
        }

        Random rnd = new Random();

        public string RandomCPU(Computer cpu)
        {
            int rnd14 = rnd.Next(1, 4);

            if(cpu.Ammo <= 0)
            {
                cpu.Action = "Reload";
                cpu.Ammo++;
            }
            else if(cpu.Ammo == 3)
            {
                cpu.Action = "Shotgun";
                cpu.Ammo = 0;
            }
            else
            {
                if(rnd14 == 1)
                {
                    cpu.Action = "Reload";
                    cpu.Ammo++;
                }
                else if(rnd14 == 2)
                {
                    cpu.Action = "Block";
                }
                else
                {
                    cpu.Action = "Shoot";
                    cpu.Ammo--;
                }
            }return cpu.Action;
        }

    }

}
