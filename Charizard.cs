using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Charizard : Pokemon
    {
        public Charizard()
        {
            this.name = "Charizard";
            Random random = new Random();
            this.HP = random.Next(266, 360);
            this._image = Properties.Resources.Charlizard;
            this.Attack = random.Next(155, 293);
            this.Defense = random.Next(144, 280);
        }
    }
}
