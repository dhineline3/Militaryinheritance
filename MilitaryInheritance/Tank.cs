using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryInheritance
{
    class Tank:Unit
    {
        public void Description()
        {
            Console.WriteLine("Tanks range from small and mobile to large and powerful. Their main mission is to support" +
                " infantry units in providing a much needed increase in firepower. \nThey also provide logistical support" +
                " and reconnaisance to other ground units. \nThey are very effective against enemy infantry." );
        }
    }
}
