﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manchkin_online
{
    class Door : Card
    {
        public Door(string name, string location) : base(name, location)
        {
        }

        Meta meta;

        public override int Get_ID()
        {
            return meta.ID;
        }
    }
}
