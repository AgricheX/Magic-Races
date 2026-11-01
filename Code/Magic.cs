using System;
using System.Threading;
using NCMS;
using UnityEngine;
using Beebyte.Obfuscator;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ai;

namespace MagicRaces
{
    class Magic
    {
      public static void init()
        {
			ActorAsset unit_human = AssetManager.actor_library.get("unit_human");
			ActorAsset unit_elf = AssetManager.actor_library.get("unit_elf");
			ActorAsset unit_orc = AssetManager.actor_library.get("unit_orc");
			ActorAsset unit_dwarf = AssetManager.actor_library.get("unit_dwarf");


        unit_human.attack_spells = List.Of<string>(new string[]{"bloodRain", "lightning", "shield"});
        unit_human.defaultWeapons = List.Of<string>(new string[]{"white_staff"});
        unit_human.effect_cast_top = "fx_cast_top_blue";
		unit_human.effect_cast_ground = "fx_cast_ground_blue";
		unit_human.has_soul = true;

		unit_elf.attack_spells = List.Of<string>(new string[]{"bloodRain", "spawnGrassSeeds", "spawnFertilizer", "shield"});
        unit_elf.defaultWeapons = List.Of<string>(new string[]{"druid_staff"});
        unit_elf.effect_cast_top = "fx_cast_top_blue";
		unit_elf.effect_cast_ground = "fx_cast_ground_blue";
		unit_elf.has_soul = true;

		unit_orc.attack_spells = List.Of<string>(new string[]{"bloodRain", "curse", "shield"});
        unit_orc.defaultWeapons = List.Of<string>(new string[]{"necromancer_staff"});
		unit_orc.effect_cast_top = "fx_cast_top_green";
		unit_orc.effect_cast_ground = "fx_cast_ground_green";
		unit_orc.has_soul = true;

        unit_dwarf.attack_spells = List.Of<string>(new string[]{"bloodRain", "fire", "shield"});
        unit_dwarf.defaultWeapons = List.Of<string>(new string[]{"evil_staff"});
		unit_dwarf.effect_cast_top = "fx_cast_top_red";
		unit_dwarf.effect_cast_ground = "fx_cast_ground_red";
		unit_dwarf.has_soul = true;
    }
  }
}