﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Charmander : Pokemon
    {
        public Charmander() 
        {
            this.name = "Charmander";
            Random random = new Random();
            this.HP = random.Next(188, 282);
            this._image = Properties.Resources.Charmander;
            this.Attack = random.Next(98, 223);
            this.Defense = random.Next(81, 203);
        }
    }
}
