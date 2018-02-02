using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdvance
{
    abstract class Auto
    {
        public int VykonMotoru        // property
        {
            get;
            set;

        }

        public void VypisVykon()
        {
            Console.WriteLine("vykon je {0}", VykonMotoru);
        }
    }
}
