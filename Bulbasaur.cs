using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur()
        {
            this.name = "Bulbasaur";
            Random random = new Random();
            this.HP = random.Next(200, 294);
            this._image = Properties.Resources.Bulbasaur;
            this.Attack = random.Next(92, 216);
            this.Defense = random.Next(92, 216);
        }
    }
}
