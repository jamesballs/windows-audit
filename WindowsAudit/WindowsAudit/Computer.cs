using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAudit
{
    class Computer
    {
        MotherBoard motherboard;
        BIOS bios;
        List<CPU> cpus;
        List<CacheMemory> cache;
        List<GPU> gpus;
        List<RAM> ram;
        List<Disk> disks;
        List<Battery> batteries;
        List<Fan> fans;
        List<HeatPipe> heatpipes;
        List<CDROMDrive> cdDrives;
        List<Keyboard> keyboards;
        List<Mouse> mice;
        List<Monitor> monitors;
        List<NetworkAdapter> networkAdapters;
        List<Printer> printers;
        List<SoundDevice> soundDevices;
        List<SystemSlot> systemSlots;
        List<USBController> usbControllers;
    }
}
