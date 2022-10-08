using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Koe : Dier
    {
        public Koe(int weight)
        {
            this.pronunciation = "boe";
            this.weight = weight;
            this.sound = Properties.Resources.Koe1;
        }
    }
}
