using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Charmeleon : Pokemon
    {
        public Charmeleon()
        {
            this.name = "Charmeleon";
            Random random = new Random();
            this.HP = random.Next(226, 320);
            this._image = Properties.Resources.Charmeleon;
            this.Attack = random.Next(119, 249);
            this.Defense = random.Next(108, 236);
        }
    }
}
