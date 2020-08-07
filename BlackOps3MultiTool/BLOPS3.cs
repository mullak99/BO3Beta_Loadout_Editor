using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BLOPS3
{
    class CLASS1
    {
        public static string Primary = "E2B06B35B";
        public static string PrimaryOptic = "E2B06B35E";
        public static string PrimaryAttach1 = "E2B06B35F";
        public static string PrimaryAttach2 = "E2B06B360";
        public static string PrimaryAttach3 = "E2B06B361";
        public static string PrimaryAttach4 = "E2B06B362";
        public static string PrimaryAttach5 = "E2B06B363";

        public static string Secondary = "E2B06B39E";
        public static string SecondaryOptic = "E2B06B393";
        public static string SecondaryAttach1 = "E2B06B394";
        public static string SecondaryAttach2 = "E2B06B395";
        public static string SecondaryAttach3 = "E2B06B396";
        public static string SecondaryAttach4 = "E2B06B397";
        public static string SecondaryAttach5 = "E2B06B398";

        public static string PerkOne = "E2B06B372";
        public static string PerkTwo = "E2B06B373";
        public static string PerkThree = "E2B06B374";
        public static string PerkFour = "E2B06B375";
        public static string PerkFive = "E2B06B376";
        public static string PerkSix = "E2B06B377";

        public static string WildcardOne = "E2B06B380";
        public static string WildcardTwo = "E2B06B37E";
        public static string WildcardThree = "E2B06B37F";

        public static string Lethal = "E2B06B385";
        public static string Tactical = "E2B06B367";
    }

    class CLASS2
    {
        public static string Primary = "E2B06B3C4";
        public static string PrimaryOptic = "E2B06B3C7";
        public static string PrimaryAttach1 = "E2B06B3C8";
        public static string PrimaryAttach2 = "E2B06B3C9";
        public static string PrimaryAttach3 = "E2B06B3D0";
        public static string PrimaryAttach4 = "E2B06B3D1";
        public static string PrimaryAttach5 = "E2B06B3D2";

        public static string Secondary = "E2B06B407";
        public static string SecondaryOptic = "E2B06B3FC";
        public static string SecondaryAttach1 = "E2B06B3FD";
        public static string SecondaryAttach2 = "E2B06B3FE";
        public static string SecondaryAttach3 = "E2B06B3FF";
        public static string SecondaryAttach4 = "E2B06B400";
        public static string SecondaryAttach5 = "E2B06B401";

        public static string PerkOne = "E2B06B3DB";
        public static string PerkTwo = "E2B06B3DC";
        public static string PerkThree = "E2B06B3DD";
        public static string PerkFour = "E2B06B3DE";
        public static string PerkFive = "E2B06B3DF";
        public static string PerkSix = "E2B06B3E0";

        public static string WildcardOne = "E2B06B3E9";
        public static string WildcardTwo = "E2B06B3E7";
        public static string WildcardThree = "E2B06B37F";

        public static string Lethal = "E2B06B3EE";
        public static string Tactical = "E2B06B3D0";
    }

    class CLASS3
    {

    }

    class CLASS4
    {

    }

    class GUN
    {
        public static int GunToInt(string Gun)
        {
            if (Gun == "Kuda")
            {
                return 2;
            }
            if (Gun == "VMP")
            {
                return 4;
            }
            if (Gun == "Weevil")
            {
                return 6;
            }
            if (Gun == "Vesper")
            {
                return 8;
            }
            if (Gun == "Pharo")
            {
                return 10;
            }
            if (Gun == "Razorback")
            {
                return 12;
            }
            if (Gun == "HG 40")
            {
                return 14;
            }
            if (Gun == "KN-44")
            {
                return 16;
            }
            if (Gun == "XR-2")
            {
                return 18;
            }
            if (Gun == "HVK-30")
            {
                return 20;
            }
            if (Gun == "ICR-1")
            {
                return 22;
            }
            if (Gun == "Man-O-War")
            {
                return 24;
            }
            if (Gun == "Sheiva")
            {
                return 26;
            }
            if (Gun == "M8A7")
            {
                return 28;
            }
            if (Gun == "MX Garand")
            {
                return 30;
            }
            if (Gun == "FFAR")
            {
                return 32;
            }
            if (Gun == "KRM-262")
            {
                return 35;
            }
            if (Gun == "205 Brecci")
            {
                return 35;
            }
            if (Gun == "Haymaker 12")
            {
                return 36;
            }
            if (Gun == "Argus")
            {
                return 37;
            }
            if (Gun == "Banshii")
            {
                return 38;
            }
            if (Gun == "BRM")
            {
                return 39;
            }
            if (Gun == "Dingo")
            {
                return 41;
            }
            if (Gun == "Gorgon")
            {
                return 43;
            }
            if (Gun == "48 Dredge")
            {
                return 45;
            }
            if (Gun == "Drakon")
            {
                return 47;
            }
            if (Gun == "Locus")
            {
                return 49;
            }
            if (Gun == "P-06")
            {
                return 51;
            }
            if (Gun == "SVG-100")
            {
                return 53;
            }
            if (Gun == "RSA Interdiction")
            {
                return 55;
            }
            if (Gun == "MR6")
            {
                return 57;
            }
            if (Gun == "MR6 Dual Wield")
            {
                return 58;
            }
            if (Gun == "RK5")
            {
                return 60;
            }
            if (Gun == "RK5 Dual Wield")
            {
                return 62;
            }
            if (Gun == "L-CAR 9")
            {
                return 65;
            }
            if (Gun == "L-CAR 9 Dual Wield")
            {
                return 63;
            }
            if (Gun == "Marshal 16")
            {
                return 68;
            }
            if (Gun == "Marshal 16 Dual Wield")
            {
                return 66;
            }
            if (Gun == "Rift E9")
            {
                return 69;
            }
            if (Gun == "XM-53")
            {
                return 70;
            }
            if (Gun == "BlackCell")
            {
                return 71;
            }
            if (Gun == "L4 Siege")
            {
                return 72;
            }
            if (Gun == "Combat Knife")
            {
                return 73;
            }
            if (Gun == "Butterfly Knife")
            {
                return 75;
            }
            if (Gun == "Wrench")
            {
                return 76;
            }
            if (Gun == "Brass Knuckles")
            {
                return 77;
            }
            if (Gun == "Iron Jim")
            {
                return 78;
            }
            if (Gun == "Fury's Song")
            {
                return 79;
            }
            if (Gun == "MVP")
            {
                return 80;
            }
            if (Gun == "Malice")
            {
                return 81;
            }
            if (Gun == "Carver")
            {
                return 82;
            }
            if (Gun == "Skull Splitter")
            {
                return 83;
            }
            if (Gun == "Slash N' Burn")
            {
                return 84;
            }
            if (Gun == "Nightbreaker")
            {
                return 85;
            }
            if (Gun == "Buzz Cut")
            {
                return 86;
            }
            if (Gun == "NX ShadowClaw")
            {
                return 89;
            }
            if (Gun == "NX ShadowClaw Dual Wield")
            {
                return 90;
            }
            else
            {
                return 0;
            }

        }
    }

    class OPTICS
    {
        public static int SightToInt(string Sight)
        {
            if(Sight == "Reflex")
            {
                return 1;
            }
            if (Sight == "Recon")
            {
                return 2;
            }
            if (Sight == "Varix")
            {
                return 3;
            }
            if (Sight == "Thermal")
            {
                return 4;
            }
            else
            {
                return 0;
            }

        }
    }

    class ATTACHMENTS
    {
        public static int AttachmentToInt(string Attachment)
        {
            if(Attachment == "Quickdraw")
            {
                return 5;
            }
            if (Attachment == "Suppressor")
            {
                return 6;
            }
            if (Attachment == "Grip")
            {
                return 7;
            }
            if (Attachment == "High Caliber")
            {
                return 8;
            }
            if (Attachment == "Stock")
            {
                return 9;
            }
            if (Attachment == "Laser Sight")
            {
                return 10;
            }
            if (Attachment == "FMJ")
            {
                return 11;
            }
            if (Attachment == "Fast Mags")
            {
                return 12;
            }
            if (Attachment == "Extended Mag")
            {
                return 13;
            }
            if (Attachment == "Long Barrel")
            {
                return 14;
            }
            if (Attachment == "Rapid Fire")
            {
                return 15;
            }
            else
            {
                return 0;
            }

        }
    }

    class LETHAL
    {
        public static int LethalToInt(string Lethal)
        {
            if (Lethal == "Frag")
            {
                return 61;
            }
            if (Lethal == "Semtex")
            {
                return 63;
            }
            if (Lethal == "Trip Mine")
            {
                return 65;
            }
            if (Lethal == "Thermite")
            {
                return 66;
            }
            if (Lethal == "Combat Axe")
            {
                return 62;
            }
            if (Lethal == "C4")
            {
                return 64;
            }
            else
            {
                return 0;
            }

        }
    }

    class TACTICAL
    {
        public static int TacticalToInt(string Tactical)
        {
            if (Tactical == "Concussion")
            {
                return 71;
            }
            if (Tactical == "Flashbang")
            {
                return 74;
            }
            if (Tactical == "EMP")
            {
                return 72;
            }
            if (Tactical == "Black Hat")
            {
                return 76;
            }
            if (Tactical == "Smoke Screen")
            {
                return 70;
            }
            if (Tactical == "Trophy System")
            {
                return 78;
            }
            if (Tactical == "Shock Charge")
            {
                return 75;
            }
            else
            {
                return 0;
            }


        }
    }

    class PERKS
    {
        public static int PerkToInt(string Perk)
        {
            if (Perk == "Afterburner")
            {
                return 154;
            }
            if (Perk == "Sixth Sense")
            {
                return 168;
            }
            if (Perk == "Blind Eye")
            {
                return 149;
            }
            if (Perk == "Overclock")
            {
                return 155;
            }
            if (Perk == "Flak Jacket")
            {
                return 148;
            }
            if (Perk == "Ghost")
            {
                return 151;
            }
            if (Perk == "Lightweight")
            {
                return 153;
            }
            if (Perk == "Fast Hands")
            {
                return 159;
            }
            if (Perk == "Ante Up")
            {
                return 162;
            }
            if (Perk == "Hard Wired")
            {
                return 156;
            }
            if (Perk == "Tracker")
            {
                return 161;
            }
            if (Perk == "Cold Blooded")
            {
                return 158;
            }
            if (Perk == "Scavenger")
            {
                return 157;
            }
            if (Perk == "Toughness")
            {
                return 160;
            }
            if (Perk == "Gung-Ho")
            {
                return 170;
            }
            if (Perk == "Blast Suppressor")
            {
                return 152;
            }
            if (Perk == "Awareness")
            {
                return 167;
            }
            if (Perk == "Engineer")
            {
                return 164;
            }
            if (Perk == "Tactical Mask")
            {
                return 166;
            }
            if (Perk == "Dead Silence")
            {
                return 165;
            }
            if (Perk == "Dexterity")
            {
                return 163;
            }
            else
            {
                return 0;
            }

        }
    }
    
    class WILDCARDS
    {
        public static int WildcardToInt(string Wildcard)
        {
            if (Wildcard == "Primary Gunfighter")
            {
                return 178;
            }
            if (Wildcard == "Secondary  Gunfighter")
            {
                return 179;
            }
            if (Wildcard == "Overkill")
            {
                return 180;
            }
            if (Wildcard == "Perk 1 Greed")
            {
                return 181;
            }
            if (Wildcard == "Perk 2 Greed")
            {
                return 182;
            }
            if (Wildcard == "Perk 3 Greed")
            {
                return 183;
            }
            if (Wildcard == "Danger Close")
            {
                return 184;
            }
            if (Wildcard == "Tactician")
            {
                return 185;
            }
            else
            {
                return 0;
            }


        }
    }

    class SPECIALIST
    {
        public static string Character = "E2B06A983";
        public static string Weapon = "E2B06A97D";




        public static int CharacterToInt(string Character)
        {
            if(Character == "Ruin")
            {
                return 0;
            }
            if (Character == "Outrider")
            {
                return 1;
            }
            if (Character == "Prophet")
            {
                return 2;
            }
            if (Character == "Battery")
            {
                return 3;
            }
            if (Character == "Seraph")
            {
                return 4;
            }
            if (Character == "Nomad")
            {
                return 5;
            }
            if (Character == "Reaper")
            {
                return 6;
            }
            if (Character == "Spectre")
            {
                return 7;
            }
            if (Character == "Firebreak")
            {
                return 8;
            }
            else
            {
                return 0;
            }
        }

        public static int WeaponToInt(string Weapon)
        {
            if (Weapon == "Scythe (Reaper)")
            {
                return 111;
            }
            if (Weapon == "Tempest (Prophet)")
            {
                return 112;
            }
            if (Weapon == "Gravity Spikes (Ruin)")
            {
                return 113;
            }
            if (Weapon == "Ripper (Spectre)")
            {
                return 114;
            }
            if (Weapon == "Annihilator (Seraph)")
            {
                return 115;
            }
            if (Weapon == "Sparrow (Outrider)")
            {
                return 117;
            }
            if (Weapon == "H.I.V.E (Nomad)")
            {
                return 118;
            }
            if (Weapon == "Purifier (Firebreak)")
            {
                return 119;
            }
            if (Weapon == "Active Camo (Spectre)")
            {
                return 80;
            }
            if (Weapon == "Vision Pulse (Outrider)")
            {
                return 81;
            }
            if (Weapon == "Kinetic Armor (Battery)")
            {
                return 82;
            }
            if (Weapon == "Overdrive (Ruin)")
            {
                return 86;
            }
            if (Weapon == "Combat Focus (Seraph)")
            {
                return 87;
            }
            if (Weapon == "Glitch (Prophet)")
            {
                return 88;
            }
            if (Weapon == "Psychosis (Reaper)")
            {
                return 89;
            }
            if (Weapon == "Rejack (Nomad)")
            {
                return 90;
            }
            if (Weapon == "Heat Wave (Firebreak)")
            {
                return 91;
            }
            else
            {
                return 0;
            }
        }

    }

    class SCORESTREAK
    {
        public static string Scorestreak1 = "E2B06A98A";
        public static string Scorestreak2 = "E2B06A98B";
        public static string Scorestreak3 = "E2B06A98C";

        public static int StreakToInt(string Streak)
        {
            if(Streak == "HC-XD")
            {
                return 198;
            }
            if (Streak == "UAV")
            {
                return 199;
            }
            if (Streak == "Care Pack")
            {
                return 202;
            }
            if (Streak == "Counter-UAV")
            {
                return 201;
            }
            if (Streak == "Guardian")
            {
                return 203;
            }
            if (Streak == "Rolling Thunder")
            {
                return -989855521;
            }
            if (Streak == "Wraith")
            {
                return 212;
            }
            if (Streak == "Dart")
            {
                return 224;
            }
            if (Streak == "Hellstorm")
            {
                return 204;
            }
            if (Streak == "G.I Unit")
            {
                return 226;
            }
            if (Streak == "Cerberus")
            {
                return 211;
            }
            if (Streak == "H.A.T.R")
            {
                return 213;
            }
            if (Streak == "Power Core")
            {
                return 216;
            }
            if (Streak == "Mothership")
            {
                return 218;
            }
            if (Streak == "Talon")
            {
                return 225;
            }
            if (Streak == "Lightning Strike")
            {
                return 205;
            }
            if (Streak == "Sentry Gun")
            {
                return 207;
            }
            if (Streak == "R.A.P.S")
            {
                return 222;
            }
            else
            {
                return 0;
            }
        }
    }

    class GLOBAL
    {
        public static string Tokens = "E2B0561D1";
        public static string UAV = "E2DCB0728";
        public static string HATER = "E2DCB072C";
        public static string XP = "14053E4A0";

    }

}
