using System;
using System.Threading;
using NCMS;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ai;

namespace MagicRaces
{
    class Magic2
    {
      public static void init()
        {
		 magicgun();

		 static void magicgun() {

            Race human = AssetManager.raceLibrary.get("human");
			Race elf = AssetManager.raceLibrary.get("elf");
            Race orc = AssetManager.raceLibrary.get("orc");
            Race dwarf = AssetManager.raceLibrary.get("dwarf");

            human.preferred_weapons.Add("white_staff");
            //human.preferred_weapons.Remove("stick");
            //human.preferred_weapons.Remove("sword");
            //human.preferred_weapons.Remove("axe");
            //human.preferred_weapons.Remove("spear");
            //human.preferred_weapons.Remove("bow");

            orc.preferred_weapons.Add("necromancer_staff");
            //orc.preferred_weapons.Remove("stick");
            //orc.preferred_weapons.Remove("axe");
            //orc.preferred_weapons.Remove("spear");
            //orc.preferred_weapons.Remove("bow");

			elf.preferred_weapons.Add("druid_staff");
            //elf.preferred_weapons.Remove("stick");
            //elf.preferred_weapons.Remove("spear");
            //elf.preferred_weapons.Remove("bow");
            //elf.preferred_weapons.Remove("sword");

            dwarf.preferred_weapons.Add("evil_staff");
            //dwarf.preferred_weapons.Remove("stick");
            //dwarf.preferred_weapons.Remove("hammer");
            //dwarf.preferred_weapons.Remove("bow");
            //dwarf.preferred_weapons.Remove("sword");
		 }
		}
	}
}