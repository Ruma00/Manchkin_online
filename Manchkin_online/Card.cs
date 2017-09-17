using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Manchkin_online
{
    abstract class Card
    {
        private string name;
        private Image image;

        public Card(string name, string location)
        {
            this.image = Image.FromFile(location);
            this.name = name;
        }

        public abstract int Get_ID();
    }
}
