namespace ClassLibraryDier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Oefening1
    {
        abstract class Dier
        {
            public int weight;
            protected String pronunciation;
            protected String sound;

            public Dier()
            {
                pronunciation = "";
                sound = "";
            }

            public int Weight
            {
                get { return weight; }
                set { weight = value; }
            }

        }



    }

}