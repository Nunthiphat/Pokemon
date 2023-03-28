using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class MegaCharizard : Pokemon
    {
        public MegaCharizard()
        {
            this.name = "MegaCharizard";
            Random random = new Random();
            this.HP = random.Next(266, 360);
            this._image = Properties.Resources.MegaCharizard;
            this.Attack = random.Next(238, 394);
            this.Defense = random.Next(204, 353);
        }
    }
}
