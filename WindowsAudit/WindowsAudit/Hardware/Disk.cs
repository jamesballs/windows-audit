using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsAudit
{
    class Disk
    {
        Int16 Access;
        Int16 Availability;
        Int64 BlockSize;
        string Caption;
        bool Compressed;
        Int32 ConfigManagerErrorCode;
        bool ConfigManagerUserConfig;
        string CreationClassName;
        string Description;
        string DeviceID;
        Int32 DriveType;
        bool ErrorCleared;
        string ErrorDescription;
        string ErrorMethodology;
        string FileSystem;
        Int64 FreeSpace;
        DateTime InstallDate;
        Int32 LastErrorCode;
        Int32 MaximumComponentLength;
        Int32 MediaType;
        string Name;
        Int64 NumberOfBlocks;
        string PNPDeviceID;
        Int16[] PowerManagementCapabilities;
        bool PowerManagementSupported;
        string ProviderName;
        string Purpose;
        bool QuotasDisabled;
        bool QuotasIncomplete;
        bool QuotasRebuilding;
        Int64 Size;
        string Status;
        Int16 StatusInfo;
        bool SupportsDiskQuotas;
        bool SupportsFileBasedCompression;
        string SystemCreationClassName;
        string SystemName;
        bool VolumeDirty;
        string VolumeName;
        string VolumeSerialNumber;
    }
}
