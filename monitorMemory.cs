using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using ProcessMemoryReaderLib;
using System.Globalization;
using System.Net.Mail;

namespace AntiCheatSoftware
{
    class monitorMemory
    {
        #region -----LocalPlayerAddresses----
        static private int LocalPlayerBase = 0x50F4F4; // Base address for local player
        static private int[] LocalPlayerOff = new int[] { 0x0 };
        // Off sets
        static private int off_health = 0xF8;       // Health
        static private int off_rifle_ammo = 0x150;  // Assault rifle ammo
        #endregion

        static public bool monitorMemoryValues(ProcessMemoryReader Mem)
        {

            int LocalPlayerAddress = Mem.ReadMultiLevelPointer(LocalPlayerBase, 4, LocalPlayerOff);

            int HealthValue = Mem.ReadInt(LocalPlayerAddress + off_health);
            int RiffleAmmoValue = Mem.ReadInt(LocalPlayerAddress + off_rifle_ammo);

            if ((HealthValue > 100) && (!Form1.detected))
            {
                Mem.WriteInt(LocalPlayerAddress + off_health, 10);
                MessageBox.Show("Possible Cheat Detected");
                return true;
            }
                
            return false;
        }
    }
}
