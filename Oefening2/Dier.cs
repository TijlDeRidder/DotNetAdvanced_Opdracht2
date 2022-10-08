using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    abstract class Dier
    {
        public int weight;
        protected String pronunciation;
        protected System.IO.Stream sound;

        public Dier()
        {
            pronunciation = "";
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public String makeSound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(this.sound);
            sound.Play();
            return pronunciation;
        }
    }
}
