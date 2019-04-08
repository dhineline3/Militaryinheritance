using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryInheritance
{
    class Infantry:Unit
    {
        public void Description()
        {
            Console.WriteLine("This is the airborne infantry! They jump in behind enemy lines and with very little suppport."  +
                " \nOften acting autonomous as small units, their main missions are the seizure of key airfields & objectives," +
                " disruption behind enemy lines, and direct action & reconnaisance.");

        }
    }
}
