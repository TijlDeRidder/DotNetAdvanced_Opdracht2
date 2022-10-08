using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Slang : Dier
    {
        public Slang(int weight)
        {
            pronunciation = "ssj";
            this.weight = weight;
            this.sound = Properties.Resources.Slang1;
        }
    }
}
