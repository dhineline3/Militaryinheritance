using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryInheritance
{
    class Helicopter:Unit
    {
        public void Description()
        {
            Console.WriteLine("Helicopters provide a variety of logistical support to ground units. \nThey are also " +
                " capable of performing direct action and reconnaisance missions and patrols as autonomous units or" +
                " in conjuction with ground forces." );
        }
    }
}
