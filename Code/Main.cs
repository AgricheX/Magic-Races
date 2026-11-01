using System;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using ReflectionUtility;
using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using life;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Config;
using System.Reflection;
using UnityEngine.Tilemaps;
using System.IO;

namespace MagicRaces{
    [ModEntry]
    class Main : MonoBehaviour{
        internal const string id = "agriche.mods.worldbox.MagicRaces";
        internal static Harmony harmony;

        void Awake(){
            Debug.Log($"{Mod.Info.Name} loaded!");
            Magic.init();
            Magic2.init();
            var unit_human = AssetManager.actor_library.get("unit_human");
            unit_human.traits.Add("regeneration");
            unit_human.traits.Add("freeze_proof");
            var unit_elf = AssetManager.actor_library.get("unit_elf");
            unit_elf.traits.Add("regeneration");
            unit_elf.traits.Add("acid_proof");
            var unit_orc = AssetManager.actor_library.get("unit_orc");
            unit_orc.traits.Add("poison_immune");
            var unit_dwarf = AssetManager.actor_library.get("unit_dwarf");
            unit_dwarf.traits.Add("regeneration");
            unit_dwarf.traits.Add("fire_proof");
        }
    }
}