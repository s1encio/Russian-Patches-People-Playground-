using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace Mod
{
    public class Mod
    {
        // Patch images are split over two folders inside your mod folder:
        //   <your mod>/Patches1/   -> everything in the Patches1 list
        //   <your mod>/Patches2/   -> everything in the Patches2 list (+ the Wagner flag)
        // A patch's sprite AND its thumbnail must be in the same folder.
        const string Folder1 = "Patches1/";
        const string Folder2 = "Patches2/";
        const string Category = "Russian Patches";

        // ------------------------------------------------------------------
        //  ADD NEW PATCHES HERE — one line each.
        //
        //  P(name, description, sprite file, thumbnail file, size)
        //    size = pixels-per-unit: BIGGER number = SMALLER patch in game
        //
        //  Shortcut for new patches: if you name the files "xyz.png" and
        //  "xyz logo.png", you can just write  P("Name", "Desc", "xyz", 200f)
        // ------------------------------------------------------------------
        // ===== images in Patches1 folder =====
        static readonly PatchInfo[] Patches1 =
        {
            P("Russian Flag", "russia flag", "russia_flago.png", "russia_patch.png", 150f),
            P("soviet one", "communism is shit", "ussr.png", "ussr logo.png", 135f),
            P("Polite People", "very polite", "polite1.png", "polite1 logo.png", 225f),
            P("V patch", "v stands for vagina", "vata.png", "vata logo.png", 225f),
            P("Russia Patch", "rossiya", "sossiya.png", "sossiya logo.png", 225f),
            P("Z + Grandma patch", "grandma forgot to take its meds :skull:", "grandma.png", "grandma logo.png", 125f),
            P("Kadyrovites Chechen Flag", "fake chechen flag", "chechen flag.png", "chechen flag logo.png", 100f),
            P("Kadyrovites (aka AXMAT-1) patch", "looks good on atacs, just as the chechen flag", "axmat.png", "axmat logo.png", 110f),
            P("Z patch", "z....", "z_patch_sqaure.png", "z logo.png", 30f),
            P("Z + russia", "zzzzzzzzzzzzzzzzzzzz", "russ x z.png", "russ x z logo.png", 20f),
            P("Wagner Group Patch", "war criminals", "wagner.png", "wagner logo.png", 225f),
            P("Wagner Group Patch 2", "nothing personal, just buisness", "wagner2.png", "wagner2 logo.png", 225f),
            P("Wagner Group Patch 3", "musicians, which whole world knows", "wagner3.png", "wagner 3 logo.png", 220f),
            P("trucker patch", "trucker (dalnoboishik) is a job, but it has another meaning as Far Hitter", "dalnoboishik.png", "dalnoboishik logo.png", 220f),
            P("DPR x Z patch", "some gay flag with Z", "DPR flag x z.png", "DPR flag x z logo.png", 150f),
            P("Kolovorot x Scope", "looks cool", "kolovorot.png", "kolovorot logo.png", 200f),
            P("Z patch with st. gregorian", "fnberigbireuwgberyg", "z4.png", "z4 logo.png", 200f),
            P("O patch", "ooooo my life be like", "o.png", "o logo.png", 190f),
            P("another z patch", "i am going insane", "z5.png", "z5 logo.png", 200f),
            P("Russian Empire Flag", "bazed", "russian empire.png", "russian empire logo.png", 185f),
            P("Russian Empire Flag 2", "we are russians, god is with us", "bog.png", "bog logo.png", 185f),
            P("Rosguard Patch", "uh yes ig", "rosguard.png", "rosguard logo.png", 140f),
            P("Wagner Group Patch Red", "looks fire", "red wagner.png", "red wagner logo.png", 220f),
            P("Kolovorot", "bazed", "kolvorot 2.png", "kolovorot 2 logo.png", 200f),
        };

        // ===== images in Patches2 folder =====
        static readonly PatchInfo[] Patches2 =
        {
            P("USSR x Russia Patch", "better dead than red", "soviet x russia.png", "soviet x russia - logo.png", 150f),
            P("FSB Patch", "very very cool", "FSB.png", "FSB logo.png", 125f),
            P("Sparta Batalion Patch", "motorola was truly the best commander in entire dpr", "Sparta Batalion.png", "Sparta logo.png", 85f),
            P("Somalia Batalion Patch", "givi was worst commander", "Somalia.png", "Somalia logo.png", 85f),
            P("GRU Patch", "batman??!?!?!!?", "GRU.png", "GRU - Copy.png", 110f),
            P("Naval Infantry Patch", "ok", "Naval.png", "Naval - Copy.png", 100f),
            P("Rusich Patch", "VERY SUPER BASED", "Ruisch.png", "Ruisch logo.png", 85f),
            P("Kalmius Patch", "kalmius is a river in donetsk oblast", "Kalmius.png", "Kalmius logo.png", 125f),
            P("Novorossiya Patch", "i am going fucking insaneeeee", "Novorossiya patch.png", "Novorossiya logo.png", 125f),
            P("Russian orthodox army Patch", "i have placed a landmine in your garden", "orthodox.png", "orthodox logo.png", 85f),
            P("Odessa Brigade Patch", "banderovskiye besi, von iz odessi", "Odessa.png", "Odess logo.png", 100f),
            P("Zarya batalion patch", "I cant breath - George Floyd", "zarya.png", "logo.png", 85f),
            P("Spetsnaz DPR", "another batman brigade????", "spetsnaz.png", "spetsnaz logo.png", 200f),
            P("Slavyanskaya Brigada", "girkin is gigachad", "Slavs.png", "Slavs logo.png", 200f),
            P("Miner Brigade", "miners from clash of clans are fighting on dpr side?!?!?!?!?!", "miner division.png", "miner logo.png", 200f),
            P("Varyag Brigade", "wolf", "vryag.png", "vryag logo.png", 200f),
            P("Berkut DPR", "Eagle", "berkut.png", "berkut logo.png", 200f),
            P("Vostok", "it says Patriotic Forces of Donbas", "Vostok.png", "Vostok logo.png", 200f),
            P("Official Wagner Patch", "leto i arbaleti, cha kotleti podedut", "official wagner.png", "official logo.png", 120f),
            P("ZOV wagner", "eta z, eta podeda", "ZOV.png", "ZOV logo.png", 230f),
            P("another shitty wagner patch", "god why are there so many of them", "w1.png", "w1 logo.png", 600f),
            P("Wagners", "wagner patch", "w3.png", "w3 logo.png", 480f),
            P("V sile pravda", "most cursed shit i heard", "vata rulit.png", "vata logotip.png", 110f),
            P("Kitchen", "woman belong to kitchen", "kitchen.png", "kitchen logo.png", 600f),
        };

        public static void Main()
        {
            CategoryBuilder.Create(Category, "adds cool patches", ModAPI.LoadSprite("russia.png"));

            RegisterPatches(Patches1, Folder1);
            RegisterPatches(Patches2, Folder2);

            // The flag is a different item (Stick, not a patch), so it stays separate
            ModAPI.Register(new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Stick"),
                NameOverride = "Wagner Flag",
                DescriptionOverride = "leto i arbaleti",
                CategoryOverride = ModAPI.FindCategory(Category),
                ThumbnailOverride = ModAPI.LoadSprite(Folder2 + "flag.png"),
                AfterSpawn = (Instance) =>
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite(Folder2 + "Wagner flag.png", 6f);
                }
            });
        }

        // ---------------- helpers (no need to touch) ----------------

        static void RegisterPatches(PatchInfo[] list, string folder)
        {
            foreach (PatchInfo patch in list)
            {
                PatchInfo p = patch; // copy for the lambda below

                ModAPI.Register(new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Rod"),
                    NameOverride = p.Name,
                    DescriptionOverride = p.Description,
                    CategoryOverride = ModAPI.FindCategory(Category),
                    ThumbnailOverride = ModAPI.LoadSprite(folder + p.Thumbnail),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite(folder + p.Sprite, p.Size);
                        ArmorBehaviour armor = Instance.AddComponent<ArmorBehaviour>();
                        armor.stabResistance = 0f;
                        armor.armorPiece = "UpperArmFront";
                        armor.armorTier = 0;
                        Instance.FixColliders();
                    }
                });
            }
        }

        static PatchInfo P(string name, string description, string sprite, string thumbnail, float size)
        {
            return new PatchInfo { Name = name, Description = description, Sprite = sprite, Thumbnail = thumbnail, Size = size };
        }

        // Short version: "xyz" -> uses "xyz.png" and "xyz logo.png"
        static PatchInfo P(string name, string description, string baseName, float size)
        {
            return P(name, description, baseName + ".png", baseName + " logo.png", size);
        }

        struct PatchInfo
        {
            public string Name;
            public string Description;
            public string Sprite;
            public string Thumbnail;
            public float Size;
        }
    }
}
