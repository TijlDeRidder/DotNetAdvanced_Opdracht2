using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Varken : Dier
    {
        public Varken(int weight)
        {
            pronunciation = "oink";
            this.weight = weight;
        }
        public String Pronunciation
        {
            get { return pronunciation; }
            set { pronunciation = value; }
        }
        public String Sound
        {
            set { sound = value; }
            get { return sound; }
        }

    }
}
