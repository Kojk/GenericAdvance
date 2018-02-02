using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdvance
{
    class SpravcaAut<T> where T: Auto 
    {
        public void PrehodMotrory(T auto1, T auto2)
        {
            int temp = auto2.VykonMotoru;
            auto2.VykonMotoru = auto1.VykonMotoru;

            auto1.VykonMotoru = temp;
        }
    }
}
