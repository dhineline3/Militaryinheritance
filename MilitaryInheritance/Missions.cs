using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryInheritance
{
    class Missions
    {
        public void AggressiveMission(string aggroMission)
        {
            Console.WriteLine($"Conducting movement to contact mission! { aggroMission}");
        }
        public void DA(string directAction)
        {
            Console.WriteLine($"The unit conducts a direct action manuever! {directAction}");
        }
        public void DefensiveMission(string defense)
        {
            Console.WriteLine($"Establishing defensive countermeasures! {defense}");
        }
        public void Recon(string recon)
        {
            Console.WriteLine($"The unit conducts reconnaissance missions! {recon}");
        }
        public void Preparation(string prep)
        {
            Console.WriteLine($"The soldiers conduct final PCCs and PCIs! {prep}");
        }
    }
}
