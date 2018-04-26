using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAudit
{
    class BIOS
    {
        Int16[] BiosCharacteristics;
        string[] BIOSVersion;
        string BuildNumber;
        string Caption;
        string CodeSet;
        string CurrentLanguage;
        string Description;
        Int16 EmbeddedControllerMajorVersion;
        Int16 EmbeddedControllerMinorVersion;
        string IdentificationCode;
        Int16 InstallableLanguages;
        DateTime InstallDate;
        string LanguageEdition;
        string[] ListOfLanguages;
        string Manufacturer;
        string Name;
        string OtherTargetOS;
        bool PrimaryBIOS;
        DateTime ReleaseDate;
        string SerialNumber;
        string SMBIOSBIOSVersion;
        Int16 SMBIOSMajorVersion;
        Int16 SMBIOSMinorVersion;
        bool SMBIOSPresent;
        string SoftwareElementID;
        Int16 SoftwareElementState;
        string Status;
        Int16 SystemBiosMajorVersion;
        Int16 SystemBiosMinorVersion;
        Int16 TargetOperatingSystem;
        string Version;
    }
}
