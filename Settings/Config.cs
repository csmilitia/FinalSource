using SimpleExternalCheatCSGO.Structs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleExternalCheatCSGO.Settings
{
    public enum GlowType
    {
        Color = 0,
        Vis_Color,
        Health,
    };

    public enum BoneSelector
    {
        Head = (1 << 0),
        Chest = (1 << 1),
        Stomach = (1 << 2),
        Neck = (1 << 3),
    };

    public class WeaponConfig
    {
        #region AimBot
        public bool bAimbotEnabled = true;
        public bool bVisibleCheck = true;
        public bool bTargetOnGroundCheck = true;
        public int iAimbotDeathBreak = 350;
        public float flAimbotFov = 3f;
        public float flAimbotSmooth = 20f;
        #endregion
        #region RecoilControlSystem
        public int iBones = (int)BoneSelector.Head | (int)BoneSelector.Chest | (int) BoneSelector.Stomach;
        public float Vertical = 7f;
        public float Horizontal = 7f;
        public bool bRCS = true;
        #endregion
    }

    public static class Config
    {
        #region WeaponConfig
        public static Dictionary<int, WeaponConfig> WeaponsConfig = new Dictionary<int, WeaponConfig>();

        public static WeaponConfig GetWeaponConfig(int weapon_id)
        {
            if (WeaponsConfig.Count <= 0)
            {
                var weaponconfig = new WeaponConfig();
                WeaponsConfig.Add(0, weaponconfig);
            }
            if (WeaponsConfig.ContainsKey(weapon_id))
                return WeaponsConfig[weapon_id];
            return WeaponsConfig[0];
        }
        #endregion

        #region GlobalsConfig
        public static bool AimbotEnabled = true;
        public static bool MiscEnabled = true;
        public static bool ESPEnabled = true;
        public static int iAimbotKey = 1;
        public static int iPanicKey = 0x79;
        #endregion

        #region GlowESP
        public static bool bGlowEnabled = true;
        public static bool bGlowEnemy = true;
        public static bool bGlowAlly = true;
        public static bool bInnerGlow = false;
        public static bool bFullRender = false;
        public static bool bGlowAfterDeath = false;
        public static bool bGlowWeapons = false;
        public static bool bGlowBomb = false;
        public static GlowType iGlowType = GlowType.Health;
        public static int iGlowToogleKey = -1;
        public static Color bGlowEnemyColor = new Color(200, 0, 0, 200);
        public static Color bGlowEnemyVisibleColor = new Color(255, 0, 65, 150);
        public static Color bGlowAllyColor = new Color(200, 200, 0, 200);
        public static Color bGlowAllyVisibleColor = new Color(0, 169, 251, 150);

        #endregion

        #region AutoAccept&ShowRanks
        public static bool bAutoAccept = false;
        public static bool bShowRanks = true;
        #endregion

        #region ClantagChanger
        public static bool bClanTagChangerEnabled = true;
        public static int iClanTagChanger = 0;
        public static string szClanTag1 = "[Version 0.1]";
        public static string szClanTag2 = "BY ESEA 传说";
        public static int iClantTagDelay = 250;
        #endregion
    }
}
