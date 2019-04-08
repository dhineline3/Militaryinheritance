using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryInheritance
{
    class Program
    {
        static void DoWork()
        {
            Unit myunit = new Unit();

            myunit.Importance();
            Tank myTank = new Tank();
            myTank.Description();
            WeaponsAndEquipment tankEquipment = new WeaponsAndEquipment();
            tankEquipment.LargeArms("Make sure we fill this tank with maximum shells!");
            tankEquipment.NightVision("Confirm that the night vision, thermal, and other sensors are all working properly!");
            tankEquipment.Oil("Make sure that this tank has proper maintenance conducted!");
            tankEquipment.Food("3 cases of MREs should be plenty!");
            tankEquipment.Water("8 canisters of water is the requirement!");
            Missions tankMission = new Missions();
            tankMission.Recon("The tanks conduct reconnaisance patrols!");
            tankMission.AggressiveMission("The columns of tanks race across the countryside at high speeds, destroying all enemies in sight!");
            tankMission.DA("The tanks destroy enemy infantry and tanks in epic fashion!");
            tankMission.DefensiveMission("After destroying key enemy ground elements, the tanks set up a a perimeter.");
            Console.WriteLine();


            myunit.Importance();
            Helicopter myHelicopter = new Helicopter();
            myHelicopter.Description();
            WeaponsAndEquipment helicopterEquipment = new WeaponsAndEquipment();
            helicopterEquipment.Oil("Change all filters, fluids, and add some air freshners!");
            helicopterEquipment.NightVision("Make sure the electronics are set!");
            helicopterEquipment.LargeArms("Make sure every helicopter is topped of on rockets, missles, and ammunition!");
            Missions helicopterMission = new Missions();
            helicopterMission.Recon("The helicopter coordinate with infantry and armor to conduct recon patrols.");
            helicopterMission.AggressiveMission("Apaches and Blackhawks move into fighting position!");
            helicopterMission.DA("They engage enemy helicopter and destroy ground forces!");
            helicopterMission.DefensiveMission("The helicopter pilots return to base to refuel and refit.");
            Console.WriteLine();

            myunit.Importance();
            Infantry myInfantry = new Infantry();
            myInfantry.Description();
            WeaponsAndEquipment infantryEquipment = new WeaponsAndEquipment();
            infantryEquipment.SmallArms(" Ammo loaded!");
            infantryEquipment.Food(" 5 MREs packed!");
            infantryEquipment.Water(" Everyone should have 6 quarts of water!");
            infantryEquipment.NightVision(" Make sure everyone has extra batteries!");
            Missions infantryMission = new Missions();
            infantryMission.Recon("The soldier gather valuable ground intel!");
            infantryMission.AggressiveMission("The paratroopers move out on foot to engage the enemy.");
            infantryMission.DA("Intense close quarter fire fights ensue! Soldiers lay down intense suppressive fire and mauever on the enemy!");
            infantryMission.DefensiveMission("Soldier reconsilidate their lines and dig into semi permanent fighting positions!");
            Console.WriteLine();
            Console.WriteLine("Success! You have annihilated the enemy and brought freedom to the sector!");



        }
        static void Main()
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception {0}", ex.Message);
            }
            
        }
    }
}
