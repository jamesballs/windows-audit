using System;
using System.Collections.Generic;
using System.Management;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAudit
{
    class Software
    {
        public static List<Battery> GetBatteries()
        {
            ManagementObjectCollection batteryCol = new ManagementObjectSearcher("SELECT * FROM Win32_Battery").Get();
            List<Battery> batteries = new List<Battery>();

            foreach (ManagementObject obj in batteryCol)
            {
                Battery currentBattery = new Battery();

                foreach (var prop in currentBattery.GetType().GetProperties())
                {
                    prop.SetValue(currentBattery, Convert.ChangeType(obj[prop.Name], prop.PropertyType));
                }

                batteries.Add(currentBattery);
            }

            return batteries;
        }

        public static List<BIOS> GetBIOS()
        {
            ManagementObjectCollection biosCol = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS").Get();
            List<BIOS> bios = new List<BIOS>();

            foreach (ManagementObject obj in biosCol)
            {
                BIOS currentBIOS = new BIOS();

                foreach (var prop in currentBIOS.GetType().GetProperties())
                {
                    prop.SetValue(currentBIOS, Convert.ChangeType(obj[prop.Name], prop.PropertyType));
                }

                bios.Add(currentBIOS);
            }

            return bios;
        }

        public static List<CacheMemory> GetCache()
        {
            ManagementObjectCollection cacheCol = new ManagementObjectSearcher("SELECT * FROM Win32_CacheMemory").Get();
            List<CacheMemory> cache = new List<CacheMemory>();

            foreach (ManagementObject obj in cacheCol)
            {
                CacheMemory currentCache = new CacheMemory();

                foreach (var prop in currentCache.GetType().GetProperties())
                {
                    prop.SetValue(currentCache, Convert.ChangeType(obj[prop.Name], prop.PropertyType));
                }

                cache.Add(currentCache);
            }

            return cache;
        }

        public static List<CDROMDrive> GetCDDrives()
        {
            ManagementObjectCollection cdDriveCol = new ManagementObjectSearcher("SELECT * FROM Win32_").Get();
            List<CDROMDrive> cdDrives = new List<CDROMDrive>();

            foreach (ManagementObject obj in cdDriveCol)
            {
                CDROMDrive currentCache = new CDROMDrive();

                foreach (var prop in currentCache.GetType().GetProperties())
                {
                    prop.SetValue(currentCache, Convert.ChangeType(obj[prop.Name], prop.PropertyType));
                }

                cdDrives.Add(currentCache);
            }

            return cdDrives;
        }
    }
}
