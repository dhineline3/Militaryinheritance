using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryInheritance
{
    class WeaponsAndEquipment
    {
        public void NightVision(string nightVision)
        {
            Console.WriteLine($"The soldiers have their night visions goggles ready! {nightVision}");
        }
        public void Water(string water)
        {
            Console.WriteLine($"The soldiers pack water in their rucksacks! {water}");
        }
        public void Food(string food)
        {
            Console.WriteLine($"The soldiers pack enough food to last the mission! {food}");
        }
        public void SmallArms(string smallArms)
        {
            Console.WriteLine($"The soldier prep M9s, M4s, M249s, M240s, Carl Gustavs, Javelins, and 60mm Mortars! {smallArms}" );
        }
        public void Oil(string oil)
        {
            Console.WriteLine($"The mechanics change the oil and conduct proper pre mission maintenance on their vehicles! {oil}");
        }
        public void LargeArms(string largeArms)
        {
            Console.WriteLine($"The mechanics and soldiers fill their vehicle with all proper munitions! {largeArms}");
        }
    }
}
